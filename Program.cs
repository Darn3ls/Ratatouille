﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ratatouille.Components;
using Ratatouille.Data;
using Ratatouille.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RatatouilleContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RatatouilleContext") ?? throw new InvalidOperationException("Connection string 'RatatouilleContext' not found.")));

// Register IDbContextFactory<RatatouilleContext> with a scoped lifetime IMPORTANTE!!!!!!
builder.Services.AddDbContextFactory<RatatouilleContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RatatouilleContext")), ServiceLifetime.Scoped);

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddSingleton<AuthService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

