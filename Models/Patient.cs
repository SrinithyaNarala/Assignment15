using System.ComponentModel.DataAnnotations;
namespace HospitalManagement.Models
{ 
    public class Patient
    {
        public int PatientId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age {  get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public virtual List<Appointment>? Appointments { get; set; }
    }
}
