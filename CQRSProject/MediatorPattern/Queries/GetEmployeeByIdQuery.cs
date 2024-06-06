using CQRSProject.MediatorPattern.Results;
using MediatR;

namespace CQRSProject.MediatorPattern.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResult>
    {
        public int Id { get; set; }
        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }
}