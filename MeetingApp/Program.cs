var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//mvc şablonu eklemek
var app = builder.Build();
app.UseStaticFiles();//wwwwroot altındaki static dosyaları kullanmak için gerekli
app.UseRouting();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();cont/action/id kısayolu
app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}"
);

app.Run();
