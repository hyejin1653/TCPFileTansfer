using File_Transfer.Model.ReceiverFiles;
using File_Transfer.Model.SenderFiles;
using File_Transfer.Extensions;
using File_Transfer.LanguageManager;
using File_Transfer.Controller;

using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text;
using System.Net.Sockets;
using System.Net.Http;

namespace File_Transfer.View
{
    public partial class MainView : Form, IMainViewController
    {
        static MainView main;
        static TcpClient client = null;
        TcpClient[] clients = new TcpClient[10];
        public string client_ip;
        public string client_port;
        public int danger;

        public MainView()
        {
            InitializeComponent();
            main = this;
        }

        MainViewController Controller;
        public void SetController(MainViewController controller)
        {
            this.Controller = controller;
        }

        public string GetInputValueOnForm(MainFormInputs input)
        {
            switch (input)
            {
                case MainFormInputs.ReceiveIPAdress        :    return txtReceiveIpAdress.Text;
                case MainFormInputs.ReceivePortNumber      :    return txtReceivePort.Text;
                case MainFormInputs.SaveLocationForReceive :    return txtSaveLocation.Text;

                case MainFormInputs.SendIPAdress           :    return txtSendIpAdress.Text;
                case MainFormInputs.SendPortNumber         :    return txtSendPort.Text;
                case MainFormInputs.FileNameForSend        :    return txtFileName.Text;
                default: return string.Empty;
            }
        }

        private void BtnSelectSaveLocation_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtSaveLocation.Text = dlg.SelectedPath;
                }
            }
        }

        private void BtnSendFile_Click(object sender, EventArgs e)
        {
            Controller.SendFileOrCancel();

        }
        private void BtnReceiveFile_Click(object sender, EventArgs e)
        {
           Controller.ReceiveFileOrCancel();
        }

        private void RedirectLinkLabels(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string redirectCode = ((LinkLabel)sender).Tag.ToString();
            string redirectUrl = string.Empty;

            switch (redirectCode)
            {
                case "github_repo": redirectUrl = "https://github.com/firateski/TCPFileTransfer"; break;
                case "firats_website": redirectUrl = "http://firateski.com"; break;
                case "firats_github_page": redirectUrl = "https://github.com/firateski/"; break;
            }

            if (!string.IsNullOrEmpty(redirectUrl))
                System.Diagnostics.Process.Start(redirectUrl);
        }

        public void FileReceiver_ListenStartedEvent()
        {
            labelReceivedProgress.Text = Translator.GetStringFromResource("WaitingForFile");
            btnReceiveFile.Text = Translator.GetStringFromResource("CancelWaiting");

            btnSelectSaveLocation.Enabled = false;
            txtReceiveIpAdress.Enabled = false;
            txtReceivePort.Enabled = false;
            txtSaveLocation.Enabled = false;
        }
        public void FileReceiver_ListenCompletedEvent(ReceiveResult result)
        {
            if (result == ReceiveResult.RequestAccepted)
            {
                labelReceivedProgress.Text = Translator.GetStringFromResource("FileRequestHasCame");
            }
            else if (result == ReceiveResult.ListeningCancelled)
            {
                //Controller.FileReceiver = null;
                btnReceiveFile.Text = Translator.GetStringFromResource("btnReceiveFile");
                labelReceivedProgress.Text = Translator.GetStringFromResource("FileWaitingWasCancelled");

                btnSelectSaveLocation.Enabled = true;
                txtReceiveIpAdress.Enabled = true;
                txtReceivePort.Enabled = true;
                txtSaveLocation.Enabled = true;
            }
        }
        public void FileReceiver_ReceivingStartedEvent()
        {
            progressBarReceiveFile.Visible = true;
            btnReceiveFile.Text = Translator.GetStringFromResource("CancelTransfer");
            labelReceivedProgress.Text = Translator.GetStringFromResource("FileRequestJustComeUpWaitingUserResponse");
        }
        public void FileReceiver_ReceivingCompletedEvent(ReceiveResult result, string message, string title)
        {
            if (result == ReceiveResult.Completed)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == ReceiveResult.FileIgnoredByUser)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result == ReceiveResult.Cancelled)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result == ReceiveResult.CannotReceived)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBarReceiveFile.Value = 0;
            btnReceiveFile.Text = Translator.GetStringFromResource("btnReceiveFile");
            labelReceivedProgress.Text = string.Empty;

            progressBarReceiveFile.Visible = false;
            btnSelectSaveLocation.Enabled = true;
            txtReceiveIpAdress.Enabled = true;
            txtReceivePort.Enabled = true;
            txtSaveLocation.Enabled = true;
        }
        public void FileReceiver_ProgressChangedEvent(long current, long total, long totalTime)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        labelReceivedProgress.Text = $"{current.formatSize()} / {total.formatSize()} - {totalTime.calcSpeed(current)}";
                        progressBarReceiveFile.Value = current.getPercent(total);
                    }));
                }
                catch (InvalidOperationException)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                }
            }
            else
            {
                labelReceivedProgress.Text = $"{current.formatSize()} / {total.formatSize()} - {totalTime.calcSpeed(current)}";
                progressBarReceiveFile.Value = current.getPercent(total);
            }
        }

        private void txtSaveLocation_Click(object sender, EventArgs e)
        {
            btnSelectSaveLocation.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //메세지 보낼 TCP server open
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 25111);
            server.Start();
            Console.WriteLine("Tcp Server start");

            Thread check = new Thread(() => checkTcpClient(server));
            check.Start();

            Thread thread = new Thread(() => getdataJson());
            thread.Start();

            button1.Enabled = false;
        }

        private void checkTcpClient(TcpListener server)
        {
            Console.WriteLine("Tcp Client 연결 상태 확인 쓰레드 시작");
            while (true)
            {
                client = server.AcceptTcpClient();
                Socket c = client.Client;
                IPEndPoint client_ip = (IPEndPoint)c.RemoteEndPoint;
                string ip = client_ip.Address.ToString();
                string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                
                //연결된 클라이언트 배열에 담기
                for(int i = 0; i < clients.Length; i++)
                {
                    if(clients[i] == null)
                    {
                        clients[i] = client;
                        Console.WriteLine("New Connection!!!  IP : {0} / Time : {1}", ip, now);
                        break;
                    }

                    if (client.Client.Connected && Array.TrueForAll(clients, connectedCli => connectedCli != null))
                    {
                        Console.WriteLine("클라이언트 연결 개수 초과");
                        client.Close();
                    }
                }
            }
        }
        private void getdataJson()
        {
            // 작업 내용
            Console.WriteLine("Get Json String 쓰레드 작동");
            //Console.WriteLine("쓰레드에서 작업 수행 중...");

            string url = "http://" + textBox1.Text + ":" + textBox2.Text + "/";

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Trace.WriteLine("서버가 시작되었습니다. {0}", url);

            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                string dataJson = ProcessRequest(context)+ "\n";
                Console.WriteLine(dataJson);
                if (client != null)
                {
                    sendDataJsonToClient(dataJson);
                }
            }
        }
        private void sendDataJsonToClient(string dataJson)
        {
            foreach(TcpClient client in clients)
            {
                if(client != null)
                {
                    if(client.Client.Connected)
                    {
                        try
                        {
                            NetworkStream networkStream = client.GetStream();
                            byte[] data = Encoding.UTF8.GetBytes(dataJson);
                            networkStream.Write(data, 0, data.Length);
                            networkStream.Flush();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString()); 
                        }
                    }
                    else
                    {
                        client.Close();
                    }
                }
            }
        }


        internal string lastDatetime
        {
            set
            {
                Invoke(new Action(() => {
                    label3.Text = value;
                }));
            }
        }

        static string ProcessRequest(HttpListenerContext context)
        {
            Trace.WriteLine("ProcessRequest in");
            Trace.Flush();
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            // JSON 데이터 수신
            string json;
            using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                json = reader.ReadToEnd();
            }

            // JSON 데이터 역직렬화
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            string dataJson = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

            // 수신한 데이터 사용
            DateTime currentTime = DateTime.Now;

            main.lastDatetime = "마지막 수신시간 : " + currentTime.ToString();

            //main.label3.Text = "마지막 수신시간 : " + currentTime.ToString();
            //main.CurrentTimeSet = currentTime.ToString();

            //main.AccidentLevel = data.AccidentLevel;
            //main.AccidentValue = data.AccidentValue;
            //main.AccidentFlooding = data.AccidentFlooding;
            //main.Lat = data.Lat;
            //main.Lon = data.Lon;


            // 응답 전송
            string responseString = "JSON 데이터를 성공적으로 수신하였습니다.";
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);

            response.ContentType = "text/plain";
            response.ContentLength64 = buffer.Length;

            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();


            Trace.Flush();

            return dataJson;
        }


        // Send Data 탭
        private void BtnSelectFileToSend_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(openFileDialog.FileName);

                    txtFileName.Text = openFileDialog.FileName;
                    //Console.WriteLine(txtFiletoSend.Text);
                }
            }
        }

        private void BtnSendRiskyJson_Click(object sender, EventArgs e)
        {
            client_ip = txtSendIp.Text;
            client_port = SendPort.Text;

            danger = 0;
            if (radioButton1.Checked)
            {
                danger = 1;
            }
            else if (radioButton2.Checked)
            {
                danger = 2;
            }
            else if (radioButton3.Checked)
            {
                danger = 3;
            }
            else if (radioButton4.Checked)
            {
                danger = 4;
            }
            else if (radioButton5.Checked)
            {
                danger = 5;
            }

            ThreadStart threadStart = new ThreadStart(DangerSend);
            Thread thread = new Thread(threadStart);
            // 쓰레드 시작
            thread.Start();
            // 쓰레드 종료 대기
            //thread.Join();
        }

        static async void DangerSend()
        {
            Console.WriteLine("위험도 송신");
            var data = new
            {
                danger = main.danger,
            };

            // JSON 데이터 직렬화
            string json = JsonConvert.SerializeObject(data);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // HTTP POST 요청 설정
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    // HTTP POST 요청 보내기
                    HttpResponseMessage response = await client.PostAsync("http://" + main.client_ip + ":" + main.client_port + "/", content);
                    response.EnsureSuccessStatusCode();

                    // 응답 출력
                    string responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseString);
                }
                catch (WebException ex)
                {
                    Console.WriteLine("WebException occurred: " + ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex);
                }

                /*// HTTP POST 요청 설정
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                // HTTP POST 요청 보내기
                HttpResponseMessage response = await client.PostAsync("http://" + main.client_ip + ":" + main.client_port + "/", content);
                response.EnsureSuccessStatusCode();

                // 응답 출력
                string responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);*/
            }
        }
    }
}
