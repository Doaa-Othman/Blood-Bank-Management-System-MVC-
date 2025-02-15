using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blood_Bank_Management_System.Models
{
    public class Hospital
    {
        [Required(ErrorMessage = "Hospital Name is required.")]
        [RegularExpression(@"^[A-Za-z0-9\s\-.,()']{1,100}$", ErrorMessage = "Hospital Name is invalid")]
        public string HospitalName { get; set; }

        [Key]
        [Required(ErrorMessage = "Hospital ID is required.")]
        public int HospitalId { get; set; }

        [Required(ErrorMessage = "Hospital Email is required.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Hospital Email is invalid")]
        public string HospitalEmail { get; set; }

        [Required(ErrorMessage = "Hospital Location is required.")]
        [RegularExpression(@"^[A-Za-z0-9\s\-.,()']{1,100}$", ErrorMessage = "Hospital Location is invalid")]
        public string HospitalLocation { get; set; }

        [Required(ErrorMessage = "Hospital Phone is required.")]
        [RegularExpression(@"^01[0-2]\d{1,8}$", ErrorMessage = "Hospital Phone is invalid")]
        public string HospitalPhone { get; set; }

        [Required(ErrorMessage = "Received Units is required.")]
        [Range(1, 100, ErrorMessage = "Hospital received units is out of range")]
        public int ReceivedUnits { get; set; }

        [Required(ErrorMessage = "Hospital date of acception is required")]
        public DateTime DateOfAcception { get; set; }

        public Hospital()
        {
            this.HospitalName = string.Empty;
            this.HospitalEmail = string.Empty;
            this.HospitalId = 1;
            this.HospitalLocation = string.Empty;
            this.HospitalPhone = string.Empty;
            this.ReceivedUnits = 1;
            this.DateOfAcception = DateTime.Now;
        }
    }
}