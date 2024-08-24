using Microsoft.EntityFrameworkCore;
using RelationshipsTask.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));

var app = builder.Build();

//app.Map("api/Author/Get", HandleRoute);

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

//static void HandleRoute(WebApplication app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Sample handled");
//    });
//}