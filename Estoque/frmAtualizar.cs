using Aplicacao;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmAtualizar : Form
    {
        frmEstoque frmPrincipal;

        public frmAtualizar(frmEstoque frm)
        {
            frmPrincipal = frm;
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridView gvBicicletas = frmPrincipal.Controls.Find("gvBicicletas", true).FirstOrDefault() as DataGridView;

            int Id = ((Bicicleta)gvBicicletas.SelectedRows[0].DataBoundItem).Id;

            BicicletaService bs = new BicicletaService();
            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Id = Id;
            bicicleta.Modelo = txtModelo.Text;
            bicicleta.PrecoProposto = Convert.ToDecimal(txtPreco.Text);
            bicicleta.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            bs.Alterar(bicicleta);

            this.Close();
        }

        private void frmAtualizar_Load(object sender, EventArgs e)
        {
            DataGridView gvBicicletas = frmPrincipal.Controls.Find("gvBicicletas", true).FirstOrDefault() as DataGridView;

            Bicicleta bicicleta = ((Bicicleta)gvBicicletas.SelectedRows[0].DataBoundItem);

            txtModelo.Text = bicicleta.Modelo;
            txtPreco.Text = Convert.ToString(bicicleta.PrecoProposto);
            txtQuantidade.Text = Convert.ToString(bicicleta.Quantidade);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
