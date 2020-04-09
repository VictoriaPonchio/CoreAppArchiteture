using CoreAppArchiteture.Application.ShoppingLists.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppArchiteture.WebUI.Controllers
{
    public class TestController : BaseController
    {
        private readonly IMediator _mediator;
        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShoppingLists()
        {
            var query = new GetAllShoppingListsQuery();
            var result = await _mediator.Send(query);
            return Ok(query);
        }

    }
}
