using CQRSNight.MediatorDesingPattern.Resultst;
using MediatR;

namespace CQRSNight.MediatorDesingPattern.Queries
{
    public class GetEmployeeByIdQuery:IRequest<GetEmployeeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
