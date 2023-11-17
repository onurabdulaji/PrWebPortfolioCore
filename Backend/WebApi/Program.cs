using BusinessLayer.DependencyManagements.CorsResolver;
using BusinessLayer.DependencyManagements.IdentityResolver;
using BusinessLayer.DependencyManagements.MappingResolver;
using BusinessLayer.DependencyManagements.RepositoryResolver;
using BusinessLayer.DependencyResolvers.ContextResolver;
using EntityLayer.Models;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.ContextResolver();
builder.Services.CorseResolver();
builder.Services.IdentityResolver();
builder.Services.MappingResolver();
builder.Services.RepositoriesResolver();
builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.


builder.Services.AddHttpClient();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("PortfolioApi", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PortfolioApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PortfolioApi v1"));
}
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseCors("PortfolioApi");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
