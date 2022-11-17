using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rodis4.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public IEnumerable<Create1Model> Categories { get; set; }
        public void OnGet()
        {
        }
    }
}
