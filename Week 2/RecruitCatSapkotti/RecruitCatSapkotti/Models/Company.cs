namespace RecruitCatSapkotti.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Position { get; set; }
        public int MinimumSalary { get; set; }
        public int MaximumSalary { get; set; }
        public DateTime OptionalStartDate { get; set; }
        public String Location { get; set; }

        public String CompanyDescription { get; set; }

    }
}
