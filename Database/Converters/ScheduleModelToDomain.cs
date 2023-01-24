using Database.Models;
using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Converters
{
    public static class ScheduleModelToDomainConverter
    {
        public static Schedule? ToDomain(this ScheduleModel model)
        {
            return new Schedule
            {
                Id = model.Id,
                DayStart = model.DayStart,
                DayEnd = model.DayEnd
            };
        }
    }
}
