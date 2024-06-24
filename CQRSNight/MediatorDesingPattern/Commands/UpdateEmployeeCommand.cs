using MediatR;

namespace CQRSNight.MediatorDesingPattern.Commands
{
    public class UpdateEmployeeCommand:IRequest
    {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
