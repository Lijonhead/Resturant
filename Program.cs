
using Microsoft.EntityFrameworkCore;
using Resturant.Data;
using Resturant.Data.Repos;
using Resturant.Data.Repos.IRepos;
using Resturant.Services;
using Resturant.Services.IServices;

namespace Resturant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ResturantContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ResturantConnection")));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ITableRepository, TableRepository>();
            builder.Services.AddScoped<IBookingRepository, BookingRepository>();
            builder.Services.AddScoped<IMenurepository, MenuRepository>();
            builder.Services.AddScoped<ICustomerServices, CustomerServices>();
            builder.Services.AddScoped<ITableServices, TableServices>();
            builder.Services.AddScoped<IMenuServices, MenuServices>();
            builder.Services.AddScoped<IBookingServices, BookingServices>();

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
        }
    }
}
