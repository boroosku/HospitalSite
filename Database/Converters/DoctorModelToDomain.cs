using Database.Models;
using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Converters
{
    public static class DoctorModelToDomainConverter
    {
        public static Doctor? ToDomain(this DoctorModel model)
        {
            DrSpec temp = null;
            temp.Id = model.Spec;
            return new Doctor
            {
                Id = model.Id,
                Name = model.Name,
                Spec = temp
            };
        }
    }
}
