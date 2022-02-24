using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args);

// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();

var app = builder.Build();

// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
