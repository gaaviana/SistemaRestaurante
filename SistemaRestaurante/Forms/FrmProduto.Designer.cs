namespace SistemaRestaurante.Forms
{
    partial class FrmProduto
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            pnlFooter = new Panel();
            lblNome = new Label();
            lblCategoria = new Label();
            lblPreco = new Label();
            tlpCampos = new TableLayoutPanel();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            cbCategoria = new ComboBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            tableLayoutPanel1.SuspendLayout();
            pnlFooter.SuspendLayout();
            tlpCampos.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlFooter, 0, 2);
            tableLayoutPanel1.Controls.Add(tlpCampos, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(534, 381);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(224, 38);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Cadastrar Produto";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnCancelar);
            pnlFooter.Controls.Add(btnCadastrar);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(3, 326);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(528, 52);
            pnlFooter.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Bottom;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(3, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(522, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Produto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Dock = DockStyle.Bottom;
            lblCategoria.Font = new Font("Segoe UI", 12F);
            lblCategoria.Location = new Point(3, 117);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(522, 21);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Dock = DockStyle.Bottom;
            lblPreco.Font = new Font("Segoe UI", 12F);
            lblPreco.Location = new Point(3, 209);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(522, 21);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço";
            // 
            // tlpCampos
            // 
            tlpCampos.ColumnCount = 1;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCampos.Controls.Add(lblCategoria, 0, 2);
            tlpCampos.Controls.Add(lblNome, 0, 0);
            tlpCampos.Controls.Add(lblPreco, 0, 4);
            tlpCampos.Controls.Add(txtNome, 0, 1);
            tlpCampos.Controls.Add(txtPreco, 0, 5);
            tlpCampos.Controls.Add(cbCategoria, 0, 3);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(3, 41);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 6;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpCampos.Size = new Size(528, 279);
            tlpCampos.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(522, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(3, 233);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(260, 23);
            txtPreco.TabIndex = 4;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(3, 141);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(260, 23);
            cbCategoria.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(30, 41, 59);
            btnCancelar.Location = new Point(111, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 29);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(30, 41, 59);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(86, 118, 141);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(267, 12);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(150, 29);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 381);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Panel pnlFooter;
        private Label lblNome;
        private Label lblCategoria;
        private Label lblPreco;
        private TableLayoutPanel tlpCampos;
        private TextBox txtNome;
        private TextBox txtPreco;
        private ComboBox cbCategoria;
        private Button btnCancelar;
        private Button btnCadastrar;
    }
}