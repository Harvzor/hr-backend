using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrBackend.Models;
using HrBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HrBackend.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventsRepository _eventsRepository;

        public EventsController(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        // /api/events/
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _eventsRepository.GetAllEvents();
        }

        // /api/events/id
        [HttpGet("{id}")]
        public Event Get(string id)
        {
            return _eventsRepository.GetEvent(id);
        }
    }
}
