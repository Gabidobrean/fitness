using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using fitness.Data;
using fitness.Models;

namespace fitness.Pages.Antrenori
{
    public class DetailsModel : PageModel
    {
        private readonly fitness.Data.fitnessContext _context;

        public DetailsModel(fitness.Data.fitnessContext context)
        {
            _context = context;
        }

        public Antrenor Antrenor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Antrenor = await _context.Antrenor.FirstOrDefaultAsync(m => m.ID == id);

            if (Antrenor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
