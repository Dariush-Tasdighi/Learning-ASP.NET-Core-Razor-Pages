using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages
{
    public class IndexModel : PageModel
    {
		public string FullName { get; set; }

		public void OnGet()
        {
            FullName = "Dariush Tasdighi";
        }
    }
}
