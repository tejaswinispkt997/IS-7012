namespace RecruitCatSapkotti.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinimumSalary { get; set; }
        public int MaximumSalary { get; set; }

        public Boolean AllowsRemote { get; set; }
        
    }
}
