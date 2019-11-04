using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using DmiConsulting.Eshop.Core;
using DmiConsulting.Eshop.Core.Entities;
using DmiConsulting.Eshop.Core.Interfaces;
using DmiConsulting.Eshop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DmiConsulting.Eshop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private IAsyncRepository<Product> _repository;
        private IMapper _mapper;

        public ProductController(IAsyncRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        // GET: api/ProductViewModel
        [HttpGet]
        public async Task<ActionResult<ProductViewModel[]>> Get()
        {

            var result = await _repository.ListAllAsync();

            var items = _mapper.Map<List<ProductViewModel>>(result.ToList());

            return items.ToArray();
        }

        // GET: api/ProductViewModel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductViewModel>> Get(int id)
        {
            var product = await _repository.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound(new ApiErrorViewModel((int)HttpStatusCode.NotFound, HttpStatusCode.NotFound.ToString(), 
                    $"Product {id} has not been found."));
            }

            return _mapper.Map<ProductViewModel>(product);
        }

        // POST: api/ProductViewModel
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ProductViewModel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
