using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienstToevoegen
{
    public class Shift
    {
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserAmount { get; set; }
        public bool EventBool { get; set; }
        public string Event { get; set; }
    }
}
