using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek.ClassLib.DAL.Model
{
    struct ScheduleDTO
    {
        public string Name { get; set; }
        public List<ShiftDTO> Shifts { get; set; }
    }
}
