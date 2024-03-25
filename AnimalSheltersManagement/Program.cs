using AnimalShelterManagement.Application;
using AnimalShelterManagement.Persistance;

namespace AnimalSheltersManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(options =>
            options.AddPolicy(name: "MyAllowSpecificOrigns",
            builder =>
            {
                builder.AllowAnyOrigin();
            }));

            //builder.Services.AddInfrastructure(Configuration);
            builder.Services.AddApplication();
            builder.Services.AddPersistance(builder.Configuration);
            builder.Services.AddControllers();

            //builder.Services.AddAutoMapper(typeof(Program));


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHealthChecks();
            // Add services to the container.
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHealthChecks("/hc");

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}