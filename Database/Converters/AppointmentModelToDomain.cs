using Database.Models;
using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Converters
{
    public static class AppointmentModelToDomainConverter
    {
        public static Appointment? ToDomain(this AppointmentModel model)
        {
            return new Appointment
            {
                AppoinmentStart = model.AppoinmentStart,
                AppoinmentEnd = model.AppoinmentEnd,
                DoctorId = model.DoctorId,
                PatientId= model.PatientId
            };
        }
    }
}
