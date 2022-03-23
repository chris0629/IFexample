using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IFProj.Models;
using IFProj.Data;

namespace IFProj.Pages.Sessions
{
    public class DetailsViewerModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsViewerModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Session Sessions { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sessions = await _context.Sessions.FirstOrDefaultAsync(m => m.ID == id);

            if (Sessions == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
