using DonViHanhChinh6102023.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using DonViHanhChinh6102023.Repositories.impl;
using DonViHanhChinh6102023.Services.hepler;
using DonViHanhChinh6102023.Services.IInterfaceService;
using DonViHanhChinh6102023.Services.impl;
using Microsoft.EntityFrameworkCore;
using PagedList;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DBHanhChinhContext>(
  o => o.UseNpgsql(builder.Configuration.GetConnectionString("myconn"))
  );

// mapper
builder.Services.AddScoped(typeof(ICommonRepository<>), typeof(CommonRepository<>));
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IProvinceService, ProvinceServiceImpl>();
builder.Services.AddScoped<IDistrictService, DistrictServiceimpl>();
builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();
builder.Services.AddScoped<IWardRepository, WardRepository>();
builder.Services.AddScoped<IWardService, WardServiceImpl>();


builder.Services.AddAutoMapper(typeof(ApplicationMapper));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
