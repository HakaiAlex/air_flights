using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<UserService>();
        services.AddScoped<BookingService>();
        services.AddScoped<PaymentService>();
        services.AddScoped<TicketService>();
        services.AddScoped<PassengerService>();
        services.AddScoped<FlightService>();
        services.AddScoped<AircraftService>();
        services.AddScoped<AirportService>();
        services.AddScoped<AirlineService>();
        return services;
    }
}
