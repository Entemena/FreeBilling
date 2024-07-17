var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
};

// Allows us to serve index.html as the default web page
app.UseDefaultFiles();

// Allows us to serve files from wwwroot
app.UseStaticFiles();

app.MapRazorPages();

app.Run();

