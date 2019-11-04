using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DmiConsulting.Eshop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DmiConsulting.Eshop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("{code}")]
        public IActionResult Error(int code)
        {
            var statusCode = (HttpStatusCode) code;
            var apiError = new ApiErrorViewModel(code, statusCode.ToString());

            return new ObjectResult(apiError);
        }

    }
}