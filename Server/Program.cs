// **************************************************
// Step (1)
// **************************************************
//var builder =
//	WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();
// **************************************************

// **************************************************
// Step (2)
// **************************************************
// <ImplicitUsings>disable</ImplicitUsings>
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// MapGet() -> using Microsoft.AspNetCore.Builder;
//app.MapGet("/", () => "Hello World!");

//app.Run();
// **************************************************

// **************************************************
// Step (3)
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************

// **************************************************
// Step (4)
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************

// **************************************************
// Step (5)
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions =
//	new Microsoft.AspNetCore.Builder.WebApplicationOptions
//	{
//		//EnvironmentName =
//		//	Microsoft.Extensions.Hosting.Environments.Development,

//		//EnvironmentName =
//		//	Microsoft.Extensions.Hosting.Environments.Staging,

//		EnvironmentName =
//			Microsoft.Extensions.Hosting.Environments.Production,
//	};

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(options: webApplicationOptions);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

////// IsDevelopment() -> using Microsoft.Extensions.Hosting;
////if (app.Environment.IsDevelopment() == false)
////{
////	// UseExceptionHandler() -> using Microsoft.AspNetCore.Builder;
////	app.UseExceptionHandler("/Errors/Error");

////	// The default HSTS value is 30 days.
////	// You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
////	// UseHsts() -> using Microsoft.AspNetCore.Builder; 
////	app.UseHsts();
////}

//// IsDevelopment() -> using Microsoft.Extensions.Hosting;
//if (app.Environment.IsDevelopment())
//{
//	// UseDeveloperExceptionPage() -> using Microsoft.AspNetCore.Builder;
//	app.UseDeveloperExceptionPage();
//}
//else
//{
//	// UseExceptionHandler() -> using Microsoft.AspNetCore.Builder;
//	app.UseExceptionHandler("/Errors/Error");

//	// The default HSTS value is 30 days.
//	// You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//	// UseHsts() -> using Microsoft.AspNetCore.Builder; 
//	app.UseHsts();
//}

//// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************

// **************************************************
// Step (6)
// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

//var webApplicationOptions =
//	new Microsoft.AspNetCore.Builder.WebApplicationOptions
//	{
//		EnvironmentName =
//			Microsoft.Extensions.Hosting.Environments.Development,

//		//EnvironmentName =
//		//	Microsoft.Extensions.Hosting.Environments.Production,
//	};

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(options: webApplicationOptions);

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder();

// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();

var app =
	builder.Build();

// IsDevelopment() -> using Microsoft.Extensions.Hosting;
if (app.Environment.IsDevelopment())
{
	// UseDeveloperExceptionPage() -> using Microsoft.AspNetCore.Builder;
	app.UseDeveloperExceptionPage();
}
else
{
	// UseExceptionHandler() -> using Microsoft.AspNetCore.Builder;
	app.UseExceptionHandler("/Errors/Error");

	// The default HSTS value is 30 days.
	// You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts
	// UseHsts() -> using Microsoft.AspNetCore.Builder; 
	app.UseHsts();
}

// http://www.DTAT.ir
// http://DTAT.ir
// https://www.DTAT.ir
//		https://DTAT.ir

// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

// UseRouting() -> using Microsoft.AspNetCore.Builder;
app.UseRouting();

// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
app.UseAuthentication();

// UseAuthorization() -> using Microsoft.AspNetCore.Builder;
app.UseAuthorization();

// **********
// ترتیب نوشتن دستورات ذیل کاملا غلط می‌باشد
// لذا باید در نوشتن ترتیب دستورات به شدت دقت نماییم
// **********
//app.UseAuthorization();
//app.UseAuthentication();
// **********

// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

app.Run();
// **************************************************
