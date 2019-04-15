namespace HelpCards
{
    partial class frmOS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSolucao = new System.Windows.Forms.TextBox();
            this.bdNavigationOS = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bdSourceOS = new System.Windows.Forms.BindingSource(this.components);
            this.gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigationOS)).BeginInit();
            this.bdNavigationOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSourceOS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.btnProcurar);
            this.gbControles.Controls.Add(this.label6);
            this.gbControles.Controls.Add(this.txtProvedor);
            this.gbControles.Controls.Add(this.label5);
            this.gbControles.Controls.Add(this.txtMunicipio);
            this.gbControles.Controls.Add(this.label4);
            this.gbControles.Controls.Add(this.txtId);
            this.gbControles.Controls.Add(this.label3);
            this.gbControles.Controls.Add(this.txtSituacao);
            this.gbControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControles.Location = new System.Drawing.Point(12, 28);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(881, 117);
            this.gbControles.TabIndex = 0;
            this.gbControles.TabStop = false;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = global::HelpCards.Properties.Resources.iconfinder_edit_find_38991__3_;
            this.btnProcurar.Location = new System.Drawing.Point(115, 30);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(28, 27);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "SITUAÇÃO: ";
            // 
            // txtProvedor
            // 
            this.txtProvedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvedor.Location = new System.Drawing.Point(271, 83);
            this.txtProvedor.Name = "txtProvedor";
            this.txtProvedor.Size = new System.Drawing.Size(152, 23);
            this.txtProvedor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Provedor";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(9, 83);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(244, 23);
            this.txtMunicipio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Município";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(9, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(683, 19);
            this.txtSituacao.Multiline = true;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSituacao.Size = new System.Drawing.Size(179, 73);
            this.txtSituacao.TabIndex = 5;
            // 
            // txtProblema
            // 
            this.txtProblema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblema.Location = new System.Drawing.Point(12, 172);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProblema.Size = new System.Drawing.Size(881, 141);
            this.txtProblema.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição do Problema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solução do Problema:";
            // 
            // txtSolucao
            // 
            this.txtSolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucao.Location = new System.Drawing.Point(12, 352);
            this.txtSolucao.Multiline = true;
            this.txtSolucao.Name = "txtSolucao";
            this.txtSolucao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolucao.Size = new System.Drawing.Size(881, 157);
            this.txtSolucao.TabIndex = 7;
            // 
            // bdNavigationOS
            // 
            this.bdNavigationOS.AddNewItem = this.btnAdicionar;
            this.bdNavigationOS.CountItem = null;
            this.bdNavigationOS.DeleteItem = this.btnExcluir;
            this.bdNavigationOS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdicionar,
            this.btnExcluir,
            this.btnSalvar});
            this.bdNavigationOS.Location = new System.Drawing.Point(0, 0);
            this.bdNavigationOS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdNavigationOS.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdNavigationOS.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdNavigationOS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdNavigationOS.Name = "bdNavigationOS";
            this.bdNavigationOS.PositionItem = null;
            this.bdNavigationOS.Size = new System.Drawing.Size(910, 25);
            this.bdNavigationOS.TabIndex = 5;
            this.bdNavigationOS.Text = "bindingNavigator1";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.RightToLeftAutoMirrorImage = true;
            this.btnAdicionar.Size = new System.Drawing.Size(23, 22);
            this.btnAdicionar.Text = "Add new";
            this.btnAdicionar.ToolTipText = "Adicionar Novo";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Delete";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = global::HelpCards.Properties.Resources.iconfinder_Save_1493294;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.ToolTipText = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Pesquisar";
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 521);
            this.Controls.Add(this.bdNavigationOS);
            this.Controls.Add(this.txtSolucao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.gbControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.gbControles.ResumeLayout(false);
            this.gbControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdNavigationOS)).EndInit();
            this.bdNavigationOS.ResumeLayout(false);
            this.bdNavigationOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSourceOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSolucao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.BindingNavigator bdNavigationOS;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bdSourceOS;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

