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
    public partial class ConsultasdoPet : Form
    {
        DataRow _pet;
        public ConsultasdoPet(DataRow petDados)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            this.Text = "Consultas do(a) " + petDados["apelido"];
            _pet = petDados;
            ExibirConsultas();
        }
        
        private void ExibirConsultas()
        {
            Pet pet = new Pet();
            pet.Id =(int) _pet["id"];
            DataTable consultas = pet.BuscarConsultas();

            

            


            
            if(consultas.Rows.Count > 0)
            {
                FlowLayoutPanel panelColunas = new FlowLayoutPanel() { FlowDirection = FlowDirection.LeftToRight, Width = 420, Height = 25, Padding = new Padding(5, 5, 5, 5), WrapContents = false };

                Label colunaData = new Label() {AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None};
                colunaData.Text = "Data";
                panelColunas.Controls.Add(colunaData);

                Label colunaDataAgen = new Label(){AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None};
                colunaDataAgen.Text = "Agendamento";
                panelColunas.Controls.Add(colunaDataAgen);

                Label colunaTipo = new Label(){AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None};
                colunaTipo.Text = "Tipo";
                panelColunas.Controls.Add(colunaTipo);
                panelCardsConsultas.Controls.Add(panelColunas);

            Label colunaStatus = new Label() {AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None };
            colunaStatus.Text = "Status/Diagnóstico";
            panelColunas.Controls.Add(colunaStatus);
                foreach (DataRow consulta in consultas.Rows)
                {
                    FlowLayoutPanel cardConsultadoPet = new FlowLayoutPanel() { FlowDirection = FlowDirection.LeftToRight, Width = 415, Height = 40, BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(5, 5, 5, 5), WrapContents = false };

                    DateTime data = (DateTime)consulta["data"];

                    Label lblDataConsulta = new Label() {AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None};
                    lblDataConsulta.Text =data.ToString("yyyy/MM/dd");
                    cardConsultadoPet.Controls.Add(lblDataConsulta);

                    data = (DateTime)consulta["data_agendamento"];
                    Label lblDataAgen = new Label() {AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None };
                    lblDataAgen.Text =data.ToString("yyyy/MM/dd");
                    cardConsultadoPet.Controls.Add(lblDataAgen);

                    Label lblTipo = new Label(){ TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None};
                    lblTipo.Text =consulta["tipo"].ToString();
                    cardConsultadoPet.Controls.Add(lblTipo);

                    if (consulta["status"].Equals("realizado")){
                        Button btnDiagnostico = new Button();
                        btnDiagnostico.Text = "Diagnóstico";
                        btnDiagnostico.Click += (s, e) =>
                        {
                            Detalhes detalhes = new Detalhes(consulta["diagnostico"].ToString(), "Diagnostico");
                            detalhes.ShowDialog();

                        };
                        cardConsultadoPet.Controls.Add(btnDiagnostico);
                    }
                    else
                    {
                        Label lblStatus = new Label() { TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None };
                        lblStatus.Text = consulta["status"].ToString();
                        cardConsultadoPet.Controls.Add(lblStatus);
                    }


                    panelCardsConsultas.Controls.Add(cardConsultadoPet);


                }
            }
            else
            {
                Label lblInfo = new Label() { AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, Width = 420, Height = 50}; 
                lblInfo.Text = "Este pet não possui consultas";
                lblInfo.Font= new Font(lblInfo.Font.FontFamily, 18);
                panelCardsConsultas.Controls.Add(lblInfo);
            }
        }

        private void ConsultasdoPet_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MeusPets meusPets = new MeusPets();
            this.Hide();
            Owner.Show();
        }

        private void panelCardsConsultas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
