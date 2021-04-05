using System;
using System.Diagnostics.CodeAnalysis;
using Convey.CQRS.Events;
using Convey.MessageBrokers;

namespace MTNTripPlanner.Services.Notifications.Application.Events.External
{
    [Message("trip")]
    public class TripCreated : IEvent
    {
        public TripCreated(Guid tripId)
        {
            TripId = tripId;
        }

        public Guid TripId { get; }
    }
}