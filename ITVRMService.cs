using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TVRMHost
{
    [ServiceContract]
    interface ITVRMService
    {
        [OperationContract]
        bool ShortClasses(bool check);
        [OperationContract]
        string DisplayMessage(string message, DateTime startDate, DateTime endDate);
    }
}
