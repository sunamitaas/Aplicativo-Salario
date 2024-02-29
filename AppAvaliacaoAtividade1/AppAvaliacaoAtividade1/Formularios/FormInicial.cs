using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAvaliacaoAtividade1.Formularios
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void Form_atvidade1_Load(object sender, EventArgs e)
        {

        }

        private void cbTipoCargo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            int tipoCargo = cbTipoCargo.SelectedIndex;

            switch (tipoCargo)
            {
                case 0: // VENDEDOR JUNIOR
                    {
                        
                        FormJunior form = new FormJunior();
                        form.ShowDialog();
                        

                        break;
                    }
                case 1: // VENDEDOR PADRAO
                    {
                        
                        FormPadrao form = new FormPadrao();
                        form.ShowDialog();

                        break;
                    }

                case 2: // VENDEDOR MASTER
                    {      

                        FormVendedorMaster form = new FormVendedorMaster();
                        form.ShowDialog();

                        break;
                    }

                case 3: // SUPERVISOR DE VENDAS
                    {

                        FormSupervisorVendas form = new FormSupervisorVendas();
                        form.ShowDialog();

                        break;
                    }

                case 4: // GERENTE
                    {
                        
                        FormGerente form = new FormGerente();
                        form.ShowDialog();

                        break;
                    }

                default:
                    {
                        MessageBox.Show("SELECIONE UM CARGO Por Favor", "CALCULO - COMISSOES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    }

            } // fim da estrutura switch
        }
    }
}
