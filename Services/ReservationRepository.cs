using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Services
{
    public class ReservationRepository : IReservationRepository
    {
        private GraphQLDbContext dbContext;

        public Reservation AddReservation(Reservation reservation)
        {
            dbContext.Reservations.Add(reservation);
            dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return dbContext.Reservations.ToList();
        }
    }
}