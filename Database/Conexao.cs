
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HealthPetApp.Database
{
    internal class Conexao
    {
        // guardar dados do meu banco
        public string DadosBD = "SERVER=localhost;PORT=3306;DATABASE=clinica_veterinaria;UID=root;PASSWORD=1131;";

        // função com trycatch para tentar acessar a função open dentro do objeto
        public MySqlConnection AbrirConexao()
        {
            // instancia um objeto de conexão mys passando os dados do meu bd
            var con = new MySqlConnection(DadosBD);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o Bano de dados " +  ex.Message);
                return null;
            }
        }

        




    }
}
