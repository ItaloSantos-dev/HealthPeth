using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthPetApp.Database;
using MySql.Data.MySqlClient;

namespace HealthPetApp.Forms
{

  
    public partial class Home : Form
    {
        Conexao conexao = new Conexao();
        //Função que acessa as Consultas do banco de dados e retorna uma Tabela com esses dados
        public DataTable BuscarConsultas()
        {
            var ConexaoAbriu = conexao.AbrirConexao();
            if(ConexaoAbriu != null)
            {
                //Comando
                string SELECT = "SELECT pets.apelido, pets.especie, consultas.data AS data_consul, consultas.tipo, consultas.status  FROM consultas JOIN agendamentos JOIN pets WHERE agendamentos.id = consultas.agendamento_id && agendamentos.pet_id = pets.id && pets.tutor_id=1;";
                MySqlCommand cmd = new MySqlCommand(SELECT, ConexaoAbriu);
                //Criando o adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                //Criando a tabela
                DataTable resultados = new DataTable();
                //Preenchendo a tabela
                adaptador.Fill(resultados);
                return resultados;

            }
            else
            {
                return null;
            }
        }

        public void ExibindoConsultas()
        {
            DataTable consultas = BuscarConsultas();
           if ( consultas != null )
            {
                foreach (DataRow linhas in consultas.Rows)
                {
                    FlowLayoutPanel panelCard = new FlowLayoutPanel();
                    
                    Label apelidoLabel = new Label();
                    apelidoLabel.Text ="Paciente: " +  linhas["apelido"].ToString();
                    apelidoLabel.TextAlign = ContentAlignment.MiddleCenter;
                    panelCard.Controls.Add(apelidoLabel);

                    Label consultaDAtaLabel = new Label();
                    consultaDAtaLabel.Text = "Data: " + Convert.ToDateTime(linhas["data_consul"]).ToString("dd/MM/yyyy");
                    panelCard.Controls.Add(consultaDAtaLabel);

                    Label consultaTipo = new Label();
                    consultaTipo.Text = "Tipo: " + linhas["tipo"].ToString();
                    panelCard.Controls.Add(consultaTipo);

                    Label statusConsultaLabel = new Label();
                    statusConsultaLabel.Text = "Status: " + linhas["status"].ToString();
                    panelCard.Controls.Add(statusConsultaLabel);

                    
                    panelCardsConsultas.Controls.Add(panelCard);
                    panelCard.BringToFront();
                    panelCard.BorderStyle = BorderStyle.FixedSingle;
                    panelCard.BackColor = ColorTranslator.FromHtml("#80FF80");
                    panelCard.Padding = new Padding(10);


                }
            }
            else
            {
                return;
            }
        }

        
        public Home()
        {
            InitializeComponent();
            lblConsultas.Text = "Consutlas de " + DateTime.Today.ToString("MMMM", new CultureInfo("pt-BR"));
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            ExibindoConsultas();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelBtnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (btnMenu.Location.Equals(new Point(190, 3)))
            {
                panelMenu.Location = new Point(-185, 0);
                btnMenu.Location = new Point(6, 3);
            }
            else
            {
                panelMenu.Location = new Point(0, 0);
                btnMenu.Location = new Point(190, 3);
                panelConsultas.SendToBack();
                panelVet.SendToBack();

            }
        }

        private void lblConsultas_Click(object sender, EventArgs e)
        {

        }

        private void panelConsultas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelVet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
