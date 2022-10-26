using System;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "unip")
            {
                if (textBox_nome.Text == "adm")
                {
                    if (textBox_cpf.Text=="0") {
                        this.Visible = false;
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    } 
                    else
                    {
                        MessageBox.Show("CPF INCORRETO");
                    }
                }
                else
                {
                    MessageBox.Show("NOME NÃO EXISTE");
                }
            }
            else
            {
                MessageBox.Show("ID INCORRETO");
            }
        }
    }
}
