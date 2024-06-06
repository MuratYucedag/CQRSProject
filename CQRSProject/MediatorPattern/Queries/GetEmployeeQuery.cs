using CQRSProject.MediatorPattern.Results;
using MediatR;

namespace CQRSProject.MediatorPattern.Queries
{
    public class GetEmployeeQuery : IRequest<List<GetEmployeeQueryResult>>
    {
    }
}