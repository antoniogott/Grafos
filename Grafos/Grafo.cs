using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Grafo
    {
        public List<Vertice> Vertices { get; set; }

        public Grafo(double[,] matriz)
        {
            Vertices = new List<Vertice>();

            CriarVertices(matriz.GetLength(0));
            PreencherVertices(matriz);
        }

        private void PreencherVertices(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                var v = Vertices[i];

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    v.Arestas.Add(Vertices[j].Nome, matriz[i, j]);
                }
            }
        }

        private void CriarVertices(int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                Vertices.Add(new Vertice { Nome = "v" + (i + 1) });
            }
        }

        public Vertice GetVertice(string nome)
        {
            return Vertices.First(x => x.Nome == nome);
        }

        public int GetIndice(Vertice v)
        {
            return Vertices.FindIndex(x => x == v);
        }
    }
}
