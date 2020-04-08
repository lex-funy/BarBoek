using System;
using System.Collections.Generic;
using System.Text;

namespace BarBoekForms
{
    class Schedule
    {
        public List<Shift> Shifts { get; set; }

        public Schedule()
        {
            this.Shifts = new List<Shift>();
        }

        public Schedule(Shift shift)
        {
            this.Shifts = new List<Shift>();
            this.Shifts.Add(shift);
        }

        public Schedule(List<Shift> shifts)
        {
            this.Shifts = new List<Shift>();
            this.Shifts.AddRange(shifts);
        }

        public void AddShift(Shift shift)
        {
            this.Shifts.Add(shift);
        }

        public void AddShifts(List<Shift> shifts)
        {
            this.Shifts.AddRange(shifts);
        }

        public void PlanShifts(List<User> users)
        {
            int count = 0;
            foreach (Shift shift in this.Shifts)
            {
                foreach (User user in users)
                {
                    if (user.AddShift(shift))
                    {
                        // TODO: Add user to shift inside of schedule
                        this.Shifts[count].User = user;

                        break;
                    }
                }

                count++;
            }
        }
    }
}
