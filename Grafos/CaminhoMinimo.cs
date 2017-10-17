using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class CaminhoMinimo : Form
    {
        double[,] _matriz;
        Grafo _grafo;

        public CaminhoMinimo(double[,] matriz, Grafo grafo)
        {
            InitializeComponent();
            InitializeComboBoxes(grafo.Vertices.Count);

            _matriz = matriz;
            _grafo = grafo;
        }

        private void InitializeComboBoxes(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                cb1.Items.Add("v" + i);
                cb2.Items.Add("v" + i);
            }
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            tbMain.Clear();

            if (cb1.SelectedItem != null && cb2.SelectedItem != null)
            {
                EncontrarCaminhoMinimo(_matriz, _grafo, (string)cb1.SelectedItem, (string)cb2.SelectedItem); 
            }
            else
            {
                tbMain.AppendText("Selecione dois vértices.");
            }
        }

        private void EncontrarCaminhoMinimo(double[,] matriz, Grafo grafo, string vx, string vy)
        {
            var x = grafo.GetVertice(vx);
            var y = grafo.GetVertice(vy);

            tbMain.AppendText($"Encontrando caminho do vértice {x} ao vértice {y}..." + Environment.NewLine);

            List<Vertice> _IN;
            Vertice p;
            var d = new double[grafo.Vertices.Count];
            var s = new Vertice[grafo.Vertices.Count];

            _IN = new List<Vertice>() { x };
            d[grafo.GetIndice(x)] = 0;

            foreach (Vertice z in grafo.Vertices.Where(z => !_IN.Contains(z)))
            {
                d[grafo.GetIndice(z)] = matriz[grafo.GetIndice(x), grafo.GetIndice(z)];
                s[grafo.GetIndice(z)] = x;
            }

            while (!_IN.Contains(y))
            {
                p = grafo.Vertices.Where(z => !_IN.Contains(z)).OrderBy(z => d[grafo.GetIndice(z)]).First();
                _IN.Add(p);

                foreach (Vertice z in grafo.Vertices.Where(z => !_IN.Contains(z)))
                {
                    var distAnterior = d[grafo.GetIndice(z)];
                    d[grafo.GetIndice(z)] = Math.Min(d[grafo.GetIndice(z)], d[grafo.GetIndice(p)] + matriz[grafo.GetIndice(p), grafo.GetIndice(z)]);

                    if (!(d[grafo.GetIndice(z)] == distAnterior))
                    {
                        s[grafo.GetIndice(z)] = p;
                    }
                }
            }

            //exibir
            if (d[grafo.GetIndice(y)] == Double.PositiveInfinity)
            {
                tbMain.AppendText(Environment.NewLine + "Não há caminho entre esses dois vértices.");
            }
            else
            {
                var caminho = new List<string>();

                tbMain.AppendText(Environment.NewLine + "Em ordem inversa, o caminho é:" + Environment.NewLine);
                tbMain.AppendText(y + Environment.NewLine);
                var _z = y;
                caminho.Add(_z.Nome);
                while (_z != x)
                {
                    var sz = s[grafo.GetIndice(_z)];
                    tbMain.AppendText(sz + Environment.NewLine);
                    caminho.Add(sz.Nome);
                    _z = sz;
                }

                caminho.Reverse();
                tbMain.AppendText(Environment.NewLine + "O caminho, na ordem certa, é:" + Environment.NewLine);
                caminho.ForEach(v => tbMain.AppendText(v + Environment.NewLine));

                tbMain.AppendText(Environment.NewLine + $"A distância do caminho é: {d[grafo.GetIndice(y)]}");
            }
        }
    }
}
