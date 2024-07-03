using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_XML
{
    public class RouteInfo
    {
        public string m_routeName, m_routeAuthor, m_routeStatus, m_vesselName, m_vesselVoyage, m_optimizationMethod, m_routeChangesHistory;
        public int m_vesselDisplacement, m_vesselCargo, m_vesselMMSI, m_vesselIMO;
        public double m_vesselGM, m_vesselMaxRoll, m_vesselMaxWave, m_vesselMax_Wind, m_vesselSpeedMax, m_vesselServiceMin, m_vesselServiceMax;
        public DateTime m_validityPeriodStart, m_validityPeriodStop;    // ISO 8601이 날짜 형식인데 format 지정해야됨

        public RouteInfo()
        {
            
            m_routeName = "AROUNDtheSKAGEN"; //루트의 이름, Mandatory
            m_routeAuthor = "Lee"; // 루트 작성자, Option
            m_routeStatus = "No Problem"; // 루트 상태, Option
            //m_validityPeriodStart = ""; //유효 기간 시작, Option
            //m_validityPeriodStop = ""; //유효 기간 정지, Option
            m_vesselName = "ACME"; //배의 이름, Option
            m_vesselMMSI = 123456789; //해상이동업무식별번호 숫자 9자리, Option
            m_vesselIMO = 1234567; // 선박의 IMO번호 숫자 7자리, Option
            m_vesselVoyage = "3회"; // 선박의 항해 횟수, Option
            m_vesselDisplacement = 0; // 선박 변위, Option
            m_vesselCargo = 0; // 선박의 화물, Option
            m_vesselGM = 0f; // 메타 중심높이 xx.xx , Option
            m_optimizationMethod = "Use rian tech"; // 최적화 방법, Option
            m_vesselMaxRoll = 0f; // 선박의 허용된 최대 Roll 각도 xx, Option
            m_vesselMaxWave = 0f; // 선박의 유의파도 높이 제한 xx.x, Option
            m_vesselMax_Wind = 0f; // 선박의 최대 풍속 제한 xx.x, Option
            m_vesselSpeedMax = 0f; // 선박의 최대 속도 xx.x, Option
            m_vesselServiceMin = 0f; // 선박의 선호하는 window 서비스 속도 최소 xx.x, Option
            m_vesselServiceMax = 0f; // 선박의 선호하는 window 서비스 속도 최대 xx.x, Option
            m_routeChangesHistory = "Wind,Lee"; // 경로변경 원인, 발신자 및 이유, Option
            
        }

		//m_routeName setter, getter
		public void setRouteName(String routeName) {m_routeName= routeName;}
        public String getRouteName() { return m_routeName; }

		//m_routeAuthor setter, getter
		public void setRouteAuthor(String routeAuthor) { m_routeAuthor = routeAuthor; }
        public String getRouteAuthor() { return m_routeAuthor; }

		//m_routeStatus setter, getter
		public void setRouteStatus(String routeStatus) { m_routeStatus = routeStatus;}
        public String getRouteStatus() {  return m_routeStatus; }

		//m_vesselName setter, getter
		public void setVesselName(String vesselName) { m_vesselName = vesselName;}
        public String getVesselName() { return m_vesselName; }

		//m_vesselMMSI setter, getter
		public void setVesselMMSI(String vesselMMSI) {
            m_vesselMMSI = Int32.Parse(vesselMMSI); 
        }
        public String getVesselMMSI() { return m_vesselMMSI.ToString("D9"); }

		//m_vesselDisplacement setter, getter
		public void setVesselDisplacement(String vesselDisplacement) {
            m_vesselDisplacement= Int32.Parse(vesselDisplacement); 
        }
        public String getVesselDisplacement() { return m_vesselDisplacement.ToString(); }

		//m_vesselCargo setter, getter
		public void setVesselCargo(String vesselCargo) {
            m_vesselCargo = Int32.Parse(vesselCargo); 
        }
        public String getVesselCargo() { return m_vesselCargo.ToString(); }

		//m_vesselIMO setter, getter
		public void setVesselIMO(String vesselImo) {
            m_vesselIMO = Int32.Parse(vesselImo); 
        }
        public String getVesselIMO() { return m_vesselIMO.ToString("D7"); }

		//m_vesselGM setter, getter
		public void setVesselGM(String vesselGM) {
            m_vesselGM = Double.Parse(vesselGM); 
        }
        public String getVesselGM() { return m_vesselGM.ToString("F2"); }

		//m_vesselMaxRoll setter, getter
		public void setVesselMaxRoll(String vesselMaxRoll) { m_vesselMaxRoll = Double.Parse(vesselMaxRoll); }
        public String getVesselMaxRoll() { return m_vesselMaxRoll.ToString(); }

		//m_vesselMaxWave setter, getter
		public void setVesselMaxWave(String vesselMaxWave) { m_vesselMaxWave = Double.Parse(vesselMaxWave); }
        public String getVesselMaxWave() { return m_vesselMaxWave.ToString("F1"); }

		//m_vesselMax_Wind setter, getter
		public void setVesselMaxWind(String vesselMaxWind) { m_vesselMax_Wind = Double.Parse(vesselMaxWind); }
        public String getVesselMaxWind() { return m_vesselMax_Wind.ToString("F1"); }

		//m_vesselSpeedMax setter, getter
		public void setVesselSpeedMax(String vesselSpeedMax) {  m_vesselSpeedMax = Double.Parse(vesselSpeedMax); }
        public String getVesselSpeedMax() { return m_vesselSpeedMax.ToString("F1"); }

		//m_vesselServiceMin setter, getter
		public void setVesselServiceMin(String vesselServiceMin) { m_vesselServiceMin = Double.Parse(vesselServiceMin); }
        public String getVesselServiceMin() { return m_vesselServiceMin.ToString("F1"); }

		//m_vesselServiceMax setter, getter
		public void setVesselServiceMax(String vesselServiceMax) { m_vesselServiceMax = Double.Parse(vesselServiceMax); }
        public String getVesselServiceMax() { return m_vesselServiceMax.ToString("F1"); }


		//m_validityPeriodStart setter, getter
		public void setValidityPeriodStart(String validityPeriodStart)
        {
            m_validityPeriodStart = DateTime.Parse(validityPeriodStart);
        }

        public String getValidityPeriodStart() {
            return m_validityPeriodStart.ToString("yyyy-MM-ddTHH-mm-ssZ");
        }

		//m_validityPeriodStop setter, getter
        public void setValidityPeriodStop(String validityPeriodStop)
        {
            m_validityPeriodStop = DateTime.Parse(validityPeriodStop);
        }

        public String getValidityPeriodStop() {
            return m_validityPeriodStop.ToString("yyyy-MM-ddTHH-mm-ssZ"); 
        }

		//m_vesselVoyage setter, getter
        public void setVesselVoyage(String vesselVoyage)
        {
            m_vesselVoyage = vesselVoyage;
        }
        public String getVesselVoyage() { return m_vesselVoyage; }

		//m_optimizationMethod setter, getter
        public void setOptimizationMethod(String optimizationMethod)
        {
            m_optimizationMethod = optimizationMethod;
        }

        public String getOptimizationMethod() {  return m_optimizationMethod; }

		//m_routeChangesHistory setter, getter
        public void setChangeHistory(String changeHistory)
        {
            m_routeChangesHistory= changeHistory;
        }
        public String getChangeHistory()
        {
            return m_routeChangesHistory;
        }

	}

}
