using MediatR;

namespace CQRSNight.MediatorDesingPattern.Commands
{
    public class CreateEmployeeCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
