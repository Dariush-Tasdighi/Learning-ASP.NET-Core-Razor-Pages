namespace Server.Pages.Learn020
{
	public class IndexModel :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public IndexModel() : base()
		{
		}

		public void OnGet()
		{
			throw new System.Exception(message: "Some Error!");
		}
	}
}
