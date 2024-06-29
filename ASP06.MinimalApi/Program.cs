using ASP06.MinimalApi.Services;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// DI container service registration

builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// request pipeline

app.Use(async (context, next) =>
{
    var stopwatch = new Stopwatch();

    stopwatch.Start();

    context.Response.OnStarting(() =>
    {
        context.Response.Headers.Append("X-requestelapsedtimeinms",
            stopwatch.ElapsedMilliseconds.ToString());
        return Task.CompletedTask;
    });

    await next(context);
});

app.MapGet("/", () => "Hello world!");

app.MapGet("/books", async (IBookService service) => Results.Ok(await service.GetAll()));

app.Run();