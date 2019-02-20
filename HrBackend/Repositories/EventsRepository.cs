
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HrBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HrBackend.Repositories
{
    /// <summary>
    /// CRUD handler for events. 
    /// </summary>
    public interface IEventsRepository
    {
        /// <summary>
        /// Purely for testing, be sure to remove!
        /// </summary>
        /// <returns></returns>
        Task<bool> SetupTestData();
        Task<IEnumerable<Event>> GetAllEvents();
        Task<Event> GetEvent(long id);
    }

    public class EventsRepository : IEventsRepository
    {
        private readonly EventsContext _context = null;

        public EventsRepository(DbContextOptions<EventsContext> options)
        {
            _context = new EventsContext(options);
        }
        
        public async Task<bool> SetupTestData()
        {
            for (var i = 1; i < 10; i++)
            {
                await _context.Events.AddAsync(new Event
                {
                    Id = i,
                    Name = "Lesson " + i,
                    StartDate = DateTime.UtcNow.AddDays(i),
                    EndDate = DateTime.UtcNow.AddDays(i).AddHours(2)
                });
            }

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Event>> GetAllEvents()
        {
            return await _context.Events.ToArrayAsync();

            /*
                return new List<Event>() {
                    new Event()
                    {
                        Name = "First Lesson",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now
                    }
                };
            */
        }

        public async Task<Event> GetEvent(long id)
        {
            return await _context.Events.FindAsync(id);

            /*
                return new Event()
                {
                    Name = "First Lesson",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now
                };
            */
        }
    }
}
