    using System;
    using System.Data;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    namespace Dashboard
    {
        public partial class Cadastro_acesso : Form
        {
            bool atualizar = false;
            MySqlConnection Conexao;
            public Cadastro_acesso()
            {
                InitializeComponent();
            }

            private void btn_registrar_Click(object sender, EventArgs e)
            {
                if (atualizar) 
                {
                    try {
                        string data = "datasource=localhost;username=root;password=;database=db_user";

                        Conexao = new MySqlConnection(data);

                        string sql = "update usuario set nome = ? ,rg = ? , cpf = ? where id = ?";

                        MySqlCommand comando = new MySqlCommand(sql, Conexao);
                        Conexao.Open();
                        comando.Parameters.Clear();
                        comando.Parameters.Add("@nome", MySqlDbType.VarChar,150).Value = textBoxNome.Text;
                        comando.Parameters.Add("@rg", MySqlDbType.VarChar,9).Value = textBox_RG.Text;
                        comando.Parameters.Add("@cpf", MySqlDbType.VarChar,11).Value = textBox_CPF.Text;
                        comando.Parameters.Add("@id", MySqlDbType.VarChar,50).Value = textBoxID.Text;
                        comando.CommandType = CommandType.Text;
                        comando.ExecuteNonQuery();
                        msgSalvo.Visible = true;
                        msgSalvo.Text = "Atualizado com sucesso!";
                    }
                    catch (Exception err)
                    {
                        msgSalvo.Visible = true;
                        msgSalvo.Text = "Erro: " + err;
                    
                    }
                    finally
                    {
                        textBoxID.Text = "";
                        textBoxNome.Text = "";
                        textBox_RG.Text = "";
                        textBox_CPF.Text = "";
                        Task.Delay(20000);
                        msgSalvo.Text = "";
                        msgSalvo.Visible = false;
                    }
                }
                else
                {
                    try
                    {
                        string data = "datasource=localhost;username=root;password=;database=db_user";

                        Conexao = new MySqlConnection(data);

                        string sql = "INSERT INTO usuario (id, nome, rg, cpf) VALUES ('" + textBoxID.Text + "','" + textBoxNome.Text + "','" + textBox_RG.Text + "','" + textBox_CPF.Text + "')";

                        MySqlCommand comando = new MySqlCommand(sql, Conexao);

                        Conexao.Open();
                        comando.ExecuteReader();
                        msgSalvo.Visible = true;
                        msgSalvo.Text = "Salvo com sucesso!";

                    }
                    catch (Exception err)
                    {
                        msgSalvo.Text = "Erro: " + err;
                    }
                    finally
                    {
                        Conexao.Close();
                        textBoxID.Text = "";
                        textBoxNome.Text = "";
                        textBox_RG.Text = "";
                        textBox_CPF.Text = "";
                        Task.Delay(20000);
                        msgSalvo.Text = "";
                        msgSalvo.Visible = false;
                    }
                }
            }
            private void btn_buscar_Click(object sender, EventArgs e)
            {
                try
                {
                    string data = "datasource=localhost;username=root;password=;database=db_user";

                    Conexao = new MySqlConnection(data);

                    string sql = "select nome, rg, cpf from usuario where id = ?";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    comando.Parameters.Clear();
                    comando.Parameters.Add("@id", MySqlDbType.VarChar,50).Value = textBoxID.Text;
                    comando.CommandType = CommandType.Text;
                    Conexao.Open();
                    MySqlDataReader leitura;
                    leitura = comando.ExecuteReader();
                    leitura.Read();
                    textBoxNome.Text = leitura.GetString(0);
                    textBox_RG.Text = leitura.GetString(1);
                    textBox_CPF.Text = leitura.GetString(2);
                    atualizar = true;
                }
                catch (Exception err)
                {
                    msgSalvo.Visible = true;
                    msgSalvo.Text = "Erro: " + err;
                    Task.Delay(20000);
                    msgSalvo.Text = "";
                    msgSalvo.Visible = false;
                }
                finally
                {
                    Conexao.Close();
                }
            }
            private void btn_cancelar_Click(object sender, EventArgs e)
            {
                atualizar = false;
                this.Close();
            }
        }
    }
