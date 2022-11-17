using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rodis4.Data;
using Rodis4.WINSLEE;

namespace Rodis4.Pages.WINSLEE
{
    public class IndexModel : PageModel
    {
        private readonly Rodis4.Data.Rodis4Context _context;

        public IndexModel(Rodis4.Data.Rodis4Context context)
        {
            _context = context;
        }

        public IList<winslee> winslee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.winslee != null)
            {
                winslee = await _context.winslee.ToListAsync();
            }
        }
    }
}
