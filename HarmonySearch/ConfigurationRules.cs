using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySearch
{
    public static class ConfigurationRules
    {
        public static Boolean isNIValid(String NIText)
        {
            if (NIText == null || NIText == "")
                return false;
            int NI = 0;
            if (!Int32.TryParse(NIText, out NI))
                return false;
            if (NI <= 0)
                return false;

            return true;
        }

        public static Boolean isHMSValid(String HMSText)
        {
            if (HMSText == null || HMSText == "")
                return false;
            int HMS = 0;
            if (!Int32.TryParse(HMSText, out HMS))
                return false;
            if (HMS <= 0)
                return false;

            return true;
        }
        
        public static Boolean areTotalVariablesValid(String TotalVarsText)
        {
            if (TotalVarsText == null || TotalVarsText == "")
                return false;
            int TotalVars = 0;
            if (!Int32.TryParse(TotalVarsText, out TotalVars))
                return false;
            if (TotalVars <= 0)
                return false;

            return true;
        }

        public static Boolean isHMCRValid(String HMCRText)
        {
            if (HMCRText == null || HMCRText == "")
                return false;
            float HMCR = 0.0f;
            if (!float.TryParse(HMCRText, NumberStyles.Any, CultureInfo.InvariantCulture, out HMCR))
                return false;
            if (HMCR <= 0)
                return false;
            if (HMCR > 1)
                return false;

            return true;
        }

        public static Boolean isPARValid(String PARText)
        {
            if (PARText == null || PARText == "")
                return false;
            float PAR = 0.0f;
            if (!float.TryParse(PARText, NumberStyles.Any, CultureInfo.InvariantCulture, out PAR))
                return false;
            if (PAR <= 0)
                return false;
            if (PAR > 1)
                return false;

            return true;
        }

        public static Boolean arePARExtremesValid(String minPARText, String maxPARText)
        {
            if (minPARText == null || minPARText == "" || maxPARText == null || maxPARText == "")
                return false;
            float minPAR = 0.0f;
            if (!float.TryParse(minPARText, NumberStyles.Any, CultureInfo.InvariantCulture, out minPAR))
                return false;
            if (minPAR <= 0)
                return false;
            if (minPAR >= 1)
                return false;
            float maxPAR = 0.0f;
            if (!float.TryParse(maxPARText, NumberStyles.Any, CultureInfo.InvariantCulture, out maxPAR))
                return false;
            if (maxPAR <= 0)
                return false;
            if (maxPAR >= 1)
                return false;
            if (minPAR >= maxPAR)
                return false;

            return true;
        }

        public static Boolean isBWValid(String BWText)
        {
            if (BWText == null || BWText == "")
                return false;
            double BW = 0.0;
            if (!double.TryParse(BWText, NumberStyles.Any, CultureInfo.InvariantCulture, out BW))
                return false;

            return true;
        }

        public static Boolean areΒWExtremesValid(String minBWText, String maxBWText)
        {
            if (minBWText == null || minBWText == "" || maxBWText == null || maxBWText == "")
                return false;
            float minBW = 0.0f;
            if (!float.TryParse(minBWText, NumberStyles.Any, CultureInfo.InvariantCulture, out minBW))
                return false;
            if (minBW <= 0)
                return false;
            float maxBW = 0.0f;
            if (!float.TryParse(maxBWText, NumberStyles.Any, CultureInfo.InvariantCulture, out maxBW))
                return false;
            if (maxBW <= 0)
                return false;
            if (minBW >= maxBW)
                return false;

            return true;
        }

        public static Boolean areExtremeValuesValid(String minValueText, String maxValueText)
        {
            if (minValueText == null || maxValueText == null || minValueText == "" || maxValueText == "")
                return false;
            //if (minValueText.Equals("*"))
            //    return true;
            //if (maxValueText.Equals("*"))
            //    return true;
            double minValue = 0.0;
            if (!double.TryParse(minValueText, NumberStyles.Any, CultureInfo.InvariantCulture, out minValue))
                return false;
            double maxValue = 0.0;
            if (!double.TryParse(maxValueText, NumberStyles.Any, CultureInfo.InvariantCulture, out maxValue))
                return false;
            if (minValue >= maxValue)
                return false;

            return true;
        }
    }
}
