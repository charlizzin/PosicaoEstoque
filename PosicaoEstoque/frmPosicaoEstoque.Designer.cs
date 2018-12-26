namespace PosicaoEstoque
{
    partial class frmPosicaoEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.dGVPosicaoEstoque = new System.Windows.Forms.DataGridView();
            this.tbCodProd = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lbDesc = new System.Windows.Forms.Label();
            this.tbNegMatriz = new System.Windows.Forms.TextBox();
            this.tbNegVilaIsa = new System.Windows.Forms.TextBox();
            this.tbNegCimento = new System.Windows.Forms.TextBox();
            this.tbNegCedis = new System.Windows.Forms.TextBox();
            this.tbNegGeral = new System.Windows.Forms.TextBox();
            this.tbValorEstoque = new System.Windows.Forms.TextBox();
            this.lbVlrEstoque = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vilaisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOCUST0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPosicaoEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(63, 11);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(58, 16);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Codigo :";
            // 
            // dGVPosicaoEstoque
            // 
            this.dGVPosicaoEstoque.AllowUserToAddRows = false;
            this.dGVPosicaoEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dGVPosicaoEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPosicaoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVPosicaoEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPosicaoEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.un,
            this.Matriz,
            this.vilaisa,
            this.cimento,
            this.cedis,
            this.geral,
            this.PRECOCUST0,
            this.VLRESTOQUE});
            this.dGVPosicaoEstoque.Location = new System.Drawing.Point(12, 40);
            this.dGVPosicaoEstoque.Name = "dGVPosicaoEstoque";
            this.dGVPosicaoEstoque.ReadOnly = true;
            this.dGVPosicaoEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPosicaoEstoque.Size = new System.Drawing.Size(1019, 550);
            this.dGVPosicaoEstoque.TabIndex = 1;
            // 
            // tbCodProd
            // 
            this.tbCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodProd.Location = new System.Drawing.Point(127, 8);
            this.tbCodProd.MaxLength = 6;
            this.tbCodProd.Name = "tbCodProd";
            this.tbCodProd.Size = new System.Drawing.Size(100, 22);
            this.tbCodProd.TabIndex = 0;
            this.tbCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCodProd.Click += new System.EventHandler(this.tbCodProd_Click);
            this.tbCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodProd_KeyPress);
            // 
            // tbDesc
            // 
            this.tbDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(315, 9);
            this.tbDesc.MaxLength = 50;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(327, 22);
            this.tbDesc.TabIndex = 1;
            this.tbDesc.Click += new System.EventHandler(this.tbDesc_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(657, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 25);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Pesquisar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(801, 7);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 25);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(924, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 25);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(12, 9);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(45, 23);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(233, 12);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(76, 16);
            this.lbDesc.TabIndex = 9;
            this.lbDesc.Text = "Descrição :";
            // 
            // tbNegMatriz
            // 
            this.tbNegMatriz.Enabled = false;
            this.tbNegMatriz.Location = new System.Drawing.Point(544, 597);
            this.tbNegMatriz.Name = "tbNegMatriz";
            this.tbNegMatriz.Size = new System.Drawing.Size(58, 20);
            this.tbNegMatriz.TabIndex = 12;
            this.tbNegMatriz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNegVilaIsa
            // 
            this.tbNegVilaIsa.Enabled = false;
            this.tbNegVilaIsa.Location = new System.Drawing.Point(641, 597);
            this.tbNegVilaIsa.Name = "tbNegVilaIsa";
            this.tbNegVilaIsa.Size = new System.Drawing.Size(58, 20);
            this.tbNegVilaIsa.TabIndex = 14;
            this.tbNegVilaIsa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNegCimento
            // 
            this.tbNegCimento.Enabled = false;
            this.tbNegCimento.Location = new System.Drawing.Point(747, 597);
            this.tbNegCimento.Name = "tbNegCimento";
            this.tbNegCimento.Size = new System.Drawing.Size(58, 20);
            this.tbNegCimento.TabIndex = 16;
            this.tbNegCimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNegCedis
            // 
            this.tbNegCedis.Enabled = false;
            this.tbNegCedis.Location = new System.Drawing.Point(845, 597);
            this.tbNegCedis.Name = "tbNegCedis";
            this.tbNegCedis.Size = new System.Drawing.Size(58, 20);
            this.tbNegCedis.TabIndex = 18;
            this.tbNegCedis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNegGeral
            // 
            this.tbNegGeral.Enabled = false;
            this.tbNegGeral.Location = new System.Drawing.Point(948, 597);
            this.tbNegGeral.Name = "tbNegGeral";
            this.tbNegGeral.Size = new System.Drawing.Size(58, 20);
            this.tbNegGeral.TabIndex = 20;
            this.tbNegGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbValorEstoque
            // 
            this.tbValorEstoque.Enabled = false;
            this.tbValorEstoque.Location = new System.Drawing.Point(209, 598);
            this.tbValorEstoque.Name = "tbValorEstoque";
            this.tbValorEstoque.Size = new System.Drawing.Size(100, 20);
            this.tbValorEstoque.TabIndex = 21;
            this.tbValorEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbVlrEstoque
            // 
            this.lbVlrEstoque.AutoSize = true;
            this.lbVlrEstoque.Location = new System.Drawing.Point(114, 601);
            this.lbVlrEstoque.Name = "lbVlrEstoque";
            this.lbVlrEstoque.Size = new System.Drawing.Size(91, 13);
            this.lbVlrEstoque.TabIndex = 22;
            this.lbVlrEstoque.Text = "Valor de Estoque:";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CODIGO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MaxInputLength = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "DESCRICAO";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descricao.Frozen = true;
            this.Descricao.HeaderText = "DESCRICAO";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 330;
            // 
            // un
            // 
            this.un.DataPropertyName = "UN";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.un.DefaultCellStyle = dataGridViewCellStyle4;
            this.un.HeaderText = "UN";
            this.un.Name = "un";
            this.un.ReadOnly = true;
            this.un.Width = 60;
            // 
            // Matriz
            // 
            this.Matriz.DataPropertyName = "MATRIZ";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.Matriz.DefaultCellStyle = dataGridViewCellStyle5;
            this.Matriz.HeaderText = "MATRIZ";
            this.Matriz.MaxInputLength = 10;
            this.Matriz.Name = "Matriz";
            this.Matriz.ReadOnly = true;
            // 
            // vilaisa
            // 
            this.vilaisa.DataPropertyName = "VILAISA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N3";
            this.vilaisa.DefaultCellStyle = dataGridViewCellStyle6;
            this.vilaisa.HeaderText = "VILA ISA";
            this.vilaisa.MaxInputLength = 10;
            this.vilaisa.Name = "vilaisa";
            this.vilaisa.ReadOnly = true;
            // 
            // cimento
            // 
            this.cimento.DataPropertyName = "CIMENTO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "N3";
            this.cimento.DefaultCellStyle = dataGridViewCellStyle7;
            this.cimento.HeaderText = "CIMENTO";
            this.cimento.MaxInputLength = 10;
            this.cimento.Name = "cimento";
            this.cimento.ReadOnly = true;
            // 
            // cedis
            // 
            this.cedis.DataPropertyName = "CEDIS";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "N3";
            this.cedis.DefaultCellStyle = dataGridViewCellStyle8;
            this.cedis.HeaderText = "CEDIS";
            this.cedis.MaxInputLength = 10;
            this.cedis.Name = "cedis";
            this.cedis.ReadOnly = true;
            // 
            // geral
            // 
            this.geral.DataPropertyName = "GERAL";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "N3";
            this.geral.DefaultCellStyle = dataGridViewCellStyle9;
            this.geral.HeaderText = "GERAL";
            this.geral.MaxInputLength = 10;
            this.geral.Name = "geral";
            this.geral.ReadOnly = true;
            // 
            // PRECOCUST0
            // 
            this.PRECOCUST0.DataPropertyName = "PRECOCUSTO";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle10.Format = "C3";
            dataGridViewCellStyle10.NullValue = null;
            this.PRECOCUST0.DefaultCellStyle = dataGridViewCellStyle10;
            this.PRECOCUST0.HeaderText = "PRECO DE CUSTO";
            this.PRECOCUST0.MaxInputLength = 10;
            this.PRECOCUST0.Name = "PRECOCUST0";
            this.PRECOCUST0.ReadOnly = true;
            this.PRECOCUST0.Width = 130;
            // 
            // VLRESTOQUE
            // 
            this.VLRESTOQUE.DataPropertyName = "VALORESTOQUE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "C3";
            dataGridViewCellStyle11.NullValue = null;
            this.VLRESTOQUE.DefaultCellStyle = dataGridViewCellStyle11;
            this.VLRESTOQUE.HeaderText = "VALOR ESTOQUE";
            this.VLRESTOQUE.MaxInputLength = 15;
            this.VLRESTOQUE.Name = "VLRESTOQUE";
            this.VLRESTOQUE.ReadOnly = true;
            this.VLRESTOQUE.Width = 130;
            // 
            // frmPosicaoEstoque
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1056, 622);
            this.Controls.Add(this.lbVlrEstoque);
            this.Controls.Add(this.tbValorEstoque);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbCodProd);
            this.Controls.Add(this.dGVPosicaoEstoque);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbNegGeral);
            this.Controls.Add(this.tbNegCedis);
            this.Controls.Add(this.tbNegCimento);
            this.Controls.Add(this.tbNegVilaIsa);
            this.Controls.Add(this.tbNegMatriz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPosicaoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posicao Estoque";
            this.Load += new System.EventHandler(this.frmPosicaoEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPosicaoEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.DataGridView dGVPosicaoEstoque;
        private System.Windows.Forms.TextBox tbCodProd;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox tbNegMatriz;
        private System.Windows.Forms.TextBox tbNegVilaIsa;
        private System.Windows.Forms.TextBox tbNegCimento;
        private System.Windows.Forms.TextBox tbNegCedis;
        private System.Windows.Forms.TextBox tbNegGeral;
        private System.Windows.Forms.TextBox tbValorEstoque;
        private System.Windows.Forms.Label lbVlrEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn un;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn vilaisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedis;
        private System.Windows.Forms.DataGridViewTextBoxColumn geral;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOCUST0;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRESTOQUE;
    }
}