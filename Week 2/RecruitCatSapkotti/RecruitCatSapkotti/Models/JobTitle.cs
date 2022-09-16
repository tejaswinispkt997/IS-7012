using System.ComponentModel;

namespace RecruitCatSapkotti.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        public int MinimumSalary { get; set; }
        [DisplayName ("Maximum Salary")]
        public int MaximumSalary { get; set; }
        [DisplayName("Allows Remote")]
        public Boolean AllowsRemote { get; set; }
        
    }
}
