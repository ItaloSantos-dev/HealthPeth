using HealthPetApp.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPetApp.CLasses
{
    internal class Veterinario
    {
        private int id;
        private string nome;
        private string sobrenome;
        private DateTime nascimento;
        private int idade;
        private string cpi;
        private string imagem;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Cpi { get => cpi; set => cpi = value; }
        public string Imagem { get => imagem; set => imagem = value; }

        public DataTable BuscarVeterinarios()
        {
            Conexao conexao = new Conexao();
            var con = conexao.AbrirConexao();
            string SELECT = "SELECT *FROM veterinarios;";
            MySqlCommand cmd = new MySqlCommand(SELECT, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable veterinarios = new DataTable();
            adaptador.Fill(veterinarios);
            return veterinarios;

        }
    }
}
