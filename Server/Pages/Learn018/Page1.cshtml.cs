using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages.Learn018;

public class Page1Model : PageModel
{
	public Page1Model() : base()
	{
	}

	public void OnGet()
	{
		ViewData["MyData"] = "I'm Dariush Tasdighi";
		//ViewBag.MyData = "I'm Dariush Tasdighi"; // Just In MVC or MVC Core
	}
}
