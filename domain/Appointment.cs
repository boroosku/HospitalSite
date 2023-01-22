using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Appointment
    {
        private DateTime appoinmentStart;
        private DateTime appoinmentEnd;
        private int doctorId;
        private int patientId;
        public DateTime AppoinmentStart { get { return appoinmentStart; } set { appoinmentStart = value; } }
        public DateTime AppoinmentEnd { get { return appoinmentEnd; } set { appoinmentEnd = value; } }
        public int DoctorId { get { return doctorId; } set { doctorId = value; } }
        public int PatientId { get { return patientId; } set { patientId = value; } }
    }
}