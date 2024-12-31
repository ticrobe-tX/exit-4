using tX.interfaceStore;
using tX.serviceStore;
using tX.repositoryStore;

var builder = WebApplication.CreateBuilder(args);
var maCors = "maCors";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy(maCors, builder =>
    {
        builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    }));

#region tXid API interfaces
builder.Services.AddScoped<tXidServiceInterface, tXidService>();
builder.Services.AddScoped<tXidRepositoryInterface, tXidRepository>();
#endregion tXid API interfaces

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
app.UseCors(maCors);
app.Run();
