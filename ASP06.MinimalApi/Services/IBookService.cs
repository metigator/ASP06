using ASP06.MinimalApi.Models;

namespace ASP06.MinimalApi.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAll();
    }
}