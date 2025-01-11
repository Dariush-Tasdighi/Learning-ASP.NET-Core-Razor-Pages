using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages.Learn018;

public class Page2Model : PageModel
{
	public Page2Model() : base()
	{
	}

	public void OnGet()
	{
		ViewData["MyData"] = "I'm Dariush Tasdighi";
		//ViewBag.MyData = "I'm Dariush Tasdighi"; // Just In MVC or MVC Core
	}
}
