using Convey;
using Convey.CQRS.Queries;
using Convey.Docs.Swagger;
using Convey.HTTP;
using Convey.MessageBrokers.CQRS;
using Convey.MessageBrokers.RabbitMQ;
using Convey.WebApi;
using Convey.WebApi.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MTNTripPlanner.Services.Notifications.Application.Events.External;
using MTNTripPlanner.Services.Notifications.Application.Services.Clients;
using MTNTripPlanner.Services.Notifications.Infrastructure.Services.Clients;

namespace MTNTripPlanner.Services.Notifications.Infrastructure
{
    public static class Extension
    {
        public static IConveyBuilder AddInfrastructure(this IConveyBuilder builder)
        {

            builder.Services.AddTransient<ITripsServiceClient, TripServiceClient>();
            
            builder
                //     .AddQueryHandlers()
                //     .AddInMemoryQueryDispatcher();
                .AddRabbitMq()
                .AddHttpClient();
                // .AddSwaggerDocs()
                // .AddWebApiSwaggerDocs();
            
            
            return builder;
        }
        
        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app
                // app.UseErrorHandler()
                .UseConvey()
                .UseRabbitMq()
                .SubscribeEvent<TripCreated>();
            return app;
        }
    }
}