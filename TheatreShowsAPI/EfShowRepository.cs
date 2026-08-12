using Microsoft.EntityFrameworkCore;
using TheatreShowsAPI.Data;
using TheatreShowsAPI.Models;


namespace TheatreShowsAPI
{
    public class EfShowRepository: IShowRepository
    {
        private readonly AppDbContext _context;
        public EfShowRepository( AppDbContext context ) => _context = context;

        public async Task<IEnumerable<Show>> GetAllAsync() =>
    await _context.Shows
        .Include(s => s.Genres)
        .Include(s => s.ProductionMembers)
        .ToListAsync();

        public async Task<Show?> GetByIdAsync(int id)
        {
            return await _context.Shows.FindAsync(id);
        }
    }
}
