using UIBlazor.Data;
using Entities.Context;
using DataAccess.Classes;
using DataAccess.Interfaces;
using UIBlazor.Services;

var app = ServiceBuilder.Builder();
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
