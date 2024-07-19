var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

// 1ST METHOD 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
    );

// 2ND METHOD
 
/*app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");*/

app.Run();
