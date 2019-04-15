using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpCards.View
{
    public partial class frmPesquisarOS : Form
    {
        protected Contexto _contexto;
        private IList<OrdemServico> oPesquisa;

        

        public frmPesquisarOS()
        {
            InitializeComponent();
            this._contexto = new Contexto();
        }
        
        private void frmPesquisarOS_Load(object sender, EventArgs e)
        {
            ConfiguraGrid();
        }

        private void ConfiguraGrid()
        {
            this.dgvResultado.AutoSize = true;
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            IList<OrdemServico> oPesquisa = _contexto.OrdemServicos.ToList();
            var lstResultado = new List<OrdemServico>();

            if (!String.IsNullOrEmpty(txtMunicipio.Text) || !String.IsNullOrEmpty(txtDescProblema.Text) ||
                !String.IsNullOrEmpty(txtDescSolucao.Text) || !String.IsNullOrEmpty(txtProvedor.Text)){

                lstResultado = oPesquisa.Where(o => 
                    o.Municipio.ToUpper().Contains(txtMunicipio.Text.ToUpper()) && 
                    o.Provedor.ToUpper().Contains(txtProvedor.Text.ToUpper()) &&
                    o.Problema.ToUpper().Contains(txtDescProblema.Text.ToUpper()) &&
                    o.Solucao.ToUpper().Contains(txtDescSolucao.Text.ToUpper())
                ).ToList();

                dgvResultado.DataSource = null; //Limpa o grid;
                dgvResultado.DataSource = lstResultado;
                dgvResultado.Refresh();

            }
                        
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.Rows.Count > 0)
            {
                frmOS.IdAux = Convert.ToInt32(dgvResultado.Rows[dgvResultado.CurrentRow.Index].Cells["Id"].Value);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }

            this.Dispose();
        }
    }
}
