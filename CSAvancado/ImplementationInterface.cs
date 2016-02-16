using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAvancado
{
    public class ImplementationInterface : LogCliente
    {
        public void ImprimeLog(Cliente c)
        {
            Console.WriteLine(string.Format("O cliente {0} de documento {1} foi cadastrado", c.Nome, c.Documento));
        }
    }
}
