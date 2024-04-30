using WebAPI.Models;

Console.WriteLine("Application prete � d�marrer");

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<ApiUrls>(
    builder.Configuration.GetSection("App:ApiUrls"));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options=>
    {
        options.EnableTryItOutByDefault();
    });
}

//app.UseHttpsRedirection();
Environment.GetEnvironmentVariable("Toto");
app.UseAuthorization();

app.MapControllers();
Console.WriteLine("Application prete � d�marrer");
app.Run();
