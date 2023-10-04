using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace STUDENTREGISTRATIONFORM.Models.Domain
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public string Branch { get; set; }
        [Required]
        [Column("Student First Name ")]
        public string StudentFirstName { get; set; }
        [Required]
        [Column("Student Last Name ")]
        public string StudentLastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Column("Admission Year")]
        public string AdmissionYear { get; set; }
        [Required]
        [Column("Admission Category")]
        public string AdmissionCategory { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        [Column("Student Date of Birth ")]
        public DateTime StudentDateofBirth { get; set; }
        [Required]
        [Column("Second Language")]
        public string SecondLanguage { get; set; }
        [Required]
        [Column("Third Language")]
        public string ThirdLanguage { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(20)]
        public string MobileNumber { get; set; }
        [Required]
        public string EmailID { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        [Column("Would you like Campus Tour")]
        public string WouldyoulikeCampusTour { get; set; }
        [Required]
        [Column("How did you hear about us")]
        public string Howdidyouhearaboutus { get; set; }
        [Required]
        [Column("Additional Information")]
        [MaxLength(75)]
        public string AdditionalInformation { get; set; }
    }
}
