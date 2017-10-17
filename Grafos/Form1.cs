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
    public partial class Form1 : Form
    {
        double[,] matriz;

        public Form1()
        {
            InitializeComponent();
        }

        private void TbTamanho_TextChanged(object sender, EventArgs e)
        {
            lbTamanhoX.Text = "x " + (sender as TextBox)?.Text;
        }

        private void TbTamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                CriarMatriz();
            }
        }

        private void TbTamanho_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            LimparMatriz(dgvMatriz);
        }

        private void BtCreate_Click(object sender, EventArgs e)
        {
            CriarMatriz();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            PreencherMatriz(true);
            
            var windowCaminhoMinimo = new CaminhoMinimo(matriz, new Grafo(matriz));
            windowCaminhoMinimo.ShowDialog();
        }

        private void btEuler_Click(object sender, EventArgs e)
        {
            PreencherMatriz(false);
            CaminhoEuleriano(matriz);
        }

        private void MakeCellsSquare(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = dgv.Rows[0].Height;
            }
        }

        private void CriarMatriz()
        {
            var tamanho = uint.Parse(tbTamanho.Text);
            matriz = new double[tamanho, tamanho];

            LimparMatriz(dgvMatriz);

            for (int i = 0; i < (int)tamanho; i++)
                dgvMatriz.Columns.Add((i + 1).ToString(), (i + 1).ToString());

            dgvMatriz.Rows.Add((int)tamanho);
            foreach (DataGridViewRow row in dgvMatriz.Rows)
                row.HeaderCell.Value = (row.Index + 1).ToString();

            MakeCellsSquare(dgvMatriz);
        }

        private void PreencherMatriz(bool nullIsInfinity)
        {
            for (int i = 0; i < dgvMatriz.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMatriz.Columns.Count; j++)
                {
                    var value = dgvMatriz.Rows[i].Cells[j].Value;

                    if (value == null || value.ToString().ToLower() == "-")
                    {
                        matriz[i, j] = nullIsInfinity ? Double.PositiveInfinity : 0;
                    }
                    else
                    {
                        matriz[i, j] = Math.Truncate(Double.Parse(value.ToString()));
                    }
                }
            }
        }

        public static void LimparMatriz(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
        }

        private void CaminhoEuleriano(double[,] matriz)
        {
            int total, grau;
            int n = matriz.GetLength(0);

            total = 0;

            for (int i = 0; total <= 2 && i < n; i++)
            {
                grau = 0;

                for (int j = 0; j < n; j++)
                    grau += Convert.ToInt32(matriz[i, j]);

                if (grau % 2 != 0) 
                    total++;
            }

            if (total > 2)
                MessageBox.Show("Não existe caminho euleriano.");
            else
                MessageBox.Show("Existe um caminho euleriano.");
        }
    }
}