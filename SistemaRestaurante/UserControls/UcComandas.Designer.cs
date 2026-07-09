namespace SistemaRestaurante.UserControls
{
    partial class UcComandas
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
            btnNovoPedido = new Button();
            lblTitulo = new Label();
            tlpComandas = new TableLayoutPanel();
            pnlHeader = new Panel();
            pnlGrid = new Panel();
            dgvComandas = new DataGridView();
            colNumeroComanda = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tlpComandas.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComandas).BeginInit();
            SuspendLayout();
            // 
            // btnNovoPedido
            // 
            btnNovoPedido.BackColor = Color.FromArgb(30, 41, 59);
            btnNovoPedido.Cursor = Cursors.Hand;
            btnNovoPedido.FlatAppearance.BorderSize = 0;
            btnNovoPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnNovoPedido.FlatStyle = FlatStyle.Flat;
            btnNovoPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoPedido.ForeColor = Color.White;
            btnNovoPedido.Location = new Point(800, 13);
            btnNovoPedido.Margin = new Padding(10, 3, 3, 3);
            btnNovoPedido.Name = "btnNovoPedido";
            btnNovoPedido.Size = new Size(150, 29);
            btnNovoPedido.TabIndex = 5;
            btnNovoPedido.Text = "Novo pedido";
            btnNovoPedido.UseVisualStyleBackColor = false;
            btnNovoPedido.Click += btnNovoPedido_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 32);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Comandas";
            // 
            // tlpComandas
            // 
            tlpComandas.ColumnCount = 1;
            tlpComandas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComandas.Controls.Add(pnlHeader, 0, 0);
            tlpComandas.Controls.Add(pnlGrid, 0, 1);
            tlpComandas.Dock = DockStyle.Fill;
            tlpComandas.Location = new Point(10, 10);
            tlpComandas.Name = "tlpComandas";
            tlpComandas.RowCount = 2;
            tlpComandas.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpComandas.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpComandas.Size = new Size(964, 531);
            tlpComandas.TabIndex = 7;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnNovoPedido);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 47);
            pnlHeader.TabIndex = 8;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvComandas);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 56);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(958, 472);
            pnlGrid.TabIndex = 9;
            // 
            // dgvComandas
            // 
            dgvComandas.AllowUserToAddRows = false;
            dgvComandas.AllowUserToDeleteRows = false;
            dgvComandas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComandas.BackgroundColor = Color.White;
            dgvComandas.BorderStyle = BorderStyle.None;
            dgvComandas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvComandas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvComandas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComandas.Columns.AddRange(new DataGridViewColumn[] { colNumeroComanda, colTipo, ColTotal, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvComandas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvComandas.Dock = DockStyle.Fill;
            dgvComandas.EnableHeadersVisualStyles = false;
            dgvComandas.GridColor = Color.Gainsboro;
            dgvComandas.Location = new Point(0, 0);
            dgvComandas.MultiSelect = false;
            dgvComandas.Name = "dgvComandas";
            dgvComandas.ReadOnly = true;
            dgvComandas.RowHeadersVisible = false;
            dgvComandas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComandas.Size = new Size(958, 472);
            dgvComandas.TabIndex = 1;
            dgvComandas.CellDoubleClick += dgvComandas_CellDoubleClick;
            // 
            // colNumeroComanda
            // 
            colNumeroComanda.DataPropertyName = "Numero";
            colNumeroComanda.HeaderText = "N°";
            colNumeroComanda.Name = "colNumeroComanda";
            colNumeroComanda.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // ColTotal
            // 
            ColTotal.DataPropertyName = "Total";
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // UcComandas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpComandas);
            Name = "UcComandas";
            Padding = new Padding(10);
            Size = new Size(984, 551);
            tlpComandas.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComandas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovoPedido;
        private Label lblTitulo;
        private TableLayoutPanel tlpComandas;
        private Panel pnlHeader;
        private Panel pnlGrid;
        private DataGridView dgvComandas;
        private DataGridViewTextBoxColumn colNumeroComanda;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewTextBoxColumn colStatus;
    }
}
