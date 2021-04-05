using System;

namespace MTNTripPlanner.Services.Notifications.Application.DTO
{
    public class TripDTO
    {
        public Guid Id { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public string DifficultyLevel { get; set; }
    }
}