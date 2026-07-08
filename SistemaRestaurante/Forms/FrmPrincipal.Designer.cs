namespace SistemaRestaurante
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            pnlHeaderTitulo = new Panel();
            lblTitulo = new Label();
            lblMenu = new Label();
            pnlHeaderInfos = new Panel();
            lblUser = new Label();
            pnlFooter = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlFooterLeft = new Panel();
            lblVersion = new Label();
            pnlFooterRight = new Panel();
            pnlSidebar = new Panel();
            pnlMenu = new Panel();
            flpLinks = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProdutos = new Button();
            btnComandas = new Button();
            btnCaixa = new Button();
            btnRelatorios = new Button();
            btnConfig = new Button();
            pnlConteudo = new Panel();
            pnlHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            pnlHeaderTitulo.SuspendLayout();
            pnlHeaderInfos.SuspendLayout();
            pnlFooter.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlFooterLeft.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMenu.SuspendLayout();
            flpLinks.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(tlpHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1184, 75);
            pnlHeader.TabIndex = 0;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpHeader.Controls.Add(pnlHeaderTitulo, 0, 0);
            tlpHeader.Controls.Add(pnlHeaderInfos, 1, 0);
            tlpHeader.Dock = DockStyle.Fill;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1184, 75);
            tlpHeader.TabIndex = 0;
            // 
            // pnlHeaderTitulo
            // 
            pnlHeaderTitulo.BackColor = Color.White;
            pnlHeaderTitulo.Controls.Add(lblTitulo);
            pnlHeaderTitulo.Controls.Add(lblMenu);
            pnlHeaderTitulo.Dock = DockStyle.Fill;
            pnlHeaderTitulo.Location = new Point(0, 0);
            pnlHeaderTitulo.Margin = new Padding(0);
            pnlHeaderTitulo.Name = "pnlHeaderTitulo";
            pnlHeaderTitulo.Padding = new Padding(20);
            pnlHeaderTitulo.Size = new Size(947, 75);
            pnlHeaderTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(63, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema Restaurante";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Dock = DockStyle.Left;
            lblMenu.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(20, 20);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(43, 40);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "☰";
            // 
            // pnlHeaderInfos
            // 
            pnlHeaderInfos.BackColor = Color.White;
            pnlHeaderInfos.Controls.Add(lblUser);
            pnlHeaderInfos.Dock = DockStyle.Fill;
            pnlHeaderInfos.Location = new Point(947, 0);
            pnlHeaderInfos.Margin = new Padding(0);
            pnlHeaderInfos.Name = "pnlHeaderInfos";
            pnlHeaderInfos.Padding = new Padding(30);
            pnlHeaderInfos.Size = new Size(237, 75);
            pnlHeaderInfos.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Left;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(30, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "Gabriel";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.WhiteSmoke;
            pnlFooter.Controls.Add(tableLayoutPanel1);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 626);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1184, 35);
            pnlFooter.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(pnlFooterLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlFooterRight, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1184, 35);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlFooterLeft
            // 
            pnlFooterLeft.Controls.Add(lblVersion);
            pnlFooterLeft.Dock = DockStyle.Fill;
            pnlFooterLeft.Location = new Point(10, 10);
            pnlFooterLeft.Margin = new Padding(10);
            pnlFooterLeft.Name = "pnlFooterLeft";
            pnlFooterLeft.Size = new Size(927, 15);
            pnlFooterLeft.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Dock = DockStyle.Left;
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(0, 0);
            lblVersion.Margin = new Padding(0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(137, 15);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Sistema Restaurante v1.0";
            // 
            // pnlFooterRight
            // 
            pnlFooterRight.Dock = DockStyle.Fill;
            pnlFooterRight.Location = new Point(950, 3);
            pnlFooterRight.Name = "pnlFooterRight";
            pnlFooterRight.Size = new Size(231, 29);
            pnlFooterRight.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlMenu);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 75);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 551);
            pnlSidebar.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(flpLinks);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 551);
            pnlMenu.TabIndex = 0;
            // 
            // flpLinks
            // 
            flpLinks.BackColor = Color.FromArgb(30, 41, 59);
            flpLinks.Controls.Add(btnDashboard);
            flpLinks.Controls.Add(btnProdutos);
            flpLinks.Controls.Add(btnComandas);
            flpLinks.Controls.Add(btnCaixa);
            flpLinks.Controls.Add(btnRelatorios);
            flpLinks.Controls.Add(btnConfig);
            flpLinks.Dock = DockStyle.Fill;
            flpLinks.FlowDirection = FlowDirection.TopDown;
            flpLinks.Location = new Point(0, 0);
            flpLinks.Margin = new Padding(0);
            flpLinks.Name = "flpLinks";
            flpLinks.Padding = new Padding(0, 20, 0, 20);
            flpLinks.Size = new Size(200, 551);
            flpLinks.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 30);
            btnDashboard.Margin = new Padding(0, 10, 0, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(200, 38);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            btnProdutos.Cursor = Cursors.Hand;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Location = new Point(0, 88);
            btnProdutos.Margin = new Padding(0, 10, 0, 10);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Padding = new Padding(20, 0, 0, 0);
            btnProdutos.Size = new Size(200, 38);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produto";
            btnProdutos.TextAlign = ContentAlignment.MiddleLeft;
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnComandas
            // 
            btnComandas.Cursor = Cursors.Hand;
            btnComandas.FlatAppearance.BorderSize = 0;
            btnComandas.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnComandas.FlatStyle = FlatStyle.Flat;
            btnComandas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComandas.ForeColor = Color.White;
            btnComandas.Location = new Point(0, 146);
            btnComandas.Margin = new Padding(0, 10, 0, 10);
            btnComandas.Name = "btnComandas";
            btnComandas.Padding = new Padding(20, 0, 0, 0);
            btnComandas.Size = new Size(200, 38);
            btnComandas.TabIndex = 4;
            btnComandas.Text = "Comandas";
            btnComandas.TextAlign = ContentAlignment.MiddleLeft;
            btnComandas.UseVisualStyleBackColor = true;
            btnComandas.Click += btnComandas_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.Cursor = Cursors.Hand;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.Location = new Point(0, 204);
            btnCaixa.Margin = new Padding(0, 10, 0, 10);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Padding = new Padding(20, 0, 0, 0);
            btnCaixa.Size = new Size(200, 38);
            btnCaixa.TabIndex = 5;
            btnCaixa.Text = "Caixa";
            btnCaixa.TextAlign = ContentAlignment.MiddleLeft;
            btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Cursor = Cursors.Hand;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Location = new Point(0, 262);
            btnRelatorios.Margin = new Padding(0, 10, 0, 10);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Padding = new Padding(20, 0, 0, 0);
            btnRelatorios.Size = new Size(200, 38);
            btnRelatorios.TabIndex = 6;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(0, 320);
            btnConfig.Margin = new Padding(0, 10, 0, 10);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(20, 0, 0, 0);
            btnConfig.Size = new Size(200, 38);
            btnConfig.TabIndex = 7;
            btnConfig.Text = "Config.";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(248, 250, 252);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(200, 75);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(984, 551);
            pnlConteudo.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Name = "FrmPrincipal";
            Text = "Sistema Restaurante";
            pnlHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            pnlHeaderTitulo.ResumeLayout(false);
            pnlHeaderTitulo.PerformLayout();
            pnlHeaderInfos.ResumeLayout(false);
            pnlHeaderInfos.PerformLayout();
            pnlFooter.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlFooterLeft.ResumeLayout(false);
            pnlFooterLeft.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            flpLinks.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private TableLayoutPanel tlpHeader;
        private Panel pnlHeaderTitulo;
        private Label lblTitulo;
        private Label lblMenu;
        private Panel pnlHeaderInfos;
        private Panel pnlFooter;
        private Panel pnlSidebar;
        private Panel pnlConteudo;
        private Label lblUser;
        private Panel pnlMenu;
        private FlowLayoutPanel flpLinks;
        private Button btnDashboard;
        private Button btnProdutos;
        private Button btnComandas;
        private Button btnCaixa;
        private Button btnRelatorios;
        private Button btnConfig;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlFooterLeft;
        private Label lblVersion;
        private Panel pnlFooterRight;
    }
}
