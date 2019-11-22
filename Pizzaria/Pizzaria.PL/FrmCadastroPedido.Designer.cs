namespace Pizzaria.PL
{
    partial class FrmCadastroPedido
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_IncluirProd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCartao = new System.Windows.Forms.RadioButton();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.lblEndCli = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btn_ApagarCli = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_AdcCli = new System.Windows.Forms.Button();
            this.btn_PesquisarCli = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIdPed = new System.Windows.Forms.Label();
            this.btn_Teste = new System.Windows.Forms.Button();
            this.Column1_CategoriaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_NmProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_DsProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_QtProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6_VlProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6_IdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome/Telefone:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(137, 106);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(371, 27);
            this.txtPesquisar.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btn_Salvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "Voltar";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.Image")));
            this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(58, 22);
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_CategoriaProd,
            this.Column2_IdProduto,
            this.Column3_NmProd,
            this.Column4_DsProd,
            this.Column5_QtProd,
            this.Column6_VlProd,
            this.Column6_IdItem});
            this.dgvProdutos.Location = new System.Drawing.Point(2, 21);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(611, 192);
            this.dgvProdutos.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.btn_IncluirProd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 235);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(613, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_IncluirProd
            // 
            this.btn_IncluirProd.BackColor = System.Drawing.Color.Transparent;
            this.btn_IncluirProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IncluirProd.BackgroundImage")));
            this.btn_IncluirProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_IncluirProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IncluirProd.FlatAppearance.BorderSize = 0;
            this.btn_IncluirProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_IncluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IncluirProd.Location = new System.Drawing.Point(613, 95);
            this.btn_IncluirProd.Name = "btn_IncluirProd";
            this.btn_IncluirProd.Size = new System.Drawing.Size(23, 23);
            this.btn_IncluirProd.TabIndex = 13;
            this.btn_IncluirProd.UseVisualStyleBackColor = false;
            this.btn_IncluirProd.Click += new System.EventHandler(this.btn_IncluirProd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo de pagamento:";
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(154, 283);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rdbDinheiro.TabIndex = 18;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rdbCartao
            // 
            this.rdbCartao.AutoSize = true;
            this.rdbCartao.Location = new System.Drawing.Point(224, 283);
            this.rdbCartao.Name = "rdbCartao";
            this.rdbCartao.Size = new System.Drawing.Size(56, 17);
            this.rdbCartao.TabIndex = 19;
            this.rdbCartao.TabStop = true;
            this.rdbCartao.Text = "Cartão";
            this.rdbCartao.UseVisualStyleBackColor = true;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNomeCli.Location = new System.Drawing.Point(132, 186);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(0, 16);
            this.lblNomeCli.TabIndex = 20;
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelCli.Location = new System.Drawing.Point(132, 202);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(0, 16);
            this.lblTelCli.TabIndex = 21;
            // 
            // lblEndCli
            // 
            this.lblEndCli.AutoSize = true;
            this.lblEndCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCli.Location = new System.Drawing.Point(132, 220);
            this.lblEndCli.Name = "lblEndCli";
            this.lblEndCli.Size = new System.Drawing.Size(0, 16);
            this.lblEndCli.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bairro:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(132, 236);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(0, 16);
            this.lblBairro.TabIndex = 24;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(526, 140);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            // 
            // btn_ApagarCli
            // 
            this.btn_ApagarCli.BackColor = System.Drawing.Color.Transparent;
            this.btn_ApagarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ApagarCli.BackgroundImage")));
            this.btn_ApagarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ApagarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ApagarCli.FlatAppearance.BorderSize = 0;
            this.btn_ApagarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_ApagarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ApagarCli.Location = new System.Drawing.Point(545, 108);
            this.btn_ApagarCli.Name = "btn_ApagarCli";
            this.btn_ApagarCli.Size = new System.Drawing.Size(23, 23);
            this.btn_ApagarCli.TabIndex = 16;
            this.btn_ApagarCli.UseVisualStyleBackColor = false;
            this.btn_ApagarCli.Click += new System.EventHandler(this.btn_ApagarCli_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(638, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btn_AdcCli
            // 
            this.btn_AdcCli.BackColor = System.Drawing.Color.Transparent;
            this.btn_AdcCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AdcCli.BackgroundImage")));
            this.btn_AdcCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdcCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdcCli.FlatAppearance.BorderSize = 0;
            this.btn_AdcCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_AdcCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdcCli.Location = new System.Drawing.Point(516, 108);
            this.btn_AdcCli.Name = "btn_AdcCli";
            this.btn_AdcCli.Size = new System.Drawing.Size(23, 23);
            this.btn_AdcCli.TabIndex = 5;
            this.btn_AdcCli.UseVisualStyleBackColor = false;
            this.btn_AdcCli.Click += new System.EventHandler(this.btn_AdcCli_Click);
            // 
            // btn_PesquisarCli
            // 
            this.btn_PesquisarCli.BackColor = System.Drawing.Color.White;
            this.btn_PesquisarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PesquisarCli.BackgroundImage")));
            this.btn_PesquisarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PesquisarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PesquisarCli.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PesquisarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_PesquisarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarCli.Location = new System.Drawing.Point(484, 110);
            this.btn_PesquisarCli.Name = "btn_PesquisarCli";
            this.btn_PesquisarCli.Size = new System.Drawing.Size(21, 21);
            this.btn_PesquisarCli.TabIndex = 3;
            this.btn_PesquisarCli.UseVisualStyleBackColor = false;
            this.btn_PesquisarCli.Click += new System.EventHandler(this.btn_PesquisarCli_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Id Pedido:";
            // 
            // lblIdPed
            // 
            this.lblIdPed.AutoSize = true;
            this.lblIdPed.Location = new System.Drawing.Point(134, 162);
            this.lblIdPed.Name = "lblIdPed";
            this.lblIdPed.Size = new System.Drawing.Size(0, 13);
            this.lblIdPed.TabIndex = 29;
            // 
            // btn_Teste
            // 
            this.btn_Teste.Location = new System.Drawing.Point(286, 277);
            this.btn_Teste.Name = "btn_Teste";
            this.btn_Teste.Size = new System.Drawing.Size(108, 32);
            this.btn_Teste.TabIndex = 30;
            this.btn_Teste.Text = "Cadastrar Pedido";
            this.btn_Teste.UseVisualStyleBackColor = true;
            this.btn_Teste.Click += new System.EventHandler(this.btn_Teste_Click);
            // 
            // Column1_CategoriaProd
            // 
            this.Column1_CategoriaProd.HeaderText = "Categoria";
            this.Column1_CategoriaProd.Name = "Column1_CategoriaProd";
            this.Column1_CategoriaProd.ReadOnly = true;
            // 
            // Column2_IdProduto
            // 
            this.Column2_IdProduto.HeaderText = "ID Prod";
            this.Column2_IdProduto.Name = "Column2_IdProduto";
            this.Column2_IdProduto.ReadOnly = true;
            this.Column2_IdProduto.Width = 50;
            // 
            // Column3_NmProd
            // 
            this.Column3_NmProd.HeaderText = "Nome ";
            this.Column3_NmProd.Name = "Column3_NmProd";
            this.Column3_NmProd.ReadOnly = true;
            this.Column3_NmProd.Width = 150;
            // 
            // Column4_DsProd
            // 
            this.Column4_DsProd.HeaderText = "Descrição";
            this.Column4_DsProd.Name = "Column4_DsProd";
            this.Column4_DsProd.ReadOnly = true;
            this.Column4_DsProd.Width = 150;
            // 
            // Column5_QtProd
            // 
            this.Column5_QtProd.HeaderText = "Qt";
            this.Column5_QtProd.Name = "Column5_QtProd";
            this.Column5_QtProd.ReadOnly = true;
            this.Column5_QtProd.Width = 50;
            // 
            // Column6_VlProd
            // 
            this.Column6_VlProd.HeaderText = "Valor Unitário";
            this.Column6_VlProd.Name = "Column6_VlProd";
            this.Column6_VlProd.ReadOnly = true;
            this.Column6_VlProd.Width = 65;
            // 
            // Column6_IdItem
            // 
            this.Column6_IdItem.HeaderText = "IdItem";
            this.Column6_IdItem.Name = "Column6_IdItem";
            this.Column6_IdItem.ReadOnly = true;
            this.Column6_IdItem.Visible = false;
            // 
            // FrmCadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 562);
            this.Controls.Add(this.btn_Teste);
            this.Controls.Add(this.lblIdPed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btn_ApagarCli);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEndCli);
            this.Controls.Add(this.lblTelCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.rdbCartao);
            this.Controls.Add(this.rdbDinheiro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AdcCli);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_PesquisarCli);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Name = "FrmCadastroPedido";
            this.Text = "Cadastro de pedidos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btn_PesquisarCli;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Salvar;
        private System.Windows.Forms.Button btn_AdcCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btn_IncluirProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbCartao;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblTelCli;
        private System.Windows.Forms.Label lblEndCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btn_ApagarCli;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIdPed;
        private System.Windows.Forms.Button btn_Teste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_CategoriaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_NmProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4_DsProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5_QtProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6_VlProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6_IdItem;
    }
}

