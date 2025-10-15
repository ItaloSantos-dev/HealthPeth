using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPetApp.CLasses
{
    internal static class UsuarioLogado
    {
        private static int id;
        private static string nome;
        private static string sobrenome;
        private static string cpf;
        private static string email;
        private static string senha;
        private static string endereco;
        private static string telefone;

        public static int Id { get => id; set => id = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public static string Cpf { get => cpf; set => cpf = value; }
        public static string Email { get => email; set => email = value; }
        public static string Senha { get => senha; set => senha = value; }
        public static string Endereco { get => endereco; set => endereco = value; }
        public static string Telefone { get => telefone; set => telefone = value; }
    }
}
