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
    public class DetailsModel : PageModel
    {
        private readonly Rodis4.Data.Rodis4Context _context;

        public DetailsModel(Rodis4.Data.Rodis4Context context)
        {
            _context = context;
        }

      public winslee winslee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.winslee == null)
            {
                return NotFound();
            }

            var winslee = await _context.winslee.FirstOrDefaultAsync(m => m.ID == id);
            if (winslee == null)
            {
                return NotFound();
            }
            else 
            {
                winslee = winslee;
            }
            return Page();
        }
    }
}
