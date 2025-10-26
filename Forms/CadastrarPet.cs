using HealthPetApp.CLasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPetApp.Forms
{
    public partial class CadastrarPet : Form
    {
        public CadastrarPet()
        {
            InitializeComponent();
            txtNasc.CustomFormat = "yy/MM/dd";
        }

        private void txtNasc_ValueChanged(object sender, EventArgs e)
        {

        }
        public void LimparCampos()
        {
            txtApelido.Text = "";
            txtEspecie.Text = "";
            txtRaca.Text = "";
            txtNasc.Text = "";



        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Tutor_id = UsuarioLogado.Id;
            pet.Apelido = txtApelido.Text;
            pet.Especie = txtEspecie.Text;
            pet.Raca = txtRaca.Text;
            pet.Nascimento = txtNasc.Value;
            pet.Idade = DateTime.Today.Year-pet.Nascimento.Year;
            pet.CadastrarPet(this);
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
