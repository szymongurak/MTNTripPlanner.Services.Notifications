using System;
using System.Threading.Tasks;
using MTNTripPlanner.Services.Notifications.Application.DTO;

namespace MTNTripPlanner.Services.Notifications.Application.Services.Clients
{
    public interface ITripsServiceClient
    {
        Task<TripDTO> GetTripAsync(Guid tripId);
    }
}