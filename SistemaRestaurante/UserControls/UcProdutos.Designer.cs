namespace SistemaRestaurante.UserControls
{
    partial class UcProdutos
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
            pnlGrid = new Panel();
            dgvProdutos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProduto = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colExcluir = new DataGridViewButtonColumn();
            panelSearch = new Panel();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            pnlHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            panelHeaderLeft = new Panel();
            lblSubtituto = new Label();
            lblTitulo = new Label();
            pnlHeaderRigth = new Panel();
            btnNovoProduto = new Button();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panelSearch.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            panelHeaderLeft.SuspendLayout();
            pnlHeaderRigth.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvProdutos);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(10, 170);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(964, 371);
            pnlGrid.TabIndex = 5;
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
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { colId, colProduto, colCategoria, colPreco, colEditar, colExcluir });
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
            dgvProdutos.Size = new Size(964, 371);
            dgvProdutos.TabIndex = 0;
            // 
            // colId
            // 
            colId.FillWeight = 10F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colProduto
            // 
            colProduto.FillWeight = 30F;
            colProduto.HeaderText = "Produto";
            colProduto.Name = "colProduto";
            colProduto.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.FillWeight = 20F;
            colCategoria.HeaderText = "Categoria";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colPreco
            // 
            colPreco.FillWeight = 20F;
            colPreco.HeaderText = "Preço";
            colPreco.Name = "colPreco";
            colPreco.ReadOnly = true;
            // 
            // colEditar
            // 
            colEditar.FillWeight = 10F;
            colEditar.HeaderText = "Editar";
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            // 
            // colExcluir
            // 
            colExcluir.FillWeight = 10F;
            colExcluir.HeaderText = "Excluir";
            colExcluir.Name = "colExcluir";
            colExcluir.ReadOnly = true;
            colExcluir.Text = "Excluir";
            colExcluir.UseColumnTextForButtonValue = true;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(lblPesquisar);
            panelSearch.Controls.Add(txtPesquisar);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(10, 100);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(20);
            panelSearch.Size = new Size(964, 70);
            panelSearch.TabIndex = 4;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Dock = DockStyle.Left;
            lblPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPesquisar.Location = new Point(20, 20);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(105, 21);
            lblPesquisar.TabIndex = 1;
            lblPesquisar.Text = "🔍 Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(131, 18);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(814, 29);
            txtPesquisar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(10, 10);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(964, 90);
            pnlHeader.TabIndex = 3;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpHeader.Controls.Add(panelHeaderLeft, 0, 0);
            tlpHeader.Controls.Add(pnlHeaderRigth, 1, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpHeader.Size = new Size(964, 90);
            tlpHeader.TabIndex = 0;
            // 
            // panelHeaderLeft
            // 
            panelHeaderLeft.Controls.Add(lblSubtituto);
            panelHeaderLeft.Controls.Add(lblTitulo);
            panelHeaderLeft.Dock = DockStyle.Fill;
            panelHeaderLeft.Location = new Point(3, 3);
            panelHeaderLeft.Name = "panelHeaderLeft";
            panelHeaderLeft.Padding = new Padding(20, 10, 0, 10);
            panelHeaderLeft.Size = new Size(765, 84);
            panelHeaderLeft.TabIndex = 0;
            // 
            // lblSubtituto
            // 
            lblSubtituto.AutoSize = true;
            lblSubtituto.Dock = DockStyle.Top;
            lblSubtituto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituto.Location = new Point(20, 42);
            lblSubtituto.Name = "lblSubtituto";
            lblSubtituto.Size = new Size(350, 25);
            lblSubtituto.TabIndex = 1;
            lblSubtituto.Text = "Gerencie todos os produtos cadastrados";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Produtos";
            // 
            // pnlHeaderRigth
            // 
            pnlHeaderRigth.Controls.Add(btnNovoProduto);
            pnlHeaderRigth.Dock = DockStyle.Fill;
            pnlHeaderRigth.Location = new Point(774, 3);
            pnlHeaderRigth.Name = "pnlHeaderRigth";
            pnlHeaderRigth.Size = new Size(187, 84);
            pnlHeaderRigth.TabIndex = 1;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.BackColor = Color.FromArgb(30, 41, 59);
            btnNovoProduto.Cursor = Cursors.Hand;
            btnNovoProduto.FlatAppearance.BorderSize = 0;
            btnNovoProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnNovoProduto.FlatStyle = FlatStyle.Flat;
            btnNovoProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoProduto.ForeColor = Color.White;
            btnNovoProduto.Location = new Point(17, 23);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(150, 38);
            btnNovoProduto.TabIndex = 0;
            btnNovoProduto.Text = "Novo Produto";
            btnNovoProduto.UseVisualStyleBackColor = false;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // UcProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlGrid);
            Controls.Add(panelSearch);
            Controls.Add(pnlHeader);
            Name = "UcProdutos";
            Padding = new Padding(10);
            Size = new Size(984, 551);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            pnlHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            panelHeaderLeft.ResumeLayout(false);
            panelHeaderLeft.PerformLayout();
            pnlHeaderRigth.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGrid;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProduto;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colExcluir;
        private Panel panelSearch;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Panel pnlHeader;
        private TableLayoutPanel tlpHeader;
        private Panel panelHeaderLeft;
        private Label lblSubtituto;
        private Label lblTitulo;
        private Panel pnlHeaderRigth;
        private Button btnNovoProduto;
    }
}
