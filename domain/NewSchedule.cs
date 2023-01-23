using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class NewSchedule
    {
        public int Id;
        public DateTime DayStart;
        public DateTime DayEnd;

        public NewSchedule(int id, DateTime dayStart, DateTime dayEnd)
        {
            Id = id;
            DayStart = dayStart;
            DayEnd = dayEnd;
        }
    }
}