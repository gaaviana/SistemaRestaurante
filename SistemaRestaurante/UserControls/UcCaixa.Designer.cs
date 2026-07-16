namespace SistemaRestaurante.UserControls
{
    partial class UcCaixa
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvCaixa = new DataGridView();
            colPedido = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colTipoNumero = new DataGridViewTextBoxColumn();
            colFormaPagamento = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            ColHora = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).BeginInit();
            SuspendLayout();
            // 
            // dgvCaixa
            // 
            dgvCaixa.AllowUserToAddRows = false;
            dgvCaixa.AllowUserToDeleteRows = false;
            dgvCaixa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaixa.BackgroundColor = Color.White;
            dgvCaixa.BorderStyle = BorderStyle.None;
            dgvCaixa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaixa.Columns.AddRange(new DataGridViewColumn[] { colPedido, colTipo, colTipoNumero, colFormaPagamento, colValor, ColHora });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCaixa.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCaixa.Dock = DockStyle.Fill;
            dgvCaixa.EnableHeadersVisualStyles = false;
            dgvCaixa.GridColor = Color.Gainsboro;
            dgvCaixa.Location = new Point(0, 0);
            dgvCaixa.MultiSelect = false;
            dgvCaixa.Name = "dgvCaixa";
            dgvCaixa.ReadOnly = true;
            dgvCaixa.RowHeadersVisible = false;
            dgvCaixa.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCaixa.Size = new Size(984, 551);
            dgvCaixa.TabIndex = 2;
            // 
            // colPedido
            // 
            colPedido.HeaderText = "N°";
            colPedido.Name = "colPedido";
            colPedido.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colTipoNumero
            // 
            colTipoNumero.DataPropertyName = "Numero";
            colTipoNumero.HeaderText = "N° Comanda";
            colTipoNumero.Name = "colTipoNumero";
            colTipoNumero.ReadOnly = true;
            // 
            // colFormaPagamento
            // 
            colFormaPagamento.DataPropertyName = "FormaPagamento";
            colFormaPagamento.HeaderText = "Forma Pagamento";
            colFormaPagamento.Name = "colFormaPagamento";
            colFormaPagamento.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.DataPropertyName = "Total";
            colValor.HeaderText = "Valor";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // ColHora
            // 
            ColHora.DataPropertyName = "DataPagamento";
            ColHora.HeaderText = "Hora";
            ColHora.Name = "ColHora";
            ColHora.ReadOnly = true;
            // 
            // UcCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCaixa);
            Name = "UcCaixa";
            Size = new Size(984, 551);
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCaixa;
        private DataGridViewTextBoxColumn colPedido;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colTipoNumero;
        private DataGridViewTextBoxColumn colFormaPagamento;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn ColHora;
    }
}
