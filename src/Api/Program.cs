using DataAccess.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDataAccessDependencies(builder.Configuration.GetConnectionString("Spanner"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Deployed App", builder =>
    {
        builder.WithOrigins("https://campus-crawl-client-32wswsezka-uc.a.run.app/*")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });

    options.AddPolicy("Local App", builder =>
    {
        builder.WithOrigins("https://localhost:3000/*")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });

    options.AddPolicy("Other Local App", builder =>
    {
        builder.WithOrigins("http://localhost:3000/*")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
