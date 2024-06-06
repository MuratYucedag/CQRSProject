using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand>
    {
        private readonly Context _context;
        public RemoveEmployeeCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Employees.Find(request.EmployeeId);
            _context.Employees.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}