using eTickets.Models;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsService
    {
        // Get all Actors.
        Task<IEnumerable<Actor>> GetAllAsync();
        // Detail or Show : Get acor by it's id.
        Task<Actor> GetByIdAsync(int id);
        // Add a new actor.
        Task AddAsync(Actor actor);
        // Update an existing actor.
        Task<Actor> UpdateAsync(int id, Actor newActor);
        // Delete an actor.
        Task DeleteAsync(int id);
    }
}
