using System.Collections.Generic;

namespace Trip.Data
{
    public interface ITripService
    {
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void UpdateTrip(int tripId, Trip trip);
        void DeleteTrip(int tripId);
        void addTrip(Trip trip);
    }
}
