using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Queries;
using CQRSProject.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeeQuery, List<GetEmployeeQueryResult>>
    {
        private readonly Context _context;
        public GetEmployeeQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<List<GetEmployeeQueryResult>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _context.Employees.Select(x => new GetEmployeeQueryResult
            {
                EmployeeID = x.EmployeeID,
                Name = x.Name,
                Salary = x.Salary,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}