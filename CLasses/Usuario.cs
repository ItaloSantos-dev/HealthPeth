using HealthPetApp.Database;
using HealthPetApp.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPetApp.CLasses
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private string sobrenome;
        private string cpf;
        private string email;
        private string senha;
        private string endereco;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        Conexao conexao = new Conexao();

        private void GuardarSession(MySqlDataReader dados)
        {
            UsuarioLogado.Id = (int)dados["id"];
            UsuarioLogado.Nome = dados["nome"].ToString();
            UsuarioLogado.Sobrenome = dados["sobrenome"].ToString();
            UsuarioLogado.Cpf = dados["cpf"].ToString();
            UsuarioLogado.Email = dados["email"].ToString();
            UsuarioLogado.Senha = dados["senha"].ToString();
            UsuarioLogado.Endereco = dados["endereco"].ToString();
            UsuarioLogado.Telefone = dados["telefone"].ToString();

        }

        public void ValidarLogin(string _email, string _senha, Form _telaAnterior)
        {
            var con = conexao.AbrirConexao();
            string SELECT = "SELECT *FROM usuarios WHERE email = @email";
            MySqlCommand cmd = new MySqlCommand(SELECT, con);
            cmd.Parameters.AddWithValue("@email", _email);
            MySqlDataReader leituraLinha = cmd.ExecuteReader();
            if (leituraLinha.HasRows)
            {
                leituraLinha.Read();
                if (leituraLinha["senha"].ToString() == _senha)
                {
                    GuardarSession(leituraLinha);
                    Home home = new Home();
                    _telaAnterior.Owner = home;
                    _telaAnterior.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }

            }
            else
            {
                MessageBox.Show("Email inválido");
            }

        }





    }
}
