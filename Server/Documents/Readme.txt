**************************************************
)
Update:
Server.csproj
**************************************************

**************************************************
)
Update:
.\Program.cs
**************************************************

**************************************************
)
Add -> New Folder:
.\Pages
**************************************************

**************************************************
)
Add -> Razor Page... -> Razor Page - Empty:
Index.cshtml
	Index.cshtml.cs
**************************************************

**************************************************
)
Add -> New Folder:
.\wwwroot
**************************************************

**************************************************
)
Add -> New Folder:
.\wwwroot\css
**************************************************

**************************************************
)
Add -> New Item... -> Installed -> Visual C# -> ASP.NET Core -> Web -> Content -> Style Sheet
.\wwwroot\css\site.css
**************************************************

**************************************************
)
Add -> New Folder:
.\wwwroot\js
**************************************************

**************************************************
)
Add -> New Folder:
.\wwwroot\images
**************************************************

**************************************************
)
Add -> New Folder:
.\wwwroot\lib
**************************************************

**************************************************
)
Copy and Pasted -> Icon Files:
.\wwwroot\

https://favicon.io/
https://www.favicon.cc/
https://realfavicongenerator.net/ (OK)
https://www.favicongenerator.com/
**************************************************

**************************************************
)
Right Click on Project (Server) -> Select [Manage Client-Side Libraries…]
.\libman.json
**************************************************

**************************************************
)
Update:
.\libman.json

From:

{
	"version": "1.0",
	"defaultProvider": "cdnjs",
	"libraries": []
}

To:

{
	"version": "1.0",
	"defaultProvider": "cdnjs",
	"libraries": [
		{
			"library": "jquery@3.6.0",
			"destination": "wwwroot/lib/jquery/"
		},
		{
			"library": "bootstrap@5.1.3",
			"destination": "wwwroot/lib/bootstrap/"
		},
		{
			"library": "bootstrap-icons@1.8.1",
			"destination": "wwwroot/lib/bootstrap-icons/"
		},
		{
			"library": "jquery-validate@1.19.3",
			"destination": "wwwroot/lib/jquery-validate/"
		},
		{
			"library": "jquery-validation-unobtrusive@3.2.12",
			"destination": "wwwroot/lib/jquery-validation-unobtrusive/"
		}
	]
}

And Then Rebuild Solution:
**************************************************

**************************************************
)
Add -> New Folder:
.\Pages\Shared
**************************************************

**************************************************
)
Add -> New Item... -> Installed -> Visual C# -> ASP.NET Core -> Web -> ASP.NET -> Razor Layout
.\Pages\Shared\_Layout.cshtml
**************************************************

**************************************************
)
Add -> New Item... -> Installed -> Visual C# -> ASP.NET Core -> Web -> ASP.NET -> Razor View
.\Pages\_ViewStart.cshtml

Update:

@{
	Layout = "_Layout";
}
**************************************************

**************************************************
)
Add -> New Item... -> Installed -> Visual C# -> ASP.NET Core -> Web -> ASP.NET -> Razor View
.\Pages\_ViewImports.cshtml

Update:

@{
	Layout = "_Layout";
}
**************************************************

**************************************************
)
Add -> Razor Page... -> Razor Page - Empty:
Help.cshtml
**************************************************

**************************************************
)
Add -> Razor Page... -> Razor Page - Empty:
Error.cshtml
	Error.cshtml.cs
**************************************************

**************************************************
)
Add -> Razor Page... -> Razor Page - Empty:
StatusCode.cshtml
	StatusCode.cshtml.cs
**************************************************

**************************************************
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-6.0
https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/fundamentals/error-handling/samples/6.x/ErrorHandlingSample
**************************************************
