using System;
namespace Trip.Data
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

    }
}