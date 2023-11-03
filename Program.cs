using BlazorApp4.Data;
using Microsoft.Extensions.Options;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().Services.AddServerSideBlazor().Services.AddSyncfusionBlazor(options => { options.EnableRtl = false; });
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

//SyncfusionLicenseProvider.RegisterLicense(""); // TODO Add license

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();