using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class AppointmentModel
    {
        public DateTime AppoinmentStart { get; set; }
        public DateTime AppoinmentEnd { get; set ;  }
        public int DoctorId { get; set; }
        [Key]
        public int PatientId { get; set; }
    }
}
