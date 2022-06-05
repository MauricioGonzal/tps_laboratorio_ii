using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatoVacioException : Exception
    {
        public DatoVacioException(string message) : base(message)
        {
        }

        public DatoVacioException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
