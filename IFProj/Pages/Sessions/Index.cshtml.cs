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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Session> Sessions { get;set; }

        public async Task OnGetAsync()
        {
            Sessions = await _context.Sessions.ToListAsync();
        }
    }
}
