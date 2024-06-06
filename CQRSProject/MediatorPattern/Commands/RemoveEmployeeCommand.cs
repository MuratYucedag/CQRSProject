using MediatR;

namespace CQRSProject.MediatorPattern.Commands
{
    public class RemoveEmployeeCommand:IRequest
    {
        public int EmployeeId { get; set; }
        public RemoveEmployeeCommand(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}