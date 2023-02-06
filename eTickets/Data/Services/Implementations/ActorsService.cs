using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services.Implementations
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var result= await _context.Actors.FirstOrDefaultAsync(a => a.Id == id); 
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Actors.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
            //throw new NotImplementedException();
        }
    }
}
