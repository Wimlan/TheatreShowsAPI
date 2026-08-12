using TheatreShowsAPI.Models;
namespace TheatreShowsAPI;

public interface IShowRepository
{
    Task<IEnumerable<Show>> GetAllAsync();
    Task<Show?> GetByIdAsync(int id);
    //Add method for searching shows by title
}
