using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class ScheduleModel
    {
        public int Id { get; set;}
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
    }
}
