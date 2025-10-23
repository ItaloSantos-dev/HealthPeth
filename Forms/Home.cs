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
using HealthPetApp.CLasses;
using HealthPetApp.Database;
using MySql.Data.MySqlClient;

namespace HealthPetApp.Forms
{

  
    public partial class Home : Form
    {



        
        public Home()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            filtroConsultas.SelectedItem = "Todas";
            ExibirConsultas();
            ExibirCompromissos();
            
        }
        Usuario usuario = new Usuario();

        private void ExibirCompromissos()
        {
            DataTable tabelaCompromissos = usuario.BuscarCompromissos();
            panelCardCompromissos.Controls.Clear();
            foreach (DataRow compromisso  in tabelaCompromissos.Rows)

            {
                FlowLayoutPanel cardCompromisso = new FlowLayoutPanel();
                cardCompromisso.FlowDirection = FlowDirection.TopDown;
                cardCompromisso.AutoSize = true;
                cardCompromisso.WrapContents=false;
                cardCompromisso.BorderStyle = BorderStyle.FixedSingle;
                Label lblTipo = new Label();
                Label lblApelido = new Label();
                Label lblCampo1 = new Label();
                Label lblCampo2 = new Label() { AutoSize = true};
                Label lblCampo3 = new Label();
                lblApelido.Text = "Pet: " + compromisso["apelido"].ToString();
                string tipo;
                
                if (compromisso["medicamento"] != DBNull.Value)
                {
                    tipo = "Receita";
                    lblTipo.Text = "Receita";
                    cardCompromisso.Controls.Add(lblTipo);

                    cardCompromisso.Controls.Add(lblApelido);

                    lblCampo1.Text ="Medicamento: "+ compromisso["medicamento"].ToString();
                    cardCompromisso.Controls.Add(lblCampo1);

                    lblCampo2.Text ="Dosagem: " + compromisso["dosagem"].ToString() + " " +  compromisso["unidade"].ToString();
                    cardCompromisso.Controls.Add(lblCampo2);
                    
                        
                }
                else
                {
                    tipo = "Tratamento";
                    lblTipo.Text = "Tratamento";
                    cardCompromisso.Controls.Add(lblTipo);

                    cardCompromisso.Controls.Add(lblApelido);

                    lblCampo1.Text ="Desc:" +  compromisso["descricao"].ToString();
                    cardCompromisso.Controls.Add (lblCampo1);

                    lblCampo2.Text = "Horários: " + compromisso["dias_semana"].ToString() + " ás " + compromisso["horario"].ToString();
                    cardCompromisso.Controls.Add(lblCampo2);

                }
                Button btnVerMais = new Button();
                btnVerMais.Text = "Ver mais";
                btnVerMais.Click += (s, e) =>
                {
                    Detalhes detalhesCompromissos = new Detalhes(compromisso, tipo);
                    detalhesCompromissos.ShowDialog();
                };
                cardCompromisso.Controls.Add(btnVerMais);
                panelCardCompromissos.Controls.Add(cardCompromisso);

            }
        }

        private void ExibirConsultas()
        {
            
            DataTable consultasDoUsuario = usuario.FiltrarConsultas(filtroConsultas.Text);
            panelCardsConsultas.Controls.Clear();
            int i = 0;
            foreach (DataRow consultas in  consultasDoUsuario.Rows)
            {
                FlowLayoutPanel cardPanel = new FlowLayoutPanel();
                cardPanel.FlowDirection = FlowDirection.TopDown;
                //apelido
                Label apelidoLabel = new Label();
                apelidoLabel.Text = "Pet: "+consultas["apelido"].ToString();
                cardPanel.Controls.Add(apelidoLabel);

                //Especie
                Label especieLabel = new Label();
                especieLabel.Text = "Espécie: " + consultas["especie"].ToString();
                cardPanel.Controls.Add(especieLabel);

                //tipo da consulta
                Label tipoLabel = new Label();
                tipoLabel.Text = "Tipo: "+consultas["tipo"].ToString();
                cardPanel.Controls.Add(tipoLabel);

                //data
                Label dataLabel = new Label();
                dataLabel.Text="Data; " + consultas["data"].ToString();
                cardPanel.Controls.Add(dataLabel);

                //status
                Label statusLabel = new Label();
                statusLabel.Text ="Status: " + consultas["status"].ToString();
                cardPanel.Controls.Add(statusLabel);

                //diagnostico
                if (consultas["status"].ToString() == "realizado")
                {
                    Button diagnosticoButton = new Button();
                    diagnosticoButton.Text="Diagnóstico";
                    diagnosticoButton.Click += (s, e) =>
                    {
                        string tipo = "diagnostico";
                        Detalhes detalhes = new Detalhes(consultas["diagnostico"].ToString(), tipo);
                        detalhes.ShowDialog();


                    };
                    cardPanel.Controls.Add (diagnosticoButton);
                }
                cardPanel.WrapContents = false;
                cardPanel.Size = new Size(111, 150);
                panelCardsConsultas.Controls.Add(cardPanel);
                cardPanel.Location= new Point (i*5, 0);
                cardPanel.BorderStyle = BorderStyle.FixedSingle;
                i++;
            }
   
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
            MeusPets meuspets = new MeusPets();
            this.Owner = meuspets;
            meuspets.Show();
            this.Hide();
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

        private void filtroConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirConsultas();
        }

        private void lblVet_Click(object sender, EventArgs e)
        {

        }
    }
}
