namespace Grafos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.lbTamanhoX = new System.Windows.Forms.Label();
            this.btCriar = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.btEuler = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            this.dgvMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriz.ColumnHeadersHeight = 35;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "inf";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMatriz.Location = new System.Drawing.Point(12, 41);
            this.dgvMatriz.Name = "dgvMatriz";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz.RowHeadersWidth = 55;
            this.dgvMatriz.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMatriz.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriz.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMatriz.RowTemplate.Height = 35;
            this.dgvMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatriz.Size = new System.Drawing.Size(564, 328);
            this.dgvMatriz.TabIndex = 0;
            // 
            // lbTamanho
            // 
            this.lbTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Location = new System.Drawing.Point(12, 17);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(100, 13);
            this.lbTamanho.TabIndex = 1;
            this.lbTamanho.Text = "Tamanho da matriz:";
            // 
            // tbTamanho
            // 
            this.tbTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTamanho.Location = new System.Drawing.Point(118, 14);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(34, 20);
            this.tbTamanho.TabIndex = 2;
            this.tbTamanho.TextChanged += new System.EventHandler(this.TbTamanho_TextChanged);
            this.tbTamanho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbTamanho_KeyDown);
            this.tbTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTamanho_KeyPress);
            // 
            // lbTamanhoX
            // 
            this.lbTamanhoX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTamanhoX.AutoSize = true;
            this.lbTamanhoX.Location = new System.Drawing.Point(158, 17);
            this.lbTamanhoX.Name = "lbTamanhoX";
            this.lbTamanhoX.Size = new System.Drawing.Size(15, 13);
            this.lbTamanhoX.TabIndex = 3;
            this.lbTamanhoX.Text = "x ";
            // 
            // btCriar
            // 
            this.btCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCriar.Location = new System.Drawing.Point(501, 12);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(75, 23);
            this.btCriar.TabIndex = 4;
            this.btCriar.Text = "Criar matriz";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.BtCreate_Click);
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.Location = new System.Drawing.Point(457, 375);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(119, 23);
            this.btMin.TabIndex = 5;
            this.btMin.Text = "Caminho Mínimo";
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btEuler
            // 
            this.btEuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEuler.Location = new System.Drawing.Point(332, 375);
            this.btEuler.Name = "btEuler";
            this.btEuler.Size = new System.Drawing.Size(119, 23);
            this.btEuler.TabIndex = 6;
            this.btEuler.Text = "Caminho Euleriano";
            this.btEuler.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLimpar.Location = new System.Drawing.Point(12, 375);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(119, 23);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar matriz";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 410);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btEuler);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.lbTamanhoX);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.dgvMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Label lbTamanhoX;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btEuler;
        private System.Windows.Forms.Button btLimpar;
    }
}

