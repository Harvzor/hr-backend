
using System;
using System.ComponentModel.DataAnnotations;

namespace HrBackend.Models
{
    public class Event
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Should be UTC time. Change to local time for rendering.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Should be UTC time. Change to local time for rendering.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
