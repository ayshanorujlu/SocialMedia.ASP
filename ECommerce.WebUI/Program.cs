using ASPProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connection = builder.Configuration.GetConnectionString("myconn");
builder.Services.AddDbContext<CustomIdentityDBContext>(options =>
{
    options.UseSqlServer(connection, b => b.MigrationsAssembly("SocialProject.WebUI"));
});

builder.Services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
    .AddEntityFrameworkStores<CustomIdentityDBContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IPasswordHasher<CustomIdentityUser>, PasswordHasher<CustomIdentityUser>>();
//builder.Services.AddAntiforgery(options =>
//{
//    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
//});
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}");

app.Run();