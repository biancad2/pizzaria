namespace Pizzaria.PL
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1_IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_NmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_DsPgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Adicionar,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_IdPedido,
            this.Column1_IdCliente,
            this.Column1_NmCliente,
            this.Column1_DsPgt});
            this.dgvPedidos.Location = new System.Drawing.Point(0, 68);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(501, 273);
            this.dgvPedidos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos";
            // 
            // Column1_IdPedido
            // 
            this.Column1_IdPedido.HeaderText = "Código Pedido";
            this.Column1_IdPedido.Name = "Column1_IdPedido";
            this.Column1_IdPedido.ReadOnly = true;
            // 
            // Column1_IdCliente
            // 
            this.Column1_IdCliente.HeaderText = "Código Cliente";
            this.Column1_IdCliente.Name = "Column1_IdCliente";
            this.Column1_IdCliente.ReadOnly = true;
            // 
            // Column1_NmCliente
            // 
            this.Column1_NmCliente.HeaderText = "Nome Cliente";
            this.Column1_NmCliente.Name = "Column1_NmCliente";
            this.Column1_NmCliente.ReadOnly = true;
            this.Column1_NmCliente.Width = 150;
            // 
            // Column1_DsPgt
            // 
            this.Column1_DsPgt.HeaderText = "Forma de Pagamento";
            this.Column1_DsPgt.Name = "Column1_DsPgt";
            this.Column1_DsPgt.ReadOnly = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Adicionar.Image")));
            this.btn_Adicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(56, 22);
            this.btn_Adicionar.Text = "Novo";
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton2.Text = "Excluir";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Atualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Adicionar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_NmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_DsPgt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}