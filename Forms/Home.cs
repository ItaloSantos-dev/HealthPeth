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



        
        public Home()
        {
            InitializeComponent();
            lblConsultas.Text = "Consutlas de " + DateTime.Today.ToString("MMMM", new CultureInfo("pt-BR"));
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            
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
