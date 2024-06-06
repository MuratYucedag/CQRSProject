using CQRSProject.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _mediator.Send(new GetEmployeeQuery());
            return View(values);
        }
    }
}
