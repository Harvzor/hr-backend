using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrBackend.Models;
using HrBackend.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HrBackend.Controllers
{
    /// <remarks>
    /// Ideally my controller would return an action result so I could specify the different response codes.
    /// </remarks>
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventsRepository _eventsRepository;

        public EventsController(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        /// <summary>
        /// Temporary.
        /// </summary>
        /// <returns></returns>
        [HttpGet("setup")]
        public Task<bool> Setup()
        {
            return _eventsRepository.SetupTestData();
        }

        /// <summary>
        /// /api/events/
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<IEnumerable<Event>> Get()
        {
            return _eventsRepository.GetAllEvents();
        }

        /// <summary>
        /// /api/events/id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Task<Event> Get(long id)
        {
            return _eventsRepository.GetEvent(id);
        }
    }
}
