using MongoDB.Driver;
using Promolt.Core;
using Promolt.Core.DB_Accessors;
using Promolt.Core.Interfaces;
using Promolt.Core.Services;
using Promolt.Core.Settings;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddSingleton<IMongoClient>(serviseProvider =>
{
    var settings = builder.Configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();
    return new MongoClient(settings.ConnectionString);
});
builder.Services.AddSingleton<IDBUsersAccessor, MongoDBUsersAccessor>();
builder.Services.AddSingleton<IDBCampaignsAccessor, MongoDBCampaignsAccessor>();
builder.Services.AddSingleton<IDBDonationAccessor, MongoDBDonationAccessor>();
builder.Services.AddTransient<IUserServices, UserServices>();
builder.Services.AddTransient<ICampaignServices, CampaignServices>();
builder.Services.AddTransient<IDonationServices, DonationServices>();
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
