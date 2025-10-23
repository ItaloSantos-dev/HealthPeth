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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HealthPetApp.Forms
{
    public partial class MeusPets : Form
    {
        public MeusPets()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            ExibirMeusPets();
        }

        public void ExibirMeusPets()
        {
            Usuario usuario = new Usuario();
            DataTable tabelaMeusPets = usuario.BuscarMeusPets();

            FlowLayoutPanel cardColunas = new FlowLayoutPanel() { AutoSize = true, FlowDirection = FlowDirection.TopDown, Width = 55 }; 

            Label lblApelidoc = new Label();
            lblApelidoc.Text = "Apelido:";
            cardColunas.Controls.Add(lblApelidoc);

            Label lblEspeciec = new Label();
            lblEspeciec.Text = "Espécie:";
            cardColunas.Controls.Add(lblEspeciec);

            Label lblRacac = new Label();
            lblRacac.Text = "Raça: ";
            cardColunas.Controls.Add(lblRacac);

            Label lblNascimentoc = new Label();
            lblNascimentoc.Text = "Nascimento:";
            cardColunas.Controls.Add(lblNascimentoc);


            Label lblIdadec = new Label();
            lblIdadec.Text = "Idade:";
            cardColunas.Controls.Add(lblIdadec);

            PanelCardsPet.Controls.Add(cardColunas);
            foreach (DataRow pet in tabelaMeusPets.Rows)
            {
                FlowLayoutPanel cardPet = new FlowLayoutPanel() { AutoSize=true, FlowDirection=FlowDirection.TopDown};

                Label lblApelido = new Label();
                lblApelido.Text = pet["apelido"].ToString();
                cardPet.Controls.Add(lblApelido);

                Label lblEspecie = new Label();
                lblEspecie.Text = pet["especie"].ToString();
                cardPet.Controls.Add(lblEspecie);

                Label lblRaca = new Label();
                lblRaca.Text = pet["raca"].ToString();
                cardPet.Controls.Add(lblRaca);

                Label lblNascimento = new Label();
                lblNascimento.Text = pet["nascimento"].ToString();
                cardPet.Controls.Add(lblNascimento);


                Label lblIdade = new Label();
                lblIdade.Text = pet["idade"].ToString() +" Anos ";
                cardPet.Controls.Add(lblIdade);


                PanelCardsPet.Controls.Add(cardPet);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
