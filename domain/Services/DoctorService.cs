using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Repositories;

namespace domain.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository _repository;

        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public Result<Doctor> GetDoctorById(int id)
        {
            var doctor = _repository.GetById(id);

            return doctor is null ? Result.Fail<Doctor>("Doctor not found") : Result.Ok(doctor);
        }

        public Result<Doctor> GetDoctorBySpec(DrSpec spec)
        {
            var doctor = _repository.GetBySpec(spec);

            return doctor is null ? Result.Fail<Doctor>("Doctor not found") : Result.Ok(doctor);
        }

        public Result<Doctor[]> GetAllDoctors()
        {
            var doctors = _repository.GetAllDoctors();


            return doctors.Length == 0 ? Result.Fail<Doctor[]>("Failed when triying to get all doctors") : Result.Ok(doctors);
        }

        public Result<Doctor> CreateDoctor(NewDoctor newDoctor)
        {
            var doctor = _repository.CreateDoctor(newDoctor);

            return doctor is null ? Result.Fail<Doctor>("Doctor not created") : Result.Ok(doctor);
        }

        public Result DeleteDoctor(int id)
        {
            var doctor = _repository.DeleteDoctor(id);

            return doctor is null ? Result.Fail("Deletion Error") : Result.Ok("Doctor Deleted");
        }
    }
}