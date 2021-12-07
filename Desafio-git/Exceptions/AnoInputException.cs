using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_git.Exceptions
{
    public class AnoInputException : Exception
    {
        public AnoInputException() : base("O ano deve conter 4 dígitos!")
        { }
    }
}
