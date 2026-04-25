using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxHorseAtividade
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();

            BindingList<Produtos> listaProdutos = new BindingList<Produtos>
             {
                 new Produtos("Racao", 56.99m),
                 new Produtos("Tosa", 110.99m),
                 new Produtos("Banho", 116.99m)
             };

            cbNomeProdutos.DataSource = listaProdutos;
            cbNomeProdutos.DisplayMember = "Produto";
            cbNomeProdutos.ValueMember = "Valor";

            dgvVisualizarProduto.Columns.Add("Produto", "Produto");
            dgvVisualizarProduto.Columns.Add("Quantidade", "Quantidade");
            dgvVisualizarProduto.Columns.Add("Valor", "Valor Un");
            dgvVisualizarProduto.Columns.Add("Total", "Total");
        }

 
        private void numQnt_ValueChanged(object sender, EventArgs e)
        {
            numQntProduto.Minimum = 1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeProduto = cbNomeProdutos.Text;
            decimal valorProduto = (decimal)cbNomeProdutos.SelectedValue;
            int quantidade = (int)numQntProduto.Value;

            dgvVisualizarProduto.Rows.Add(nomeProduto, valorProduto, quantidade, (valorProduto * quantidade));
        }
    }
}
