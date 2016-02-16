using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAvancado
{
    public delegate void Clique();

    class Botao
    {
        public string Texto { get; set; }
        public Clique EventoClique { get; set; }
    }
}
