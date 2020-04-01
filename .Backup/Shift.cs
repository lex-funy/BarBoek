using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DienstToevoegen
{
    class Shift
    {
        public string Event { get; set; }
        
        public int UserAmount { get; set; }
        
        public bool EventBool { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public User User { get; set; }

        public Shift() { }

        public Shift(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }

        public Shift(DateTime start, DateTime end, User user)
        {
            this.Start = start;
            this.End = end;
            this.User = user;
        }

        public override string ToString()
        {
            return $"{this.Start} - {this.End}: {this.User}";
        }
    }
}
