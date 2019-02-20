using System.Collections.Generic;

namespace HrBackend.Models
{
    public class Provider
    {
        public string Name;
        public IEnumerable<Event> Events;
    }
}
