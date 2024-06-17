using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Exceptions
{
    public class CuitException : Exception
    {
        public CuitException(string mensaje):base(mensaje)
        {
        }
    }
}
