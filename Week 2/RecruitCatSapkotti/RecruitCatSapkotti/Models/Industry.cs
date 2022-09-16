using System.ComponentModel;

namespace RecruitCatSapkotti.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Candidate>? Candidates { get; set; }
        public List<Company>? Companies { get; set; }
        [DisplayName("Industry Description")]
        public String IndustryDescription { get; set; }
    }
}
