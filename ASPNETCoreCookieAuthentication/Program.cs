var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthentication()
    .AddCookie("default", o =>
    {
        o.Cookie.Name = "mycookie";
    });

builder.Services.AddControllers();

var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();

app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();

app.Run();
