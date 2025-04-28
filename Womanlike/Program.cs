using Womanlike.Data.Concrete.EfCore;
using Womanlike.Data.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BContext>(options =>{
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("sql_connection");
    options.UseSqlite(connectionString);
    

});
//builder.Services.AddDbContext<BlogContext>(options => { options.UseSqlite(builder.Configuration["ConnectionStrings:Sql_connection"]); });
var app = builder.Build();
app.UseStaticFiles();
SeedData.TestVerileriniDoldur(app);

app.MapDefaultControllerRoute();

app.Run();
