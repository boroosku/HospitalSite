using Database.Converters;
using Database.Models;
using domain;
using domain.Repositories;
using drAppointment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationContext _context;

        public ScheduleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Schedule? GetScheduleOnSelectedDateSpecificDoctor(DateTime selectedDate, int id)
        {
            var schedule = _context.Schedules.FirstOrDefault(u => u.DayStart == selectedDate);
            return schedule.ToDomain();
        }
        public Schedule? CreateSchedule(NewSchedule newSchedule)
        {
            ScheduleModel schedule = null;
            schedule.Id = newSchedule.Id;
            schedule.DayStart = newSchedule.DayStart;
            schedule.DayEnd = newSchedule.DayEnd;

            _context.Schedules.Add(schedule);

            return schedule.ToDomain();
        }
        public Schedule? UpdateSchedule(int id, Schedule schedule)
        {
            throw new NotImplementedException();
        }
        public bool? DeleteSchedule(int id)
        {
            throw new NotImplementedException();
        }
    }
}
