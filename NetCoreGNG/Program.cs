using Microsoft.EntityFrameworkCore;
using NetCoreGNG.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//SONRADAN EKLEDÝK
//builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddSession();
builder.Services.AddDbContext<DatabaseContext>(options=>options.UseSqlServer());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
   // DataSeeding.Seed(app);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllerRoute(
         name: "Admin",
         pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
       );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
