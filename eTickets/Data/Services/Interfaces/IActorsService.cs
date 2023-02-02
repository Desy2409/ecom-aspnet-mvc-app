using eTickets.Models;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsService
    {
        // Get all Actors.
        IEnumerable<Actor> GetAll();
        // Detail or Show : Get acor by it's id.
        Actor GetById(int id);
        // Add a new actor.
        void Add(Actor actor);
        // Update an existing actor.
        Actor Update(int id, Actor newActor);
        // Delete an actor.
        void Delete(int id);
    }
}
