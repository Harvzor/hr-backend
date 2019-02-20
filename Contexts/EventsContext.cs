
using HrBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HrBackend
{
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
