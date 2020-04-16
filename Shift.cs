using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek
{
    public class Shift //ADD INSTRUCTION TO FORM THAT IN CASE THE USER WANTS A PERIODICAL SHIFT TO OCCUR, SELECT THE MONDAY OF THAT WEEK
    {
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserAmount { get; set; }
        public bool EventBool { get; set; }
        public string Event { get; set; }
    }
}
