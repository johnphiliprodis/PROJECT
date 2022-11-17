using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rodis4.Data;
using Rodis4.WINSLEE;

namespace Rodis4.Pages.WINSLEE
{
    public class EditModel : PageModel
    {
        private readonly Rodis4.Data.Rodis4Context _context;

        public EditModel(Rodis4.Data.Rodis4Context context)
        {
            _context = context;
        }

        [BindProperty]
        public winslee winslee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.winslee == null)
            {
                return NotFound();
            }

            var winslee =  await _context.winslee.FirstOrDefaultAsync(m => m.ID == id);
            if (winslee == null)
            {
                return NotFound();
            }
            winslee = winslee;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(winslee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!winsleeExists(winslee.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool winsleeExists(int id)
        {
          return _context.winslee.Any(e => e.ID == id);
        }
    }
}
