using System.Threading.Tasks;
using Convey.CQRS.Events;
using MTNTripPlanner.Services.Notifications.Application.Services.Clients;

namespace MTNTripPlanner.Services.Notifications.Application.Events.External.Handlers
{
    public class TripCreatedHandler : IEventHandler<TripCreated>
    {
        private readonly ITripsServiceClient _tripsServiceClient;


        public TripCreatedHandler(ITripsServiceClient tripsServiceClient)
        {
            _tripsServiceClient = tripsServiceClient;
        }
        
        public async Task HandleAsync(TripCreated @event)
        {
            var tripInfo = await _tripsServiceClient.GetTripAsync(@event.TripId);

            string destination = tripInfo.Destination;
            // return Task.CompletedTask;
        }
    }
}