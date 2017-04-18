using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCommons.Lang
{
    public class MethodResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return $"IsSuccess: {IsSuccess}\nMessage: {Message}\nValue: {Value}";
        }
    }
}
