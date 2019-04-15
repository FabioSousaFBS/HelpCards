namespace HelpCards.View
{
    partial class frmPesquisarOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescSolucao = new System.Windows.Forms.TextBox();
            this.txtDescProblema = new System.Windows.Forms.TextBox();
            this.txtProvedor = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Município = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescSolucao);
            this.groupBox1.Controls.Add(this.txtDescProblema);
            this.groupBox1.Controls.Add(this.txtProvedor);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar OS";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(673, 96);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(97, 26);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição da solução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição do problema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Município";
            // 
            // txtDescSolucao
            // 
            this.txtDescSolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescSolucao.Location = new System.Drawing.Point(216, 99);
            this.txtDescSolucao.Name = "txtDescSolucao";
            this.txtDescSolucao.Size = new System.Drawing.Size(447, 23);
            this.txtDescSolucao.TabIndex = 3;
            // 
            // txtDescProblema
            // 
            this.txtDescProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProblema.Location = new System.Drawing.Point(216, 48);
            this.txtDescProblema.Name = "txtDescProblema";
            this.txtDescProblema.Size = new System.Drawing.Size(447, 23);
            this.txtDescProblema.TabIndex = 1;
            // 
            // txtProvedor
            // 
            this.txtProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvedor.Location = new System.Drawing.Point(6, 99);
            this.txtProvedor.Name = "txtProvedor";
            this.txtProvedor.Size = new System.Drawing.Size(171, 23);
            this.txtProvedor.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(7, 48);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(171, 23);
            this.txtMunicipio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvResultado);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToOrderColumns = true;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Município,
            this.Provedor,
            this.Situacao,
            this.Problema,
            this.Solucao,
            this.DataAbertura});
            this.dgvResultado.Location = new System.Drawing.Point(6, 19);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(764, 231);
            this.dgvResultado.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Município
            // 
            this.Município.DataPropertyName = "Municipio";
            this.Município.HeaderText = "Municipio";
            this.Município.Name = "Município";
            this.Município.ReadOnly = true;
            this.Município.Width = 150;
            // 
            // Provedor
            // 
            this.Provedor.DataPropertyName = "Provedor";
            this.Provedor.HeaderText = "Provedor";
            this.Provedor.Name = "Provedor";
            this.Provedor.ReadOnly = true;
            this.Provedor.Width = 150;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 200;
            // 
            // Problema
            // 
            this.Problema.DataPropertyName = "Problema";
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.ReadOnly = true;
            this.Problema.Width = 300;
            // 
            // Solucao
            // 
            this.Solucao.DataPropertyName = "Solucao";
            this.Solucao.HeaderText = "Solução";
            this.Solucao.Name = "Solucao";
            this.Solucao.ReadOnly = true;
            this.Solucao.Width = 300;
            // 
            // DataAbertura
            // 
            this.DataAbertura.DataPropertyName = "DataAbertura";
            this.DataAbertura.HeaderText = "Data de Abertura";
            this.DataAbertura.Name = "DataAbertura";
            this.DataAbertura.ReadOnly = true;
            this.DataAbertura.Width = 80;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(713, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "OK";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmPesquisarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar OS";
            this.Load += new System.EventHandler(this.frmPesquisarOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProvedor;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescSolucao;
        private System.Windows.Forms.TextBox txtDescProblema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Município;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbertura;
    }
}