var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

// setup cors policy so that the client site will be allowed to make requests to the api - must be entered before the build process below
builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    // can pass multiple domains as arguments or can pass "*" to allow any domain
    build.WithOrigins("https://localhost:44465").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//use the created above cors policy
app.UseCors("corspolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
