using Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistance.Context;
using Presentation;
using WebAPI.Configurations;
using WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .InstallServices(
    builder.Configuration, typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scoped = app.Services.CreateScope())
{
    var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if (!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "gokce",
            Email = "gokcekadr@gmail.com",
            Id = Guid.NewGuid().ToString(),
            NameLastName = "Kadir Gökçe",
        }, "Password12*").Wait();
    }
}

app.Run();