var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllerWithViews();//mvc şablonu eklemek
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();cont/action/id kısayolu
app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}"
);

app.Run();
