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
            btnNovoPedido = new Button();
            lblTitulo = new Label();
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
            btnNovoPedido.Location = new Point(417, 261);
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
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 32);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Comandas";
            // 
            // UcComandas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitulo);
            Controls.Add(btnNovoPedido);
            Name = "UcComandas";
            Size = new Size(984, 551);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoPedido;
        private Label lblTitulo;
    }
}
