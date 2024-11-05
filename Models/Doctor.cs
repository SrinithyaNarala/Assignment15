using System.ComponentModel.DataAnnotations;
namespace HospitalManagement.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int HospitalId { get; set; }
        public virtual Hospital? Hospital { get; set; }
        public virtual List<Appointment>? Appointments { get; set; }
    }
}
