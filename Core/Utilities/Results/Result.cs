using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Kullanıcı Sadece Success isteyebilir ayrıca her ikisini de isteyebilir
        public Result(bool success, string message):this(success)//diğer constructoru tetikler
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
