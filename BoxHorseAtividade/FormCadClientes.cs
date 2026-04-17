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
    public partial class FormCadClientes : Form
    {
        public FormCadClientes()
        {
            InitializeComponent();
        }

        private void FormCadClientes_Load(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text;
            string telefoneCliente = mtbNumeroTelefone.Text;
            string nomePet = txtNomePet.Text;

        }

    }
}