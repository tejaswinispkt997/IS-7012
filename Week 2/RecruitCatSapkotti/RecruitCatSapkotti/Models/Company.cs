using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSapkotti.Models
{
    public class Company
    {
        public int Id { get; set; }
        [DisplayName("Company")]
        public List<Candidate>? Candidates { get; set; }
        public Industry? Industry { get; set; }
        [DisplayName("Industry")]
        public int? IndustryId { get; set; }
        [DisplayName("Position Name")]
        public string Name { get; set; }
        [DisplayName("Min Salary")]
        public int MinimumSalary { get; set; }
        [DisplayName("Max Salary")]
        public int MaximumSalary { get; set; }
        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }
        public String Location { get; set; }
        [StringLength(250)]
        [DisplayName("Company Description")]
        public String CompanyDescription { get; set; }

    }
}
