using System.ComponentModel.DataAnnotations;
namespace HospitalManagement.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor? Doctor { get; set; }
        public int PatientId { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
