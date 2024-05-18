
using GraphQL.Types;
using GraphqlProject.Models;

namespace GraphqlProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(c => c.Id);
            Field(c => c.CustomerName);
            Field(c => c.Email);
            Field(c => c.PhoneNumber);
            Field(c => c.PartySize);
            Field(c => c.SpecialRequest);
            Field(c => c.ReservationDate);
        }
    }
}