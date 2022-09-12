namespace RecruitCatSapkotti.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TargetSalary { get; set; }
        public DateTime OptionalStartDate { get; set; }

        public String? EmailAddress { get; set; }

        public decimal YearsOfExperience { get; set; }

        public decimal? UniversityCgpa { get; set; } 






    }
}
