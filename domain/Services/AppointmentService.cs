using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Repositories;

namespace domain.Services
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentService(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public Result<DateTime[]> GetFreeAppointmentDateByDrSpec(DrSpec spec)
        {
            var appointment = _repository.GetFreeAppointmentDateByDrSpec(spec);

            return appointment is null ? Result.Fail<DateTime[]>("Appointment list is empty") : Result.Ok(appointment);
        }

        public Result<Appointment> MakeAppointmentOnSelectedDateSpecificDoctor(int id, DateTime selectedDate)
        {
            var appoinment = _repository.MakeAppointmentOnSelectedDateSpecificDoctor(id, selectedDate);

            if (_repository.IsAppointmentExist(selectedDate))
            {
                return Result.Fail<Appointment>("Appointment already exists");
            }

            return appoinment is null ? Result.Fail<Appointment>("Appointment not set") : Result.Ok(appoinment);
        }

        public Result<Appointment> MakeAppointmentOnSelectedDateFreeDoctor(DateTime selectedDate, DrSpec spec)
        {
            var appoinment = _repository.MakeAppointmentOnSelectedDateFreeDoctor(selectedDate, spec);

            if (_repository.IsAppointmentExist(selectedDate))
            {
                return Result.Fail<Appointment>("Appointment already exists");
            }

            return appoinment is null ? Result.Fail<Appointment>("Appointment not set") : Result.Ok(appoinment);
        }
    }
}
