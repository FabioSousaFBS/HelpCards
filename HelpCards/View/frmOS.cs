using HelpCards.Controles;
using HelpCards.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpCards
{
    public partial class frmOS : Form
    {
        public bool bAdicionar = false;

        public static int IdAux { get; set; }

        private Contexto contexto;

        public frmOS()
        {
            InitializeComponent();
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            EstadoComandos(EnumEstadoComandos.Atualizar);

            contexto = new Contexto();

            CarregarDados();
            CriarDataBinding();            

            bdSourceOS.MoveFirst();
            
        }
       

        #region FUNÇÕES/MÉTODOS

        private void ClearFields()
        {
            txtId.Text = string.Empty;
            txtProvedor.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtSituacao.Text = string.Empty;
            txtProblema.Text = string.Empty;
            txtSolucao.Text = string.Empty;
        }
        
        private void EstadoComandos(EnumEstadoComandos estado)
        {

            switch (estado)
            {
                case EnumEstadoComandos.Adicionar:
                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = false;
                    break;

                case EnumEstadoComandos.Atualizar:
                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = true;
                    break;

            }

        }

        private void CriarDataBinding()
        {
            txtId.DataBindings.Add("Text", bdSourceOS, "Id");
            txtMunicipio.DataBindings.Add("Text", bdSourceOS, "Municipio");
            txtProblema.DataBindings.Add("Text", bdSourceOS, "Problema");
            txtProvedor.DataBindings.Add("Text", bdSourceOS, "Provedor");
            txtSituacao.DataBindings.Add("Text", bdSourceOS, "Situacao");
            txtSolucao.DataBindings.Add("Text", bdSourceOS, "Solucao");
        }

        private void CarregarDados()
        {
            try
            {                

                IList<OrdemServico> ordemServicos = contexto.OrdemServicos.ToList();
                bdSourceOS.DataSource = ordemServicos;

                bdNavigationOS.BindingSource = bdSourceOS;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao carregar os dados.");
            }
        }

        private void CarregarDados(int id)
        {
            try
            {

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao carregar os dados.");
            }
        }

        #endregion

        #region CONTROLES

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Form frmPesquisar = new frmPesquisarOS();
            frmPesquisar.ShowDialog();

            if (frmPesquisar.DialogResult == DialogResult.OK)
            {
                var obj = bdSourceOS.List.OfType<OrdemServico>().ToList().Find(f => f.Id == IdAux);
                var posicao = bdSourceOS.IndexOf(obj);
                bdSourceOS.Position = posicao;
            }

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            EstadoComandos(EnumEstadoComandos.Atualizar);
            bAdicionar = true;
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            using (var contexto = new Contexto())
            {
                var ordemServico = new OrdemServico();
                ordemServico.Municipio = txtMunicipio.Text;
                ordemServico.Problema = txtProblema.Text;
                ordemServico.Provedor = txtProvedor.Text;
                ordemServico.Situacao = txtSituacao.Text;
                ordemServico.Solucao = txtSolucao.Text;
                ordemServico.Id = Convert.ToInt32(txtId.Text.Trim());

                contexto.OrdemServicos.Remove(ordemServico);
                contexto.SaveChanges();

                if (bdSourceOS.Count > 0)
                    EstadoComandos(EnumEstadoComandos.Atualizar);
                else
                    EstadoComandos(EnumEstadoComandos.Adicionar);

                ClearFields();

            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMunicipio.Text))
            {
                MessageBox.Show("Informe o município!");
                txtMunicipio.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProvedor.Text))
            {
                MessageBox.Show("Informe um Provedor!");
                txtProvedor.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProblema.Text))
            {
                MessageBox.Show("Informe a descrição do problema!");
                txtProblema.Focus();
                return;
            }

            using (var contexto = new Contexto())
            {
                if (bAdicionar)
                {
                    var ordemServico = new OrdemServico();
                    ordemServico.Municipio = txtMunicipio.Text;
                    ordemServico.Problema = txtProblema.Text;
                    ordemServico.Provedor = txtProvedor.Text;
                    ordemServico.Situacao = txtSituacao.Text;
                    ordemServico.Solucao = txtSolucao.Text;
                    ordemServico.DataAbertura = DateTime.Now;

                    bdSourceOS.EndEdit();
                    contexto.OrdemServicos.Add(ordemServico);
                    contexto.SaveChanges();

                    bAdicionar = false;
                    bdSourceOS.MoveLast();

                    MessageBox.Show("Registro inserido com sucesso!");
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtId.Text))
                    {
                        var ordemServico = new OrdemServico();
                        ordemServico.Municipio = txtMunicipio.Text;
                        ordemServico.Problema = txtProblema.Text;
                        ordemServico.Provedor = txtProvedor.Text;
                        ordemServico.Situacao = txtSituacao.Text;
                        ordemServico.Solucao = txtSolucao.Text;
                        ordemServico.Id = Convert.ToInt32(txtId.Text.Trim());

                        bdSourceOS.EndEdit();
                        contexto.OrdemServicos.Update(ordemServico);
                        contexto.SaveChanges();
                        bdSourceOS.ResetBindings(false);
                        MessageBox.Show("Registro atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Id não informado!");
                        txtId.Focus();
                        return;
                    }
                }

                EstadoComandos(EnumEstadoComandos.Adicionar);
                ClearFields();
            }
        }

        #endregion


    }
}
