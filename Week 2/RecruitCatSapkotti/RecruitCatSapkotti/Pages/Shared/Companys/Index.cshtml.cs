using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSapkotti.Data;
using RecruitCatSapkotti.Models;

namespace RecruitCatSapkotti.Pages.Shared.Companys
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSapkotti.Data.RecruitCatSapkottiContext _context;

        public IndexModel(RecruitCatSapkotti.Data.RecruitCatSapkottiContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Company != null)
            {
                Company = await _context.Company.ToListAsync();
            }
        }
    }
}
