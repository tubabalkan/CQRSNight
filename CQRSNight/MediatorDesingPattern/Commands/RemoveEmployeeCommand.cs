using MediatR;

namespace CQRSNight.MediatorDesingPattern.Commands
{
    public class RemoveEmployeeCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveEmployeeCommand(int id)
        {
            Id = id;
        }
    }
}
