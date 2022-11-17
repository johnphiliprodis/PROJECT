using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rodis4.Data;
using Rodis4.WINSLEE;

namespace Rodis4.Pages.WINSLEE
{
    public class CreateModel : PageModel
    {
        private readonly Rodis4.Data.Rodis4Context _context;

        public CreateModel(Rodis4.Data.Rodis4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public winslee winslee { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.winslee.Add(winslee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
