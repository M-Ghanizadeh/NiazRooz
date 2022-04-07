using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public StatusCode statusCode { get; set; }
        public string Message { get; set; }
    }

    public class ResultDto<TData> : ResultDto
    {
        public TData Data { get; set; }
    }

    public enum StatusCode
    {
        Success = 1,
        BadRequest = 2,
        Notfound = 3,
        EmptyList = 4,
        ServerError = 5,
        DeActive = 6,
    }
}
