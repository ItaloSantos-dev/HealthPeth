
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HealthPetApp.Database
{
    internal class Conexao
    {
        // guardar dados do meu banco
        private string DadosBD = "SERVER=localhost; PORT=3306; DATABASE=clinica_veterinaria; UID=root; PASSWORD=1131;";

        // instancia um objeto de conexão mys passando os dados do meu bd
        

        // função com trycatch para tentar acessar a função open dentro do objeto do tipo MysqlConnection
        public MySqlConnection AbrirConexao()
        {

            try
            {
                MySqlConnection con = new MySqlConnection(DadosBD);
                con.Open();
                return con;
            }
            catch(MySqlException error)
            {
                MessageBox.Show("Erro ao realizar conexão com o banco de dados " +  error.Message);
                return null;
            }
        }
    }
}
