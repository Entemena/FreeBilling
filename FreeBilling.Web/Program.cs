var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Allows us to serve index.html as the default web page
app.UseDefaultFiles();

// Allows us to serve files from wwwroot
app.UseStaticFiles();

app.Run();
