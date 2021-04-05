using System;
using System.Threading.Tasks;
using Convey.HTTP;
using MTNTripPlanner.Services.Notifications.Application.DTO;
using MTNTripPlanner.Services.Notifications.Application.Services.Clients;

namespace MTNTripPlanner.Services.Notifications.Infrastructure.Services.Clients
{
    public class TripServiceClient : ITripsServiceClient
    {
        private readonly IHttpClient _httpClient;
        private readonly string _url;

        public TripServiceClient(IHttpClient httpClient, HttpClientOptions options)
        {
            _httpClient = httpClient;
            _url = options.Services["trips"];
        }

        public Task<TripDTO> GetTripAsync(Guid tripId)
            => _httpClient.GetAsync<TripDTO>($"{_url}/trips/{tripId}");
    }
}