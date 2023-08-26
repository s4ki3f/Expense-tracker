using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Expense_Tracker.Data;
using Expense_Tracker.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<Expense_TrackerContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Expense_TrackerContextConnection")));

builder.Services.AddDefaultIdentity<Expense_TrackerUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Expense_TrackerContext>();

builder.Services.AddRazorPages();


//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBMAY9C3t2V1hiQlRPf0BAWXxLflF1VWpTflt6d1dWESFaRnZdQV1rS3tTf0RlXXlfc3VW\r\n");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
