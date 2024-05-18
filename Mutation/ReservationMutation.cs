using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using GraphqlProject.Type;

namespace GraphqlProject.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationRepository reservationRepository)
        {
            Field<ReservationType>("CreateReservation").Arguments(new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" })).Resolve(context =>
            {
                return reservationRepository.AddReservation(context.GetArgument<Reservation>("reservation"));
            });
        }
    }
}