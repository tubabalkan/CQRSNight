using CQRSNight.MediatorDesingPattern.Resultst;
using MediatR;


namespace CQRSNight.MediatorDesingPattern.Queries
{
    public class GetEmployeeQuery:IRequest<List<GetEmployeeQueryResult>>
    {
    }
}
