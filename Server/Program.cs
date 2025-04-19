using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

// **************************************************
// Step (1)
// **************************************************
//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.MapGet(pattern: "/", handler: () => "Hello World!");

//app.Run();
// **************************************************

// **************************************************
// Step (2)
// Check: http://localhost:8080/lib/bootstrap/css/bootstrap.rtl.css
// **************************************************
//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************

// **************************************************
// Step (3)
// **************************************************
//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.UseStaticFiles();

//app.MapRazorPages();

//app.Run();
// **************************************************

// **************************************************
// Step (4)
// Check: http://localhost:8080/Learn020
// **************************************************
//var webApplicationOptions = new WebApplicationOptions
//{
//	EnvironmentName = Environments.Development,
//	//EnvironmentName = Environments.Staging,
//	//EnvironmentName = Environments.Production,
//};

//var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

//builder.Services.AddRazorPages();

//var app = builder.Build();

////if (app.Environment.IsProduction())
////{
////	app.UseExceptionHandler(errorHandlingPath: "/Errors/Error");

////	// The default HSTS value is 30 days.
////	// You may want to change this for production scenarios,
////	// see https://aka.ms/aspnetcore-hsts.
////	app.UseHsts();
////}

//if (app.Environment.IsDevelopment())
//{
//	// در نسخه‌های جدید، اگر دستور ذیل را ننویسیم هم
//	// فرض بر این است که این دستور را نوشته‌ایم
//	app.UseDeveloperExceptionPage();
//}
//else
//{
//	app.UseExceptionHandler(errorHandlingPath: "/Errors/Error");

//	app.UseHsts();
//}

//app.UseStaticFiles();

//app.MapRazorPages();

//app.Run();
// **************************************************

// **************************************************
// Step (5) - Final
// **************************************************
var webApplicationOptions = new WebApplicationOptions
{
	EnvironmentName = Environments.Development,
	//EnvironmentName = Environments.Production,
};

var builder = WebApplication.CreateBuilder(options: webApplicationOptions);

builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseExceptionHandler(errorHandlingPath: "/Errors/Error");

	app.UseHsts();
}

// http://www.DTAT.ir
// http://DTAT.ir
// https://www.DTAT.ir
//		https://DTAT.ir

//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// **********
// ترتیب نوشتن دستورات ذیل کاملا غلط می‌باشد
// لذا باید در نوشتن ترتیب دستورات به شدت دقت نماییم
// **********
//app.UseAuthorization();
//app.UseAuthentication();
// **********

app.MapRazorPages();

app.Run();
// **************************************************
