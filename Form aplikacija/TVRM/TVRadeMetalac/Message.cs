using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVRadeMetalac
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Message()
        {
            Content = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }
        public Message(string message, DateTime startDate, DateTime endDate)
        {
            this.Content = message;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
