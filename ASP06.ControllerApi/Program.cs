using ASP06.ControllerApi.Services;

var builder = WebApplication.CreateBuilder(args);

// DI container service registration

builder.Services.AddControllers();

builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// request pipeline

app.MapControllers();

app.Run();