using System.ComponentModel.DataAnnotations;
namespace HospitalManagement.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Doctor>? Doctors { get; set; }
    }
}
