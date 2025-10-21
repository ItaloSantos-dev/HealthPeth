using HealthPetApp.CLasses;
using HealthPetApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthPetApp
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ValidarLogin(txtEmaiLogin.Text, txtSenhaLogin.Text, this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTelCad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEndCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSobrenomeCad_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNomeCad.Text;
            usuario.Sobrenome = txtSobrenomeCad.Text;
            usuario.Cpf = txtCpfCad.Text;
            usuario.Email = txtEmailCad.Text;
            usuario.Senha = txtSenhaCad.Text;
            usuario.Endereco = txtEndCad.Text;
            usuario.Telefone = txtTelCad.Text;
            usuario.Registrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelCad.Visible = false;
        }

        private void txtSenhaCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCadvw_Click_2(object sender, EventArgs e)
        {
            panelLogin.Visible = false; 
            panelCad.Visible = true;
        }
    }
}
