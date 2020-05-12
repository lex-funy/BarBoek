﻿using Barboek.ClassLib.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barboek.ClassLib.DAL.Contexts
{
    interface iScheduleRetrieveContext
    {
        List<ScheduleDTO> GetAllSchedules();
        ScheduleDTO FindScheduleById(int id);
    }
}
