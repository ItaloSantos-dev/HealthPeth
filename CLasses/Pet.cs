using HealthPetApp.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPetApp.CLasses
{
    internal class Pet
    {
        private int id;
        private int tutor_id;
        private string apelido;
        private string especie;
        private string raca;
        private DateTime nascimento;
        private int idade;


        public int Id { get => id; set => id = value; }
        public int Tutor_id { get=> tutor_id; set => tutor_id = value; }
        public string Apelido {get => apelido; set => apelido = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raca {get => raca; set => raca = value; }
        public DateTime Nascimento {get => nascimento; set => nascimento = value; }
        public int Idade {get => idade; set => idade = value; }

        Conexao conexao = new Conexao();

        public void CadastrarPet(Form telaAtual)
        {
            var con = conexao.AbrirConexao();
            string INSERT = "INSERT INTO pets(id, tutor_id, apelido, especie, raca, nascimento, idade) VALUES (DEFAULT, @tutor_id, @apelido, @especie, @raca, @nascimento, @idade); ";
            MySqlCommand cmd = new MySqlCommand(INSERT, con);
            cmd.Parameters.AddWithValue("@tutor_id", Tutor_id);
            cmd.Parameters.AddWithValue("@apelido", Apelido);
            cmd.Parameters.AddWithValue("@especie", Especie);
            cmd.Parameters.AddWithValue("raca", Raca);
            cmd.Parameters.AddWithValue("nascimento", Nascimento.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("idade", Idade);
            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Pet cadastrado com sucesso");
                telaAtual.Close();

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o pet");

            }







        }

    }
}
