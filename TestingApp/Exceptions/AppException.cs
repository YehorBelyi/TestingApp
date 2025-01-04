using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Exceptions
{
    internal class AppException : Exception
    {
        public int ErrorCode { get; set; }
        public AppException(string message, int errorCde):base(message) {
            ErrorCode = errorCde;
        }
    }
}
