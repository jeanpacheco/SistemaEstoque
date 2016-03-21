using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacao;

namespace Estoque
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            ListarBicicletas();
        }

        private void ListarBicicletas()
        {
            BicicletaService bicicleta = new BicicletaService();
            gvBicicletas.DataSource = bicicleta.Listar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {        
            frmAdicionar frm = new frmAdicionar();
            frm.ShowDialog();
            ListarBicicletas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (gvBicicletas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Você deve selecionar uma linha.");
            }
            else
            {
                frmAtualizar frm = new frmAtualizar(this);
                frm.ShowDialog();
                ListarBicicletas();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gvBicicletas.SelectedRows.Count != 1)
            {
                MessageBox.Show("Você deve selecionar uma linha.");
            }
            else
            {
                frmExcluir frm = new frmExcluir(this);
                frm.ShowDialog();
                ListarBicicletas();
            }
        }
    }
}
