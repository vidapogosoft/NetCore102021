using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.Extensions.Logging;

using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
using Services.Common.Collection;

using MediatR;
using Catalog.Services.EventHandlers.Commands;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace Catalag.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductQueryService _productQueryService;
        private readonly ILogger<ProductController> _logger;

        private readonly IMediator _mediator;

        public ProductController(
           ILogger<ProductController> logger,
           IProductQueryService productQueryService,
            IMediator mediator
           )
        {
            _logger = logger;
            _productQueryService = productQueryService;

            _mediator = mediator;
        }


            [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {

            _logger.LogInformation("--- Consulta sin filtro de registros");

            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productQueryService.GetAllAsync(page, take, products);
        }


        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            _logger.LogInformation("--- Consulta de registros con el parametro:" + id);
            return await _productQueryService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateCommand notification)
        {
            _logger.LogInformation("--- Creacion de registros");

            await _mediator.Publish(notification);

            return Ok();
        }

    }
}
