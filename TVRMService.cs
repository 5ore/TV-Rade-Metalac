using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVRMHost
{
    class TVRMService : ITVRMService
    {
        public string DisplayMessage(string message, DateTime startDate, DateTime endDate)
        {
            return (startDate == null) ? message + ";" + DateTime.Now.ToString() + ";" + endDate.ToString() :
                message + ";" + startDate.ToString() + ";" + endDate.ToString();
        }

        public bool ShortClasses(bool check)
        {
            return check;
        }
    }
}
