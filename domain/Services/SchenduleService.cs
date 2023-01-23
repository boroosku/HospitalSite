using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Repositories;

namespace domain.Services
{
    public class ScheduleService
    {
        private readonly IScheduleRepository _repository;

        public ScheduleService(IScheduleRepository repository)
        {
            _repository = repository;
        }

        public Result<Schedule> GetScheduleOnSelectedDateSpecificDoctor(DateTime selectedDate, int id)
        {
            var schedule = _repository.GetScheduleOnSelectedDateSpecificDoctor(selectedDate, id);

            return schedule is null ? Result.Fail<Schedule>("Schedule not found") : Result.Ok(schedule);
        }

        public Result<Schedule> CreateSchedule(NewSchedule newSchedule)
        {
            var schedule = _repository.CreateSchedule(newSchedule);

            return schedule is null ? Result.Fail<Schedule>("Schedule not created") : Result.Ok(schedule);
        }

        public Result<Schedule> UpdateSchedule(int id, Schedule updateSchedule)
        {
            var schedule = _repository.UpdateSchedule(id, updateSchedule);

            return schedule is null ? Result.Fail<Schedule>("Schedule not updated") : Result.Ok(schedule);
        }

        public Result DeleteSchedule(int id)
        {
            var schedule = _repository.DeleteSchedule(id);

            return schedule is null ? Result.Fail("Deletion Error") : Result.Ok("Schedule Deleted");
        }
    }
}