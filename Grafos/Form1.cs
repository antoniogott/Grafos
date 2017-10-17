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
            LimparMatriz((DataGridView)sender);
        }

        private void BtCreate_Click(object sender, EventArgs e)
        {
            CriarMatriz();
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

        private void MakeCellsSquare(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = dgv.Rows[0].Height;
            }
        }

        public static void LimparMatriz(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatriz.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMatriz.Columns.Count; j++)
                {
                    var value = dgvMatriz.Rows[i].Cells[j].Value;

                    if (value == null || value.ToString().ToLower() == "inf")
                    {
                        matriz[i, j] = Double.PositiveInfinity;
                    }
                    else
                    {
                        matriz[i, j] = Math.Truncate(Double.Parse(value.ToString()));
                    }
                }
            }
            
            var windowCaminhoMinimo = new CaminhoMinimo(matriz, new Grafo(matriz));
            windowCaminhoMinimo.ShowDialog();
        }
    }
}