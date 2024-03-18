using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Subscriber.BL;
using Subscriber.CORE.Interface.BL;
using Subscriber.CORE.Interface.DAL;
using Subscriber.DAL;
using Subscriber.Data;
using WeightWatchers.config;
using static WeightWatchers.config.MiddlelWare;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var mappingConfig = new MapperConfiguration(a =>
{
    a.AddProfile(new WeightWatchersProfile());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
//מכיל את הקובץ APPSETIINGS
ConfigurationManager configuration = builder.Configuration;
///מוסי את האפשרות להשתמש במסד נתונים 
builder.Services.AddDbContext<WeightWatchersContext>(option =>
{
    ///הגדרתי לאיזה DB להתחבר 
    option.UseSqlServer(configuration.GetConnectionString("WeightWatchersYehudit"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICardService, CardService>();
builder.Services.AddScoped<ISubscriberService, Subscriber_Service>();
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<ISubscriberRepository, SubscriberRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
//מגדיר את הפעלה המידלוור
app.UseMiddleware(typeof(ErrorHandlingMiddleware));
app.Run();
