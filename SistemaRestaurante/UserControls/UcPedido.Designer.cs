namespace SistemaRestaurante.UserControls
{
    partial class UcPedido
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
            pnlFooter = new Panel();
            pnlRigth = new Panel();
            flwRight = new FlowLayoutPanel();
            btnFinalizarPedido = new Button();
            btnSalvarPedido = new Button();
            btnCancelar = new Button();
            pnlLeft = new Panel();
            lblTotal = new Label();
            lblTxtTotal = new Label();
            pnlGrid = new Panel();
            dgvProdutos = new DataGridView();
            colProduto = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colValorUnitario = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colRemover = new DataGridViewButtonColumn();
            pnlAdicionarProduto = new Panel();
            flpAdicionarProduto = new FlowLayoutPanel();
            lblProduto = new Label();
            cbProduto = new ComboBox();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            btnAdicionarProduto = new Button();
            pnlPedido = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTipoPedido = new Label();
            rbViagem = new RadioButton();
            rbMesa = new RadioButton();
            lblNumeroMesa_Comanda = new Label();
            cbNumero = new ComboBox();
            pnlHeader = new Panel();
            pnlHeaderRigth = new Panel();
            lblNumeroPedido = new Label();
            pnlHeaderLeft = new Panel();
            lblTitulo = new Label();
            tlpUcPedidos = new TableLayoutPanel();
            pnlFooter.SuspendLayout();
            pnlRigth.SuspendLayout();
            flwRight.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            pnlAdicionarProduto.SuspendLayout();
            flpAdicionarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            pnlPedido.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlHeaderRigth.SuspendLayout();
            pnlHeaderLeft.SuspendLayout();
            tlpUcPedidos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(pnlRigth);
            pnlFooter.Controls.Add(pnlLeft);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(13, 490);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(958, 48);
            pnlFooter.TabIndex = 4;
            // 
            // pnlRigth
            // 
            pnlRigth.Controls.Add(flwRight);
            pnlRigth.Dock = DockStyle.Right;
            pnlRigth.Location = new Point(551, 0);
            pnlRigth.Name = "pnlRigth";
            pnlRigth.Size = new Size(407, 48);
            pnlRigth.TabIndex = 8;
            // 
            // flwRight
            // 
            flwRight.Controls.Add(btnFinalizarPedido);
            flwRight.Controls.Add(btnSalvarPedido);
            flwRight.Controls.Add(btnCancelar);
            flwRight.Dock = DockStyle.Fill;
            flwRight.FlowDirection = FlowDirection.RightToLeft;
            flwRight.Location = new Point(0, 0);
            flwRight.Name = "flwRight";
            flwRight.Padding = new Padding(0, 7, 0, 0);
            flwRight.Size = new Size(407, 48);
            flwRight.TabIndex = 8;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.BackColor = Color.FromArgb(30, 41, 59);
            btnFinalizarPedido.Cursor = Cursors.Hand;
            btnFinalizarPedido.FlatAppearance.BorderSize = 0;
            btnFinalizarPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnFinalizarPedido.FlatStyle = FlatStyle.Flat;
            btnFinalizarPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarPedido.ForeColor = Color.White;
            btnFinalizarPedido.Location = new Point(254, 10);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(150, 29);
            btnFinalizarPedido.TabIndex = 6;
            btnFinalizarPedido.Text = "Finalizar";
            btnFinalizarPedido.UseVisualStyleBackColor = false;
            btnFinalizarPedido.Click += btnFinalizarPedido_Click;
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.BackColor = Color.White;
            btnSalvarPedido.Cursor = Cursors.Hand;
            btnSalvarPedido.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
            btnSalvarPedido.FlatAppearance.BorderSize = 2;
            btnSalvarPedido.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnSalvarPedido.FlatStyle = FlatStyle.Flat;
            btnSalvarPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarPedido.ForeColor = Color.FromArgb(30, 41, 59);
            btnSalvarPedido.Location = new Point(98, 10);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.RightToLeft = RightToLeft.Yes;
            btnSalvarPedido.Size = new Size(150, 29);
            btnSalvarPedido.TabIndex = 5;
            btnSalvarPedido.Text = "Salvar Pedido";
            btnSalvarPedido.UseVisualStyleBackColor = false;
            btnSalvarPedido.Click += btnSalvarPedido_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.IndianRed;
            btnCancelar.Location = new Point(28, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.Yes;
            btnCancelar.Size = new Size(64, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(lblTotal);
            pnlLeft.Controls.Add(lblTxtTotal);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(487, 48);
            pnlLeft.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotal.Location = new Point(153, 8);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 32);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "R$ 0,00";
            // 
            // lblTxtTotal
            // 
            lblTxtTotal.AutoSize = true;
            lblTxtTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTxtTotal.ForeColor = Color.FromArgb(30, 41, 59);
            lblTxtTotal.Location = new Point(20, 3);
            lblTxtTotal.Name = "lblTxtTotal";
            lblTxtTotal.Size = new Size(127, 37);
            lblTxtTotal.TabIndex = 1;
            lblTxtTotal.Text = "Total =>";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvProdutos);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(13, 172);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(958, 312);
            pnlGrid.TabIndex = 3;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.BorderStyle = BorderStyle.None;
            dgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { colProduto, colQuantidade, colValorUnitario, colSubtotal, colRemover });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProdutos.Dock = DockStyle.Fill;
            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.GridColor = Color.Gainsboro;
            dgvProdutos.Location = new Point(0, 0);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(958, 312);
            dgvProdutos.TabIndex = 1;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // colProduto
            // 
            colProduto.DataPropertyName = "NomeProduto";
            colProduto.HeaderText = "Produto";
            colProduto.Name = "colProduto";
            colProduto.ReadOnly = true;
            // 
            // colQuantidade
            // 
            colQuantidade.DataPropertyName = "Quantidade";
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.Name = "colQuantidade";
            colQuantidade.ReadOnly = true;
            // 
            // colValorUnitario
            // 
            colValorUnitario.DataPropertyName = "Preco";
            colValorUnitario.HeaderText = "Valor Unit.";
            colValorUnitario.Name = "colValorUnitario";
            colValorUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.DataPropertyName = "Subtotal";
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colRemover
            // 
            colRemover.HeaderText = "Remover";
            colRemover.Name = "colRemover";
            colRemover.ReadOnly = true;
            colRemover.Text = "Remover";
            colRemover.UseColumnTextForButtonValue = true;
            // 
            // pnlAdicionarProduto
            // 
            pnlAdicionarProduto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlAdicionarProduto.Controls.Add(flpAdicionarProduto);
            pnlAdicionarProduto.Location = new Point(10, 125);
            pnlAdicionarProduto.Margin = new Padding(0);
            pnlAdicionarProduto.Name = "pnlAdicionarProduto";
            pnlAdicionarProduto.Size = new Size(964, 35);
            pnlAdicionarProduto.TabIndex = 2;
            // 
            // flpAdicionarProduto
            // 
            flpAdicionarProduto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flpAdicionarProduto.Controls.Add(lblProduto);
            flpAdicionarProduto.Controls.Add(cbProduto);
            flpAdicionarProduto.Controls.Add(lblQuantidade);
            flpAdicionarProduto.Controls.Add(nudQuantidade);
            flpAdicionarProduto.Controls.Add(btnAdicionarProduto);
            flpAdicionarProduto.Location = new Point(0, 0);
            flpAdicionarProduto.Name = "flpAdicionarProduto";
            flpAdicionarProduto.Padding = new Padding(20, 0, 0, 0);
            flpAdicionarProduto.Size = new Size(964, 35);
            flpAdicionarProduto.TabIndex = 0;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Dock = DockStyle.Fill;
            lblProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(23, 0);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(69, 35);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto:";
            lblProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbProduto
            // 
            cbProduto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProduto.FormattingEnabled = true;
            cbProduto.Location = new Point(98, 3);
            cbProduto.Name = "cbProduto";
            cbProduto.Size = new Size(607, 29);
            cbProduto.TabIndex = 1;
            cbProduto.KeyDown += cbProduto_KeyDown;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Dock = DockStyle.Fill;
            lblQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(711, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(36, 35);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Qtd";
            lblQuantidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantidade.Location = new Point(753, 3);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(35, 29);
            nudQuantidade.TabIndex = 3;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.BackColor = Color.FromArgb(30, 41, 59);
            btnAdicionarProduto.Cursor = Cursors.Hand;
            btnAdicionarProduto.FlatAppearance.BorderSize = 0;
            btnAdicionarProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnAdicionarProduto.FlatStyle = FlatStyle.Flat;
            btnAdicionarProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarProduto.ForeColor = Color.White;
            btnAdicionarProduto.Location = new Point(801, 3);
            btnAdicionarProduto.Margin = new Padding(10, 3, 3, 3);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(150, 29);
            btnAdicionarProduto.TabIndex = 4;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.UseVisualStyleBackColor = false;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // pnlPedido
            // 
            pnlPedido.Controls.Add(flowLayoutPanel1);
            pnlPedido.Dock = DockStyle.Fill;
            pnlPedido.Location = new Point(13, 66);
            pnlPedido.Name = "pnlPedido";
            pnlPedido.Size = new Size(958, 47);
            pnlPedido.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblTipoPedido);
            flowLayoutPanel1.Controls.Add(rbViagem);
            flowLayoutPanel1.Controls.Add(rbMesa);
            flowLayoutPanel1.Controls.Add(lblNumeroMesa_Comanda);
            flowLayoutPanel1.Controls.Add(cbNumero);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(958, 47);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTipoPedido
            // 
            lblTipoPedido.AutoSize = true;
            lblTipoPedido.Dock = DockStyle.Fill;
            lblTipoPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPedido.Location = new Point(20, 0);
            lblTipoPedido.Margin = new Padding(0);
            lblTipoPedido.Name = "lblTipoPedido";
            lblTipoPedido.Size = new Size(43, 36);
            lblTipoPedido.TabIndex = 1;
            lblTipoPedido.Text = "Tipo:";
            lblTipoPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbViagem
            // 
            rbViagem.AutoSize = true;
            rbViagem.Dock = DockStyle.Fill;
            rbViagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbViagem.Location = new Point(66, 3);
            rbViagem.Name = "rbViagem";
            rbViagem.Size = new Size(70, 30);
            rbViagem.TabIndex = 3;
            rbViagem.Text = "Viagem";
            rbViagem.TextAlign = ContentAlignment.MiddleCenter;
            rbViagem.UseVisualStyleBackColor = true;
            // 
            // rbMesa
            // 
            rbMesa.AutoSize = true;
            rbMesa.Dock = DockStyle.Fill;
            rbMesa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMesa.Location = new Point(142, 3);
            rbMesa.Name = "rbMesa";
            rbMesa.Size = new Size(58, 30);
            rbMesa.TabIndex = 2;
            rbMesa.Text = "Mesa";
            rbMesa.TextAlign = ContentAlignment.MiddleCenter;
            rbMesa.UseVisualStyleBackColor = true;
            // 
            // lblNumeroMesa_Comanda
            // 
            lblNumeroMesa_Comanda.AutoSize = true;
            lblNumeroMesa_Comanda.Dock = DockStyle.Fill;
            lblNumeroMesa_Comanda.Location = new Point(206, 0);
            lblNumeroMesa_Comanda.Name = "lblNumeroMesa_Comanda";
            lblNumeroMesa_Comanda.Padding = new Padding(20, 0, 0, 0);
            lblNumeroMesa_Comanda.Size = new Size(57, 36);
            lblNumeroMesa_Comanda.TabIndex = 4;
            lblNumeroMesa_Comanda.Text = "Num.";
            lblNumeroMesa_Comanda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbNumero
            // 
            cbNumero.FormattingEnabled = true;
            cbNumero.Location = new Point(286, 10);
            cbNumero.Margin = new Padding(20, 10, 3, 3);
            cbNumero.Name = "cbNumero";
            cbNumero.Size = new Size(79, 23);
            cbNumero.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlHeaderRigth);
            pnlHeader.Controls.Add(pnlHeaderLeft);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(13, 13);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 47);
            pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderRigth
            // 
            pnlHeaderRigth.Controls.Add(lblNumeroPedido);
            pnlHeaderRigth.Dock = DockStyle.Fill;
            pnlHeaderRigth.Location = new Point(765, 0);
            pnlHeaderRigth.Margin = new Padding(0);
            pnlHeaderRigth.Name = "pnlHeaderRigth";
            pnlHeaderRigth.Padding = new Padding(20);
            pnlHeaderRigth.Size = new Size(193, 47);
            pnlHeaderRigth.TabIndex = 2;
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.AutoSize = true;
            lblNumeroPedido.Dock = DockStyle.Right;
            lblNumeroPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroPedido.Location = new Point(173, 20);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(0, 21);
            lblNumeroPedido.TabIndex = 0;
            // 
            // pnlHeaderLeft
            // 
            pnlHeaderLeft.Controls.Add(lblTitulo);
            pnlHeaderLeft.Dock = DockStyle.Left;
            pnlHeaderLeft.Location = new Point(0, 0);
            pnlHeaderLeft.Margin = new Padding(0, 3, 3, 3);
            pnlHeaderLeft.Name = "pnlHeaderLeft";
            pnlHeaderLeft.Padding = new Padding(20, 10, 0, 10);
            pnlHeaderLeft.Size = new Size(765, 47);
            pnlHeaderLeft.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(93, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Pedido";
            // 
            // tlpUcPedidos
            // 
            tlpUcPedidos.ColumnCount = 1;
            tlpUcPedidos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUcPedidos.Controls.Add(pnlHeader, 0, 0);
            tlpUcPedidos.Controls.Add(pnlPedido, 0, 1);
            tlpUcPedidos.Controls.Add(pnlAdicionarProduto, 0, 2);
            tlpUcPedidos.Controls.Add(pnlGrid, 0, 3);
            tlpUcPedidos.Controls.Add(pnlFooter, 0, 4);
            tlpUcPedidos.Dock = DockStyle.Fill;
            tlpUcPedidos.Location = new Point(0, 0);
            tlpUcPedidos.Name = "tlpUcPedidos";
            tlpUcPedidos.Padding = new Padding(10);
            tlpUcPedidos.RowCount = 5;
            tlpUcPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpUcPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpUcPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpUcPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpUcPedidos.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpUcPedidos.Size = new Size(984, 551);
            tlpUcPedidos.TabIndex = 0;
            // 
            // UcPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpUcPedidos);
            Name = "UcPedido";
            Size = new Size(984, 551);
            pnlFooter.ResumeLayout(false);
            pnlRigth.ResumeLayout(false);
            flwRight.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            pnlAdicionarProduto.ResumeLayout(false);
            flpAdicionarProduto.ResumeLayout(false);
            flpAdicionarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            pnlPedido.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeaderRigth.ResumeLayout(false);
            pnlHeaderRigth.PerformLayout();
            pnlHeaderLeft.ResumeLayout(false);
            pnlHeaderLeft.PerformLayout();
            tlpUcPedidos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFooter;
        private Panel pnlRigth;
        private Button btnFinalizarPedido;
        private Button btnSalvarPedido;
        private Panel pnlLeft;
        private Label lblTotal;
        private Label lblTxtTotal;
        private Panel pnlGrid;
        private Panel pnlAdicionarProduto;
        private FlowLayoutPanel flpAdicionarProduto;
        private Label lblProduto;
        private ComboBox cbProduto;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private Button btnAdicionarProduto;
        private Panel pnlPedido;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTipoPedido;
        private RadioButton rbViagem;
        private RadioButton rbMesa;
        private ComboBox cbNumero;
        private Panel pnlHeader;
        private Panel pnlHeaderRigth;
        private Label lblNumeroPedido;
        private Panel pnlHeaderLeft;
        private Label lblTitulo;
        private TableLayoutPanel tlpUcPedidos;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn colProduto;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colValorUnitario;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colRemover;
        private Label lblNumeroMesa_Comanda;
        private Button btnCancelar;
        private FlowLayoutPanel flwRight;
    }
}
