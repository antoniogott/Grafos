using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Vertice
    {
        public string Nome { get; set; }
        public Dictionary<string, double> Arestas { get; set; }

        public Vertice()
        {
            Arestas = new Dictionary<string, double>();
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
