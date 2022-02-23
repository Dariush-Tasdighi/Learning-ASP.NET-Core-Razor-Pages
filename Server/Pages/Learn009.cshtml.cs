namespace Server.Pages
{
	public class Learn009Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn009Model() : base()
		{
			//SomePublicField = "Initial Value";
		}

		//public string SomePublicField;

		// https://code-maze.com/csharp-access-modifiers

		// **********
		/// <summary>
		/// OK
		/// </summary>
		public string? PublicField;

		private string? _privateField;

		protected string? ProtectedField;

		/// <summary>
		/// OK
		/// </summary>
		internal string? InternalField;

		/// <summary>
		/// OK
		/// </summary>
		protected internal string? ProtectedInternalField;

		private protected string? PrivateProtectedField;
		// **********

		// **********
		/// <summary>
		/// OK
		/// </summary>
		public string? PublicProperty { get; set; }

		private string? PrivateProperty { get; set; }

		protected string? ProtectedProperty { get; set; }

		/// <summary>
		/// OK
		/// </summary>
		internal string? InternalProperty { get; set; }

		/// <summary>
		/// OK
		/// </summary>
		protected internal string? ProtectedInternalProperty { get; set; }

		private protected string? PrivateProtectedProperty { get; set; }
		// **********

		public void OnGet()
		{
			// **************************************************
			PublicField = "Public Field";
			_privateField = "Private Field";
			ProtectedField = "Protected Field";
			InternalField = "Internal Field";
			ProtectedInternalField = "Protected Internal Field";
			PrivateProtectedField = "Private Protected Field";
			// **************************************************

			// **************************************************
			PublicProperty = "Public Property";
			PrivateProperty = "Private Property";
			ProtectedProperty = "Protected Property";
			InternalProperty = "Internal Property";
			ProtectedInternalProperty = "Protected Internal Property";
			PrivateProtectedProperty = "Private Protected Property";
			// **************************************************
		}
	}
}
