using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IScheduleRepository
    {
        Schedule? GetScheduleOnSelectedDateSpecificDoctor(DateTime selectedDate, int id);
        Schedule? CreateSchedule(NewSchedule newSchedule);
        Schedule? UpdateSchedule(int id, Schedule schedule);
        bool? DeleteSchedule(int id);
    }
}