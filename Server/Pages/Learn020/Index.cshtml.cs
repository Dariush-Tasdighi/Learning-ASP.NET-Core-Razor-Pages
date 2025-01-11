using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages.Learn020;

public class IndexModel : PageModel
{
	public IndexModel() : base()
	{
	}

	public void OnGet()
	{
		throw new System.Exception(message: "Some Error!");
	}
}
