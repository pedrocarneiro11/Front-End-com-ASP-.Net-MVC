using _11_Frontend_com_ASP_NET_MVC.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Pega a string da conexao padrao no appsetings.json
var ConexaoPadrao = builder.Configuration.GetConnectionString("ConexaoPadrao");

// Adicionando o servico
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(ConexaoPadrao));

builder.Services.AddControllersWithViews();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
