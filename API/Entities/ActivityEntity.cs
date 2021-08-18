using System;

namespace API.Entities
{
    public class ActivityEntity
    {
        public int Id { get; set; }
        public DateTime Stored { get; set; } = DateTime.Now;
        public string Activity { get; set; }
        public string Type { get; set; }
        public int Participant { get; set; }
        public decimal Price { get; set; }
        public string Key { get; set; }
        public decimal Accessibility { get; set; }
    }
}