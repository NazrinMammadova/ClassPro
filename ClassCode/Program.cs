using ClassCode;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


var app = builder.Build();
var config = builder.Configuration;
builder.Services.Register(config);



app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();

app.UseStaticFiles();
app.Run();
