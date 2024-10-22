using System.IdentityModel.Tokens.Jwt;
using Blazored.LocalStorage;
using ContactBook.BlazorServer.AuthProvider;
using ContactBook.BlazorServer.Data;
using ContactBook.BlazorServer.Implementation;
using ContactBook.BlazorServer.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<IContactRepository, ContactRepository>();
builder.Services.AddTransient<IAuthRepository, AuthRepository>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<IUpload, Upload>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthenticationProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p =>
    p.GetRequiredService<AuthenticationProvider>());
builder.Services.AddScoped<JwtSecurityTokenHandler>();

var app = builder.Build();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
