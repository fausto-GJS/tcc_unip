using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace Dashboard
{
    public partial class Dashboard : Form
    {
        string http;
        string status;
        string serialPort;
        bool catraca = false;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void atualizar_com()
        {
            int i;
            bool quant;
            i = 0;
            quant = false;

            if (select_comunicacaoSerial.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (select_comunicacaoSerial.Items[i++].Equals(s) == false)
                    {
                        quant = true;
                    }
                }
            }
            else
            {
                quant = true;
            }
            if (quant == false)
            {
                return;
            }
            select_comunicacaoSerial.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                select_comunicacaoSerial.Items.Add(s);
            }
            select_comunicacaoSerial.SelectedIndex = 0;
        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {   
                try
                {
                    if (btn_conectar.Text == "CONECTAR")
                    {
                       serialPort = serialPort1.PortName = select_comunicacaoSerial.Items[select_comunicacaoSerial.SelectedIndex].ToString();
                        serialPort1.Open();
                        status_comunicacaoSerial.Text = "ONLINE";
                        status_comunicacaoSerial.ForeColor = Color.Green;
                        btn_conectar.Text = "DESCONECTAR";
                        btn_conectar.BackColor = Color.Red;
                        btn_conectar.ForeColor = Color.White;
                        Task.Delay(30000);
                        buscaIp.Enabled = true;

                }
                else if (btn_conectar.Text == "DESCONECTAR")
                {
                    serialPort1.Close();
                    status_comunicacaoSerial.Text = "OFFLINE";
                    status_comunicacaoSerial.ForeColor = Color.Red;
                    btn_conectar.Text = "CONECTAR";
                    btn_conectar.BackColor = Color.SpringGreen;
                    btn_conectar.ForeColor = Color.Black;
                    IP.Text = "000.000.00.00";
                    buscaIp.Enabled = false;
                }
            }
                catch
                {
                    status_comunicacaoSerial.Text = "ERROR";
                    status_comunicacaoSerial.ForeColor = Color.Red;
                    IP.Text = "Não foi possivel conectar nesta PORT tente outra";
                    Task.Delay(10000);
                    status_comunicacaoSerial.Text = "OFFLINE";
                    serialPort1.Close();
                    IP.Text = "000.000.00.00";
                    buscaIp.Enabled = false;
            }
            }
        private void  timerCheckSerial_Tick(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {
                atualizar_com();
            }
            if (serialPort1.IsOpen && catraca )
            {
            status = serialPort1.ReadLine();
                 status_catraca.Text = "";
                 status_catraca.Text = status;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WEB("http://"+IP.Text);
        }
        private void WEB(string link)
        {
            System.Diagnostics.Process.Start(link);
        }

        public void BuscaIP()
        {
            int i = 0;
            while (i < 10)
            {
                serialPort1.Write("rede");
                http = serialPort1.ReadExisting();

                if (http == "CLOSED")
                {
                    i = 0;
                }
                else
                {
                    string tratamento = http.Replace("CLOSED", "");
                    IP.Text = tratamento;
                    if (IP.Text.Length > 4)
                    {
                        linkLabel.Visible = true;
                        buscaIp.Enabled = false;
                        btnStatus.Visible = true;
                        btnStatus.Enabled = true;
                        btn_novoCadastro.Enabled = true;
                        i = 11;
                    }
                    i++;
                }
            }
        }
    

    private void BuscarIP_Click(object sender, EventArgs e)
    {
            BuscaIP();
    }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            catraca = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }

        private void btn_novoCadastro_Click(object sender, EventArgs e)
        {
            Cadastro_acesso cadastro = new Cadastro_acesso();
            cadastro.Show();
        }

      
    }
}
