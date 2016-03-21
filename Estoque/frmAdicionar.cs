using System;
using System.Windows.Forms;
using Aplicacao;
using Modelo;

namespace Estoque
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            BicicletaService bs = new BicicletaService();
            Bicicleta bicicleta = new Bicicleta();

            bicicleta.Modelo = txtModelo.Text;
            bicicleta.PrecoProposto = Convert.ToDecimal(txtPreco.Text);
            bicicleta.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            bs.Adicionar(bicicleta);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
