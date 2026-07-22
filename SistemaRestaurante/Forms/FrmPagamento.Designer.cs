namespace SistemaRestaurante.Forms
{
    partial class FrmPagamento
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
            tlpPagamento = new TableLayoutPanel();
            lblTitulo = new Label();
            tlpResumo = new TableLayoutPanel();
            lblValorTotal = new Label();
            lblTotal = new Label();
            lblNumeroTipoPedido = new Label();
            lblNumeroPedido = new Label();
            lblPedido = new Label();
            lblTipoPedido = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblFormaDePagamento = new Label();
            cbPagmento = new ComboBox();
            pnlPagamentoDinheiro = new Panel();
            lblValorRecebido = new Label();
            txtValorRecebido = new TextBox();
            lblTroco = new Label();
            lblValorTroco = new Label();
            pnlBtns = new Panel();
            btnCancelarPagamento = new Button();
            btnConfirmarPagamento = new Button();
            tlpPagamento.SuspendLayout();
            tlpResumo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlPagamentoDinheiro.SuspendLayout();
            pnlBtns.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPagamento
            // 
            tlpPagamento.ColumnCount = 1;
            tlpPagamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPagamento.Controls.Add(lblTitulo, 0, 0);
            tlpPagamento.Controls.Add(tlpResumo, 0, 1);
            tlpPagamento.Controls.Add(flowLayoutPanel1, 0, 2);
            tlpPagamento.Controls.Add(pnlBtns, 0, 3);
            tlpPagamento.Dock = DockStyle.Fill;
            tlpPagamento.Location = new Point(0, 0);
            tlpPagamento.Name = "tlpPagamento";
            tlpPagamento.RowCount = 4;
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPagamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPagamento.Size = new Size(484, 511);
            tlpPagamento.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 50);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Pagamento";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpResumo
            // 
            tlpResumo.ColumnCount = 2;
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.7824287F));
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.2175751F));
            tlpResumo.Controls.Add(lblValorTotal, 1, 2);
            tlpResumo.Controls.Add(lblTotal, 0, 2);
            tlpResumo.Controls.Add(lblNumeroTipoPedido, 1, 1);
            tlpResumo.Controls.Add(lblNumeroPedido, 1, 0);
            tlpResumo.Controls.Add(lblPedido, 0, 0);
            tlpResumo.Controls.Add(lblTipoPedido, 0, 1);
            tlpResumo.Dock = DockStyle.Fill;
            tlpResumo.Location = new Point(3, 53);
            tlpResumo.Name = "tlpResumo";
            tlpResumo.RowCount = 3;
            tlpResumo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpResumo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpResumo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpResumo.Size = new Size(478, 114);
            tlpResumo.TabIndex = 4;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(88, 74);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(121, 32);
            lblValorTotal.TabIndex = 5;
            lblValorTotal.Text = "R$120,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(3, 74);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // lblNumeroTipoPedido
            // 
            lblNumeroTipoPedido.AutoSize = true;
            lblNumeroTipoPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroTipoPedido.Location = new Point(88, 37);
            lblNumeroTipoPedido.Name = "lblNumeroTipoPedido";
            lblNumeroTipoPedido.Size = new Size(28, 21);
            lblNumeroTipoPedido.TabIndex = 3;
            lblNumeroTipoPedido.Text = "05";
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroPedido.Location = new Point(88, 0);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(55, 21);
            lblNumeroPedido.TabIndex = 2;
            lblNumeroPedido.Text = "#0001";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(3, 0);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(57, 21);
            lblPedido.TabIndex = 0;
            lblPedido.Text = "Pedido";
            // 
            // lblTipoPedido
            // 
            lblTipoPedido.AutoSize = true;
            lblTipoPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPedido.Location = new Point(3, 37);
            lblTipoPedido.Name = "lblTipoPedido";
            lblTipoPedido.Size = new Size(47, 21);
            lblTipoPedido.TabIndex = 1;
            lblTipoPedido.Text = "Mesa";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblFormaDePagamento);
            flowLayoutPanel1.Controls.Add(cbPagmento);
            flowLayoutPanel1.Controls.Add(pnlPagamentoDinheiro);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 173);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(478, 264);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // lblFormaDePagamento
            // 
            lblFormaDePagamento.AutoSize = true;
            lblFormaDePagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormaDePagamento.Location = new Point(3, 0);
            lblFormaDePagamento.Name = "lblFormaDePagamento";
            lblFormaDePagamento.Size = new Size(152, 21);
            lblFormaDePagamento.TabIndex = 11;
            lblFormaDePagamento.Text = "Foma de Pagamento";
            // 
            // cbPagmento
            // 
            cbPagmento.FormattingEnabled = true;
            cbPagmento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão Débito", "Cartão Crédito" });
            cbPagmento.Location = new Point(3, 24);
            cbPagmento.Name = "cbPagmento";
            cbPagmento.Size = new Size(121, 23);
            cbPagmento.TabIndex = 10;
            cbPagmento.SelectedIndexChanged += cbPagmento_SelectedIndexChanged;
            // 
            // pnlPagamentoDinheiro
            // 
            pnlPagamentoDinheiro.Controls.Add(lblValorRecebido);
            pnlPagamentoDinheiro.Controls.Add(txtValorRecebido);
            pnlPagamentoDinheiro.Controls.Add(lblTroco);
            pnlPagamentoDinheiro.Controls.Add(lblValorTroco);
            pnlPagamentoDinheiro.Dock = DockStyle.Fill;
            pnlPagamentoDinheiro.Location = new Point(3, 53);
            pnlPagamentoDinheiro.Name = "pnlPagamentoDinheiro";
            pnlPagamentoDinheiro.Size = new Size(152, 130);
            pnlPagamentoDinheiro.TabIndex = 9;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorRecebido.Location = new Point(7, 9);
            lblValorRecebido.Margin = new Padding(3, 20, 3, 0);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(114, 21);
            lblValorRecebido.TabIndex = 13;
            lblValorRecebido.Text = "Valor Recebido";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Location = new Point(7, 33);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.Size = new Size(100, 23);
            txtValorRecebido.TabIndex = 14;
            txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTroco.Location = new Point(7, 79);
            lblTroco.Margin = new Padding(3, 20, 3, 0);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(48, 21);
            lblTroco.TabIndex = 15;
            lblTroco.Text = "Troco";
            // 
            // lblValorTroco
            // 
            lblValorTroco.AutoSize = true;
            lblValorTroco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorTroco.Location = new Point(7, 100);
            lblValorTroco.Name = "lblValorTroco";
            lblValorTroco.Size = new Size(59, 21);
            lblValorTroco.TabIndex = 16;
            lblValorTroco.Text = "R$0,00";
            // 
            // pnlBtns
            // 
            pnlBtns.Controls.Add(btnCancelarPagamento);
            pnlBtns.Controls.Add(btnConfirmarPagamento);
            pnlBtns.Dock = DockStyle.Fill;
            pnlBtns.Location = new Point(3, 443);
            pnlBtns.Name = "pnlBtns";
            pnlBtns.Size = new Size(478, 65);
            pnlBtns.TabIndex = 7;
            // 
            // btnCancelarPagamento
            // 
            btnCancelarPagamento.BackColor = Color.White;
            btnCancelarPagamento.Cursor = Cursors.Hand;
            btnCancelarPagamento.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
            btnCancelarPagamento.FlatAppearance.BorderSize = 2;
            btnCancelarPagamento.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnCancelarPagamento.FlatStyle = FlatStyle.Flat;
            btnCancelarPagamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarPagamento.ForeColor = Color.FromArgb(30, 41, 59);
            btnCancelarPagamento.Location = new Point(83, 20);
            btnCancelarPagamento.Name = "btnCancelarPagamento";
            btnCancelarPagamento.Size = new Size(150, 29);
            btnCancelarPagamento.TabIndex = 8;
            btnCancelarPagamento.Text = "Cancelar";
            btnCancelarPagamento.UseVisualStyleBackColor = false;
            btnCancelarPagamento.Click += btnCancelarPagamento_Click;
            // 
            // btnConfirmarPagamento
            // 
            btnConfirmarPagamento.BackColor = Color.FromArgb(30, 41, 59);
            btnConfirmarPagamento.Cursor = Cursors.Hand;
            btnConfirmarPagamento.FlatAppearance.BorderSize = 0;
            btnConfirmarPagamento.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnConfirmarPagamento.FlatStyle = FlatStyle.Flat;
            btnConfirmarPagamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarPagamento.ForeColor = Color.White;
            btnConfirmarPagamento.Location = new Point(239, 20);
            btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            btnConfirmarPagamento.Size = new Size(150, 29);
            btnConfirmarPagamento.TabIndex = 7;
            btnConfirmarPagamento.Text = "Confirmar";
            btnConfirmarPagamento.UseVisualStyleBackColor = false;
            btnConfirmarPagamento.Click += btnConfirmarPagamento_Click;
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(tlpPagamento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagamento";
            tlpPagamento.ResumeLayout(false);
            tlpPagamento.PerformLayout();
            tlpResumo.ResumeLayout(false);
            tlpResumo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlPagamentoDinheiro.ResumeLayout(false);
            pnlPagamentoDinheiro.PerformLayout();
            pnlBtns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPagamento;
        private Label lblTitulo;
        private TableLayoutPanel tlpResumo;
        private Label lblTotal;
        private Label lblNumeroTipoPedido;
        private Label lblNumeroPedido;
        private Label lblPedido;
        private Label lblTipoPedido;
        private Label lblValorTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlPagamentoDinheiro;
        private Label lblValorRecebido;
        private TextBox txtValorRecebido;
        private Label lblTroco;
        private Label lblValorTroco;
        private Panel pnlBtns;
        private Button btnConfirmarPagamento;
        private Button btnCancelarPagamento;
        private Label lblFormaDePagamento;
        private ComboBox cbPagmento;
    }
}