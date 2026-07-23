namespace SistemaRestaurante.UserControls
{
    partial class UcFechamentos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvRelatorios = new DataGridView();
            colData = new DataGridViewTextBoxColumn();
            ColqtdVendas = new DataGridViewTextBoxColumn();
            ColTotalDinheiro = new DataGridViewTextBoxColumn();
            colTotalPix = new DataGridViewTextBoxColumn();
            ColTotalDebito = new DataGridViewTextBoxColumn();
            ColTotalCredito = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).BeginInit();
            SuspendLayout();
            // 
            // dgvRelatorios
            // 
            dgvRelatorios.AllowUserToAddRows = false;
            dgvRelatorios.AllowUserToDeleteRows = false;
            dgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorios.BackgroundColor = Color.White;
            dgvRelatorios.BorderStyle = BorderStyle.None;
            dgvRelatorios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRelatorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorios.Columns.AddRange(new DataGridViewColumn[] { colData, ColqtdVendas, ColTotalDinheiro, colTotalPix, ColTotalDebito, ColTotalCredito, ColTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRelatorios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRelatorios.Dock = DockStyle.Fill;
            dgvRelatorios.EnableHeadersVisualStyles = false;
            dgvRelatorios.GridColor = Color.Gainsboro;
            dgvRelatorios.Location = new Point(10, 10);
            dgvRelatorios.MultiSelect = false;
            dgvRelatorios.Name = "dgvRelatorios";
            dgvRelatorios.ReadOnly = true;
            dgvRelatorios.RowHeadersVisible = false;
            dgvRelatorios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRelatorios.Size = new Size(964, 531);
            dgvRelatorios.TabIndex = 3;
            // 
            // colData
            // 
            colData.DataPropertyName = "Data";
            colData.HeaderText = "Data";
            colData.Name = "colData";
            colData.ReadOnly = true;
            // 
            // ColqtdVendas
            // 
            ColqtdVendas.DataPropertyName = "QuantidadeVendas";
            ColqtdVendas.HeaderText = "Qtd. Vendas";
            ColqtdVendas.Name = "ColqtdVendas";
            ColqtdVendas.ReadOnly = true;
            // 
            // ColTotalDinheiro
            // 
            ColTotalDinheiro.DataPropertyName = "TotalDinheiro";
            ColTotalDinheiro.HeaderText = "Dinheiro";
            ColTotalDinheiro.Name = "ColTotalDinheiro";
            ColTotalDinheiro.ReadOnly = true;
            // 
            // colTotalPix
            // 
            colTotalPix.DataPropertyName = "TotalPix";
            colTotalPix.HeaderText = "Pix";
            colTotalPix.Name = "colTotalPix";
            colTotalPix.ReadOnly = true;
            // 
            // ColTotalDebito
            // 
            ColTotalDebito.DataPropertyName = "TotalDebito";
            ColTotalDebito.HeaderText = "Debito";
            ColTotalDebito.Name = "ColTotalDebito";
            ColTotalDebito.ReadOnly = true;
            // 
            // ColTotalCredito
            // 
            ColTotalCredito.DataPropertyName = "TotalCredito";
            ColTotalCredito.HeaderText = "Credito";
            ColTotalCredito.Name = "ColTotalCredito";
            ColTotalCredito.ReadOnly = true;
            // 
            // ColTotal
            // 
            ColTotal.DataPropertyName = "TotalGeral";
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            // 
            // UcFechamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRelatorios);
            Name = "UcFechamentos";
            Padding = new Padding(10);
            Size = new Size(984, 551);
            ((System.ComponentModel.ISupportInitialize)dgvRelatorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRelatorios;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn ColqtdVendas;
        private DataGridViewTextBoxColumn ColTotalDinheiro;
        private DataGridViewTextBoxColumn colTotalPix;
        private DataGridViewTextBoxColumn ColTotalDebito;
        private DataGridViewTextBoxColumn ColTotalCredito;
        private DataGridViewTextBoxColumn ColTotal;
    }
}
