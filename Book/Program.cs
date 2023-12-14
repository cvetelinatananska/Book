using BookStore.BL.Interfacces;
using BookStore.BL.Services;
using BookStore.DL.interfaces;
using BookStore.DL.Repository;

namespace Book2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddSingleton<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<IBookServicces, BookService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<BookStore.DL.Repository.BookRepository, BookStore.DL.Repository.BookRepository>();

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
