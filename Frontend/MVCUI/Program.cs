using BusinessLayer.DependencyManagements.CorsResolver;
using BusinessLayer.DependencyManagements.IdentityResolver;
using BusinessLayer.DependencyManagements.MappingResolver;
using BusinessLayer.DependencyManagements.RepositoryResolver;
using BusinessLayer.DependencyResolvers.ContextResolver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ContextResolver();
builder.Services.CorseResolver();
builder.Services.IdentityResolver();
builder.Services.MappingResolver();
builder.Services.RepositoriesResolver();


builder.Services.AddHttpClient();



builder.Services.AddControllersWithViews();

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
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
