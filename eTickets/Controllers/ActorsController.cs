using eTickets.Data;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _service.GetAllAsync();
            return View(actors);
        }

        // URL => Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }

        // URL => Actors/Details/Id
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("404 | NOT FOUND !");
            return View(actorDetails);
        }

        // URL => Actors/Edit/Id
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return View("404 | NOT FOUND !");
            return View(actor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}
