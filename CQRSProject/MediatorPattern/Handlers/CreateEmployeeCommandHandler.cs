using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand>
    {
        private readonly Context _context;
        public CreateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _context.Employees.AddAsync(new Employee
            {
                Name = request.Name,
                Salary = request.Salary,
                Surname = request.Surname
            });
            await _context.SaveChangesAsync();
        }
    }
}
