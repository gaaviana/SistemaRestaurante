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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvCaixa = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colTipoNumero = new DataGridViewTextBoxColumn();
            colFormaPagamento = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            ColHora = new DataGridViewTextBoxColumn();
            tlpCaixa = new TableLayoutPanel();
            pnlHeader = new Panel();
            dtpData = new DateTimePicker();
            lblTitulo = new Label();
            pmlBtns = new Panel();
            btnFechamento = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlItens = new Panel();
            lblItensValor = new Label();
            lblItens = new Label();
            pnlTicket = new Panel();
            lblTicketValor = new Label();
            lblTicket = new Label();
            pnlReceita = new Panel();
            lblReceitaValor = new Label();
            lblReceita = new Label();
            pnlVendas = new Panel();
            lblVendasValor = new Label();
            lblVendas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).BeginInit();
            tlpCaixa.SuspendLayout();
            pnlHeader.SuspendLayout();
            pmlBtns.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlItens.SuspendLayout();
            pnlTicket.SuspendLayout();
            pnlReceita.SuspendLayout();
            pnlVendas.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaixa.Columns.AddRange(new DataGridViewColumn[] { colTipo, colTipoNumero, colFormaPagamento, colValor, ColHora });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCaixa.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCaixa.Dock = DockStyle.Fill;
            dgvCaixa.EnableHeadersVisualStyles = false;
            dgvCaixa.GridColor = Color.Gainsboro;
            dgvCaixa.Location = new Point(3, 135);
            dgvCaixa.MultiSelect = false;
            dgvCaixa.Name = "dgvCaixa";
            dgvCaixa.ReadOnly = true;
            dgvCaixa.RowHeadersVisible = false;
            dgvCaixa.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCaixa.Size = new Size(958, 339);
            dgvCaixa.TabIndex = 2;
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
            // tlpCaixa
            // 
            tlpCaixa.ColumnCount = 1;
            tlpCaixa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCaixa.Controls.Add(pnlHeader, 0, 0);
            tlpCaixa.Controls.Add(dgvCaixa, 0, 2);
            tlpCaixa.Controls.Add(pmlBtns, 0, 3);
            tlpCaixa.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpCaixa.Dock = DockStyle.Fill;
            tlpCaixa.Location = new Point(10, 10);
            tlpCaixa.Name = "tlpCaixa";
            tlpCaixa.RowCount = 4;
            tlpCaixa.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCaixa.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpCaixa.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpCaixa.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCaixa.Size = new Size(964, 531);
            tlpCaixa.TabIndex = 3;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(dtpData);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 47);
            pnlHeader.TabIndex = 9;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(818, 18);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(127, 23);
            dtpData.TabIndex = 7;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Caixa";
            // 
            // pmlBtns
            // 
            pmlBtns.Controls.Add(btnFechamento);
            pmlBtns.Controls.Add(button1);
            pmlBtns.Dock = DockStyle.Fill;
            pmlBtns.Location = new Point(3, 480);
            pmlBtns.Name = "pmlBtns";
            pmlBtns.Size = new Size(958, 48);
            pmlBtns.TabIndex = 3;
            // 
            // btnFechamento
            // 
            btnFechamento.BackColor = Color.FromArgb(30, 41, 59);
            btnFechamento.Cursor = Cursors.Hand;
            btnFechamento.FlatAppearance.BorderSize = 0;
            btnFechamento.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnFechamento.FlatStyle = FlatStyle.Flat;
            btnFechamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechamento.ForeColor = Color.White;
            btnFechamento.Location = new Point(515, 16);
            btnFechamento.Margin = new Padding(10, 3, 3, 3);
            btnFechamento.Name = "btnFechamento";
            btnFechamento.Size = new Size(150, 29);
            btnFechamento.TabIndex = 6;
            btnFechamento.Text = "Fechamento";
            btnFechamento.UseVisualStyleBackColor = false;
            btnFechamento.Click += btnFechamento_Click;
            // 
            // button1
            // 
            button1.Location = new Point(340, 19);
            button1.Name = "button1";
            button1.Size = new Size(95, 26);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(pnlItens, 4, 0);
            tableLayoutPanel1.Controls.Add(pnlTicket, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlReceita, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlVendas, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(958, 73);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlItens
            // 
            pnlItens.BackColor = Color.FromArgb(30, 41, 59);
            pnlItens.BorderStyle = BorderStyle.Fixed3D;
            pnlItens.Controls.Add(lblItensValor);
            pnlItens.Controls.Add(lblItens);
            pnlItens.Dock = DockStyle.Fill;
            pnlItens.Location = new Point(671, 3);
            pnlItens.Name = "pnlItens";
            pnlItens.Size = new Size(185, 67);
            pnlItens.TabIndex = 4;
            // 
            // lblItensValor
            // 
            lblItensValor.AutoSize = true;
            lblItensValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItensValor.ForeColor = Color.White;
            lblItensValor.Location = new Point(15, 32);
            lblItensValor.Name = "lblItensValor";
            lblItensValor.Size = new Size(28, 21);
            lblItensValor.TabIndex = 1;
            lblItensValor.Text = "00";
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItens.ForeColor = Color.White;
            lblItens.Location = new Point(10, 10);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(55, 25);
            lblItens.TabIndex = 0;
            lblItens.Text = "Itens";
            // 
            // pnlTicket
            // 
            pnlTicket.BackColor = Color.FromArgb(30, 41, 59);
            pnlTicket.BorderStyle = BorderStyle.Fixed3D;
            pnlTicket.Controls.Add(lblTicketValor);
            pnlTicket.Controls.Add(lblTicket);
            pnlTicket.Dock = DockStyle.Fill;
            pnlTicket.Location = new Point(480, 3);
            pnlTicket.Name = "pnlTicket";
            pnlTicket.Size = new Size(185, 67);
            pnlTicket.TabIndex = 3;
            // 
            // lblTicketValor
            // 
            lblTicketValor.AutoSize = true;
            lblTicketValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketValor.ForeColor = Color.White;
            lblTicketValor.Location = new Point(15, 32);
            lblTicketValor.Name = "lblTicketValor";
            lblTicketValor.Size = new Size(28, 21);
            lblTicketValor.TabIndex = 1;
            lblTicketValor.Text = "00";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicket.ForeColor = Color.White;
            lblTicket.Location = new Point(10, 10);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(65, 25);
            lblTicket.TabIndex = 0;
            lblTicket.Text = "Ticket";
            // 
            // pnlReceita
            // 
            pnlReceita.BackColor = Color.FromArgb(30, 41, 59);
            pnlReceita.BorderStyle = BorderStyle.Fixed3D;
            pnlReceita.Controls.Add(lblReceitaValor);
            pnlReceita.Controls.Add(lblReceita);
            pnlReceita.Dock = DockStyle.Fill;
            pnlReceita.Location = new Point(289, 3);
            pnlReceita.Name = "pnlReceita";
            pnlReceita.Size = new Size(185, 67);
            pnlReceita.TabIndex = 2;
            // 
            // lblReceitaValor
            // 
            lblReceitaValor.AutoSize = true;
            lblReceitaValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceitaValor.ForeColor = Color.White;
            lblReceitaValor.Location = new Point(15, 32);
            lblReceitaValor.Name = "lblReceitaValor";
            lblReceitaValor.Size = new Size(28, 21);
            lblReceitaValor.TabIndex = 1;
            lblReceitaValor.Text = "00";
            // 
            // lblReceita
            // 
            lblReceita.AutoSize = true;
            lblReceita.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceita.ForeColor = Color.White;
            lblReceita.Location = new Point(10, 10);
            lblReceita.Name = "lblReceita";
            lblReceita.Size = new Size(75, 25);
            lblReceita.TabIndex = 0;
            lblReceita.Text = "Receita";
            // 
            // pnlVendas
            // 
            pnlVendas.BackColor = Color.FromArgb(30, 41, 59);
            pnlVendas.BorderStyle = BorderStyle.Fixed3D;
            pnlVendas.Controls.Add(lblVendasValor);
            pnlVendas.Controls.Add(lblVendas);
            pnlVendas.Dock = DockStyle.Fill;
            pnlVendas.Location = new Point(98, 3);
            pnlVendas.Name = "pnlVendas";
            pnlVendas.Size = new Size(185, 67);
            pnlVendas.TabIndex = 0;
            // 
            // lblVendasValor
            // 
            lblVendasValor.AutoSize = true;
            lblVendasValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVendasValor.ForeColor = Color.White;
            lblVendasValor.Location = new Point(15, 32);
            lblVendasValor.Name = "lblVendasValor";
            lblVendasValor.Size = new Size(28, 21);
            lblVendasValor.TabIndex = 1;
            lblVendasValor.Text = "00";
            // 
            // lblVendas
            // 
            lblVendas.AutoSize = true;
            lblVendas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendas.ForeColor = Color.White;
            lblVendas.Location = new Point(10, 10);
            lblVendas.Name = "lblVendas";
            lblVendas.Size = new Size(76, 25);
            lblVendas.TabIndex = 0;
            lblVendas.Text = "Vendas";
            // 
            // UcCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCaixa);
            Name = "UcCaixa";
            Padding = new Padding(10);
            Size = new Size(984, 551);
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).EndInit();
            tlpCaixa.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pmlBtns.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlItens.ResumeLayout(false);
            pnlItens.PerformLayout();
            pnlTicket.ResumeLayout(false);
            pnlTicket.PerformLayout();
            pnlReceita.ResumeLayout(false);
            pnlReceita.PerformLayout();
            pnlVendas.ResumeLayout(false);
            pnlVendas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCaixa;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colTipoNumero;
        private DataGridViewTextBoxColumn colFormaPagamento;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn ColHora;
        private TableLayoutPanel tlpCaixa;
        private Panel pmlBtns;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlVendas;
        private Label lblVendasValor;
        private Label lblVendas;
        private Panel pnlItens;
        private Label lblItensValor;
        private Label lblItens;
        private Panel pnlTicket;
        private Label lblTicketValor;
        private Label lblTicket;
        private Panel pnlReceita;
        private Label lblReceitaValor;
        private Label lblReceita;
        private Panel pnlHeader;
        private Label lblTitulo;
        private Button btnFechamento;
        private DateTimePicker dtpData;
    }
}
