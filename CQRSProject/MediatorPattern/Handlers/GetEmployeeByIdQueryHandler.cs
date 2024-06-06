using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Queries;
using CQRSProject.MediatorPattern.Results;
using MediatR;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, GetEmployeeByIdQueryResult>
    {
        private readonly Context _context;
        public GetEmployeeByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetEmployeeByIdQueryResult> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.Id);
            return new GetEmployeeByIdQueryResult
            {
                EmployeeID = values.EmployeeID,
                Name = values.Name,
                Salary = values.Salary,
                Surname = values.Surname
            };
        }
    }
}
