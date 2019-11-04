using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reinforced.Typings.Attributes;

namespace DmiConsulting.Eshop.ViewModels
{
    [TsInterface(Name = "ApiError", IncludeNamespace = false, AutoI = false)]
    public class ApiErrorViewModel
    {
        public int StatusCode { get; private set; }

        public string StatusDescription { get; private set; }

        public string Message { get; private set; }

        public ApiErrorViewModel(int statusCode, string statusDescription)
        {
            StatusCode = statusCode;
            StatusDescription = statusDescription;
        }

        public ApiErrorViewModel(int statusCode, string statusDescription, string message)
            : this(statusCode, statusDescription)
        {
            Message = message;
        }
    }
}
