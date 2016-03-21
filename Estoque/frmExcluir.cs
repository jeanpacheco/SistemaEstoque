using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Aplicacao;

namespace Estoque
{
    public partial class frmExcluir : Form
    {
        frmEstoque frmPrincipal;

        public frmExcluir(frmEstoque frm)
        {
            frmPrincipal = frm;
            InitializeComponent();
        }

        private void frmExcluir_Load(object sender, EventArgs e)
        {

            DataGridView gvBicicletas = frmPrincipal.Controls.Find("gvBicicletas", true).FirstOrDefault() as DataGridView;

            Bicicleta bicicleta = ((Bicicleta)gvBicicletas.SelectedRows[0].DataBoundItem);

            txtModelo.Text = bicicleta.Modelo;
            txtPreco.Text = Convert.ToString(bicicleta.PrecoProposto);
            txtQuantidade.Text = Convert.ToString(bicicleta.Quantidade);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridView gvBicicletas = frmPrincipal.Controls.Find("gvBicicletas", true).FirstOrDefault() as DataGridView;

            int Id = ((Bicicleta)gvBicicletas.SelectedRows[0].DataBoundItem).Id;

            BicicletaService bs = new BicicletaService();
            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Id = Id;

            bs.Excluir(bicicleta);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
