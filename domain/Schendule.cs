using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Schedule
    {
        private int id;
        private DateTime dayStart;
        private DateTime dayEnd;

        public int Id { get { return id; } set { id = value; } }
        public DateTime DayStart { get { return dayStart; } set { dayStart = value; } }
        public DateTime DayEnd { get { return dayEnd; } set { dayEnd = value; } }
    }
}