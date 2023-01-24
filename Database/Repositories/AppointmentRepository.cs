using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Converters;
using domain;
using domain.Repositories;
using drAppointment.DAL;

namespace Database.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ApplicationContext _context;

        public AppointmentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public bool IsAppointmentExist(DateTime selectedDate)
        {
            throw new NotImplementedException();
        }

        public DateTime[]? GetFreeAppointmentDateByDrSpec(DrSpec spec)
        {
            throw new NotImplementedException();
        }

        public Appointment? MakeAppointmentOnSelectedDateSpecificDoctor(int id, DateTime selectedDate)
        {
            throw new NotImplementedException();
        }

        public Appointment MakeAppointmentOnSelectedDateFreeDoctor(DateTime selectedDate, DrSpec spec)
        {
            throw new NotImplementedException();
        }

    }
}
