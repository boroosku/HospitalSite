using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Converters;
using Database.Models;
using domain;
using domain.Repositories;
using drAppointment.DAL;

namespace Database.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationContext _context;

        public DoctorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Doctor? GetById(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Id == id);
            return doctor?.ToDomain();
        }
        public Doctor? GetBySpec(DrSpec spec)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Id == spec.Id);
            return doctor?.ToDomain();
        }
        public Doctor[] GetAllDoctors()
        {
            var doctors = _context.Doctors.ToList();
            throw new NotImplementedException();
        }
        public Doctor? CreateDoctor(NewDoctor newDoctor)
        {
            DoctorModel doctor = null;
            doctor.Id = newDoctor.Id;
            doctor.Spec = newDoctor.Spec.Id;
            doctor.Name = newDoctor.Name;

            _context.Doctors.Add(doctor);
            return doctor.ToDomain();

        }
        public bool? DeleteDoctor(int id)
        {
            DoctorModel doctor = _context.Doctors.FirstOrDefault(d => d.Id == id);
            _context.Doctors.Remove(doctor);
            var result = _context.Doctors.FirstOrDefault(d => d.Id == id);
            return result == null;
        }
    }
}
