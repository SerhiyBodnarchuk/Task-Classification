using TaskClassification.Api.Infrastructure.Extensions;
using TaskClassification.Business;
using TaskClassification.Data;
using TaskClassification.Shared;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddData(configuration);
builder.Services.AddAuthentication(configuration);
builder.Services.AddShared(configuration);
builder.Services.AddBusiness(configuration);

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
