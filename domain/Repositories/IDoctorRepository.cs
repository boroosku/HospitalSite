using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IDoctorRepository
    {
        Doctor? GetById(int id);
        Doctor? GetBySpec(DrSpec spec);
        Doctor[]? GetAllDoctors();
        Doctor? CreateDoctor(NewDoctor newDoctor);
        bool? DeleteDoctor(int id);
    }
}