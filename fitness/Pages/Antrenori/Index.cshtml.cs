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
    public class IndexModel : PageModel
    {
        private readonly fitness.Data.fitnessContext _context;

        public IndexModel(fitness.Data.fitnessContext context)
        {
            _context = context;
        }

        public IList<Antrenor> Antrenor { get;set; }

        public async Task OnGetAsync()
        {
            Antrenor = await _context.Antrenor.ToListAsync();
        }
    }
}
