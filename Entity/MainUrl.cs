using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdPlugin.Entity
{
    public class MainUrl
    {
        private string server1 = "http://42.51.28.64:8088/";
        private string serverTest = "http://123.60.219.255:8088/";

        public string Server1 { get => server1; set => server1 = value; }
        public string ServerTest { get => serverTest; set => serverTest = value; }

        public string GetValue(string propertyName)
        {
            return Convert.ToString(this.GetType().GetProperty(propertyName).GetValue(this, null));
        }
    }
}
