using Microsoft.EntityFrameworkCore;
using Student_api.Data;
using Student_api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentAdminContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Myconn")));
builder.Services.AddScoped<IStudentRepo, Student>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddCors(
    (options) =>
    {
        options.AddPolicy("default", (option) =>
        {
            option.AllowAnyMethod().AllowAnyOrigin().AllowAnyOrigin();
        });
    }
    );
var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("default");
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
