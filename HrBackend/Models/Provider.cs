using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HrBackend.Models
{
    public class Provider
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        //public IEnumerable<long> EventIds { get; set; }
    }
}
