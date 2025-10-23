using HealthPetApp.Database;
using HealthPetApp.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public void Registrar()
        {
            var con = conexao.AbrirConexao();

            string INSERT = "INSERT INTO usuarios (id, nome, sobrenome, cpf, email, senha, endereco, telefone) VALUES " +
                "                                 (@_id, @_nome, @_sobrenome, @_cpf, @_email, @_senha, @_endereco, @_telefone) ";
            MySqlCommand cmd = new MySqlCommand(INSERT, con);
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_endereco", Endereco);
            cmd.Parameters.AddWithValue("_telefone", Telefone);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário registrado com sucesso ");

            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Erro ao registrar usuário " +  ex.Message);
            }
        }
        public DataTable FiltrarConsultas(string filtro)
        {
            var con = conexao.AbrirConexao();
            string SELECT;
            DataTable tabelaconsultas = new DataTable();
            if (filtro == "Todas")
            {
                //todas consultas
                SELECT = "SELECT pets.apelido, pets.especie, consultas.tipo, consultas.data, consultas.status, consultas.diagnostico, consultas.diagnostico FROM consultas " +
                "JOIN agendamentos ON consultas.agendamento_id = agendamentos.id " +
                "JOIN pets ON agendamentos.pet_id = pets.id " +
                "JOIN usuarios ON pets.tutor_id = usuarios.id " +
                "WHERE usuarios.id = @usuario_id;";
                
                MySqlCommand cmd = new MySqlCommand(SELECT, con);
                cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
                //adapta para retornar uma tabela
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //criia uma tabela
                //preenche a tabela
                adaptador.Fill(tabelaconsultas);
            }
            else if (filtro== "Este mês")
            {
                //Deste mês
                DateTime diaAtual = DateTime.Today;
                DateTime primeiroDiaDoMes = new DateTime(diaAtual.Year, diaAtual.Month, 1);
                int ultimoDiaNum = DateTime.DaysInMonth(diaAtual.Year, diaAtual.Month);
                DateTime ultimoDiaDoMes = new DateTime(diaAtual.Year, diaAtual.Month, ultimoDiaNum);

                SELECT = "SELECT pets.apelido, pets.especie, consultas.tipo, consultas.data, consultas.status, consultas.diagnostico, consultas.diagnostico FROM consultas " +
                    "JOIN agendamentos ON consultas.agendamento_id = agendamentos.id " +
                    "JOIN pets ON agendamentos.pet_id = pets.id " +
                    "JOIN usuarios ON pets.tutor_id = usuarios.id " +
                    "WHERE consultas.data BETWEEN @primeirodia AND @ultimodia " +
                    "&& usuarios.id = @usuario_id;"; 
                MySqlCommand cmd = new MySqlCommand(SELECT , con);
                cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
                cmd.Parameters.AddWithValue("@primeirodia", primeiroDiaDoMes);
                cmd.Parameters.AddWithValue("@ultimodia", ultimoDiaDoMes);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador .Fill(tabelaconsultas);
            }
            else if(filtro == "Agendadas")
            {
                SELECT = "SELECT pets.apelido, pets.especie, consultas.tipo, consultas.data, consultas.status, consultas.diagnostico, consultas.diagnostico FROM consultas " +
                    "JOIN agendamentos ON consultas.agendamento_id = agendamentos.id " +
                    "JOIN pets ON agendamentos.pet_id = pets.id " +
                    "JOIN usuarios ON pets.tutor_id = usuarios.id " +
                    "WHERE consultas.status = 'agendado'" +
                    "&& usuarios.id = @usuario_id;"; 
                MySqlCommand cmd = new MySqlCommand(SELECT, con);
                cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabelaconsultas);

            }
            else if(filtro == "Concluidas")
            {
                SELECT = "SELECT pets.apelido, pets.especie, consultas.tipo, consultas.data, consultas.status, consultas.diagnostico, consultas.diagnostico FROM consultas " +
                    "JOIN agendamentos ON consultas.agendamento_id = agendamentos.id " +
                    "JOIN pets ON agendamentos.pet_id = pets.id " +
                    "JOIN usuarios ON pets.tutor_id = usuarios.id " +
                    "WHERE consultas.status = 'realizado' " +
                    "&& usuarios.id = @usuario_id;";

                MySqlCommand cmd = new MySqlCommand(SELECT, con);
                cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabelaconsultas);
            }
            else if( filtro == "Canceladas")
            {
                SELECT = "SELECT pets.apelido, pets.especie, consultas.tipo, consultas.data, consultas.status, consultas.diagnostico, consultas.diagnostico FROM consultas " +
                    "JOIN agendamentos ON consultas.agendamento_id = agendamentos.id " +
                    "JOIN pets ON agendamentos.pet_id = pets.id " +
                    "JOIN usuarios ON pets.tutor_id = usuarios.id " +
                    "WHERE consultas.status = 'cancelado'" +
                    "&& usuarios.id = @usuario_id;" ;
                MySqlCommand cmd = new MySqlCommand(SELECT, con);
                cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabelaconsultas);
            }
            else if (filtro == "Perdidas")
            {
                SELECT = "SELECT pets.apelido, pets.especie, consultas.tipo, consultas.data, consultas.status, consultas.diagnostico, consultas.diagnostico FROM consultas " +
                    "JOIN agendamentos ON consultas.agendamento_id = agendamentos.id " +
                    "JOIN pets ON agendamentos.pet_id = pets.id " +
                    "JOIN usuarios ON pets.tutor_id = usuarios.id " +
                    "WHERE consultas.status = 'faltou'" +
                    "&& usuarios.id = @usuario_id;" ;
                MySqlCommand cmd = new MySqlCommand(SELECT, con);
                cmd.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(tabelaconsultas);
            }
            else
            {
                return null;
            }
            return tabelaconsultas;




        }


        public DataTable BuscarCompromissos()
        {
            var con = conexao.AbrirConexao();
            string SELECT1 = "SELECT pets.apelido,receitas.id, receitas.medicamento, receitas.dosagem, receitas.unidade, receitas.frequencia, receitas.observacoes, receitas.inicio, receitas.fim, receitas.status FROM receitas JOIN consultas ON receitas.consulta_id = consultas.id JOIN agendamentos ON consultas.agendamento_id = agendamentos.id JOIN pets ON agendamentos.pet_id = pets.id WHERE pets.tutor_id = @usuario_id AND receitas.status = 'em andamento'";
            MySqlCommand cmd1 = new MySqlCommand(SELECT1, con);
            cmd1.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
            DataTable tabela = new DataTable();
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter(cmd1);
            adaptador1.Fill(tabela);

            string SELECT2 = "SELECT pets.apelido, tratamentos.id, tratamentos.descricao, tratamentos.dias_semana, tratamentos.horario, tratamentos.inicio, tratamentos.fim, tratamentos.status, tratamentos.observacoes FROM tratamentos JOIN consultas ON tratamentos.consulta_id = consultas.id JOIN agendamentos ON consultas.agendamento_id = agendamentos.id JOIN pets ON agendamentos.pet_id = pets.id WHERE pets.tutor_id = @usuario_id AND tratamentos.status='em andamento'";
            MySqlCommand cmd2 = new MySqlCommand(SELECT2, con);
            cmd2.Parameters.AddWithValue("@usuario_id", UsuarioLogado.Id);
            DataTable tabela2 = new DataTable();
            MySqlDataAdapter adaptador2 = new MySqlDataAdapter(cmd2);
            adaptador2.Fill(tabela2);

            tabela.Merge(tabela2);
            
            return tabela;


        }


        public DataTable BuscarMeusPets()
        {
            var con = conexao.AbrirConexao();
            string SELECT = "SELECT *FROM pets WHERE tutor_id = @id_user";
            MySqlCommand cmd = new MySqlCommand(SELECT, con);
            cmd.Parameters.AddWithValue("@id_user", UsuarioLogado.Id);
            DataTable meusPets = new DataTable();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            adaptador.Fill(meusPets);
            return meusPets;

        }







    }
}
