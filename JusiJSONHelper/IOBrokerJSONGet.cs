using System;
using System.Collections.Generic;
using System.Text;

namespace JusiJSONHelper
{
    public class IOBrokerJSONGet
    {
        public string val { get; set; }
        public string ack { get; set; }
        public string from { get; set; }
        public string type { get; set; }
        public long ts { get; set; }
        public long lc { get; set; }



        public DateTime LastChange
        {
            get { return IOBrokerConverter.JavaTimeStampToDateTime(lc); }
        }
        public DateTime TimeStamp
        {
            get { return IOBrokerConverter.JavaTimeStampToDateTime(ts); }
        }

        public string valString
        {
            get { return val; }
        }

        public int valInt
        {
            get { return Convert.ToInt32(val); }
        }

        public double valDouble
        {
            get { return Convert.ToDouble(val); }
        }

        public bool ?valBool
        {
            get {
                if (val == "true")
                {
                    return true;
                }
                else if (val == "false")
                {
                    return false;
                }
                else
                { 
                    return null; 
                }

            }
        }
    }
}
