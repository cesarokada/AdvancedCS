using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAvancado
{
    class ClienteInvalidoException : Exception
    {
        public ClienteInvalidoException() 
            : base()
        {

        }

        public ClienteInvalidoException(string message) 
            : base(message)
        {

        }


    }
}
