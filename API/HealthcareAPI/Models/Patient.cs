//The Patient model stores information about patients.

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public string MedicalHistory { get; set; }
}



//using System.ComponentModel.DataAnnotations;

//namespace HealthcareAPI.Models
//{
//    public class Patient
//    {
//        [Key]
//        public int PatientId { get; set; }

//        [Required]
//        public string FirstName { get; set; }

//        [Required]
//        public string LastName { get; set; }

//        public DateTime DateOfBirth { get; set; }

//        public string Gender { get; set; }

//        public string Diagnosis { get; set; }

//        public List<Recommendation> Recommendations { get; set; } = new();
//    }
//}
