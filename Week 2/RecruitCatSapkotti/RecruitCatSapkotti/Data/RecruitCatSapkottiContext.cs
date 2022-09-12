using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSapkotti.Models;

namespace RecruitCatSapkotti.Data
{
    public class RecruitCatSapkottiContext : DbContext
    {
        public RecruitCatSapkottiContext (DbContextOptions<RecruitCatSapkottiContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSapkotti.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatSapkotti.Models.Company>? Company { get; set; }

        public DbSet<RecruitCatSapkotti.Models.Industry>? Industry { get; set; }

        public DbSet<RecruitCatSapkotti.Models.JobTitle>? JobTitle { get; set; }
    }
}
