using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CustomI.Sample.CustomUserManagement.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("UserManagementContextConnection") ?? throw new InvalidOperationException("Connection string 'UserManagementContextConnection' not found.");;

builder.Services.AddDbContext<UserManagementContext>(options => options.UseSqlServer(connectionString));
//Scaffoldad identity
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<UserManagementContext>();



// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
