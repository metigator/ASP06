using ASP06.MinimalApi.Models;

namespace ASP06.MinimalApi.Services;

public class BookService : IBookService
{
    public async Task<List<Book>> GetAll()
    {
        await Task.Delay(Random.Shared.Next(500, 3000));

        var books = new List<Book>
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin" },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt, David Thomas" },
            new Book { Id = 3, Title = "Design Patterns: Elements of Reusable Object-Oriented Software", Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides" },
            new Book { Id = 4, Title = "Refactoring: Improving the Design of Existing Code", Author = "Martin Fowler" },
            new Book { Id = 5, Title = "Code Complete", Author = "Steve McConnell" },
            new Book { Id = 6, Title = "Continuous Delivery: Reliable Software Releases through Build, Test, and Deployment Automation", Author = "Jez Humble, David Farley" },
            new Book { Id = 7, Title = "The Mythical Man-Month: Essays on Software Engineering", Author = "Frederick P. Brooks Jr." },
            new Book { Id = 8, Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software", Author = "Eric Evans" },
            new Book { Id = 9, Title = "Software Engineering at Google: Lessons Learned from Programming Over Time", Author = "Titus Winters, Tom Manshreck, Hyrum Wright" },
            new Book { Id = 10, Title = "Working Effectively with Legacy Code", Author = "Michael Feathers" }
        };

        return books;
    }
}