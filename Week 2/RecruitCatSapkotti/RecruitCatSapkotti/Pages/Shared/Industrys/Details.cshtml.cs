﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSapkotti.Data;
using RecruitCatSapkotti.Models;

namespace RecruitCatSapkotti.Pages.Shared.Industrys
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSapkotti.Data.RecruitCatSapkottiContext _context;

        public DetailsModel(RecruitCatSapkotti.Data.RecruitCatSapkottiContext context)
        {
            _context = context;
        }

      public Industry Industry { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Industry == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);
            if (industry == null)
            {
                return NotFound();
            }
            else 
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
