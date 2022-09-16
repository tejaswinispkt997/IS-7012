using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace RecruitCatSapkotti.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

        


        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        public int TargetSalary { get; set; }
        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }
        [EmailAddress]
        [DisplayName("Email Address")]
        public String? EmailAddress { get; set; }
        [DisplayName("Years Of Experience")]
        public decimal YearsOfExperience { get; set; }
        [Range(1,5)]
        [DisplayName("University GPA")]
        public decimal? UniversityCgpa { get; set; } 






    }
}
