using ASP06.ControllerApi.Models;

namespace ASP06.ControllerApi.Services;

public interface IBookService
{
    Task<List<Book>> GetAll();
}