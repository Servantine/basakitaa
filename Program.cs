using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using basakitaa.Data;
using Microsoft.AspNetCore.Authentication.Certificate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<basakitaaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("basakitaaContext") ?? throw new InvalidOperationException("Connection string 'basakitaaContext' not found.")));

builder.Services.AddAuthentication(
        CertificateAuthenticationDefaults.AuthenticationScheme)
    .AddCertificate();


var app = builder.Build();

app.UseAuthentication();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
