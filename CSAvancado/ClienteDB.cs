using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAvancado
{
    public delegate void LogInclusao (Cliente c);

    public class ClienteDB
    {
        public ImplementationInterface Log { get; set; }

        private List<Cliente> database;

        public ClienteDB()
        {
            database = new List<Cliente>();
        }

        public void AddCliente(Cliente c)
        {
            if(Log != null)
            {
                Log.ImprimeLog(c);
            }
            database.Add(c);
        }
    }
}
