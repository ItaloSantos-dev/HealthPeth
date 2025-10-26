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
    public partial class Tratamentos : Form
    {
        public Tratamentos()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();

            ExibirTratamentos();
        }
        private void ExibirTratamentos()
        {
            Usuario usuario = new Usuario();
            DataTable tratamentos = usuario.BuscarTratamentos();
            panelCardsTratamentos.Controls.Clear();
            if(tratamentos.Rows.Count > 0 )
            {
                foreach(DataRow tratamento in tratamentos.Rows)
                {

                    FlowLayoutPanel linhaTratamento = new FlowLayoutPanel(){Height = 130, Width = 415, BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(5, 5, 5, 5) };
                    FlowLayoutPanel cardTratamento = new FlowLayoutPanel() { AutoSize = true, FlowDirection = FlowDirection.LeftToRight, Margin = new Padding(55, 0, 35, 0) };

                    Label lblApelido = new Label() { AutoSize = true, Font = new Font(Font.FontFamily, 12), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, Margin = new Padding(0,5,0,5) };
                    lblApelido.Text = "Pet: " + tratamento["apelido"].ToString() + ";";
                    cardTratamento.Controls.Add(lblApelido);

                    Label lblDesc = new Label() { AutoSize = true, Font = new Font(Font.FontFamily, 12), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, Margin = new Padding(0,5,0,5) };
                    lblDesc.Text = "Tratamento: " + tratamento["tratamento"].ToString() + ";";
                    cardTratamento.Controls.Add(lblDesc);


                    Label lblDia = new Label() { AutoSize = true, Font = new Font(Font.FontFamily, 12), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, Margin = new Padding(0,5,0,5) };
                    lblDia.Text = "Dias: " + tratamento["dias_semana"].ToString() + " ás " + tratamento["horario"].ToString();
                    cardTratamento.Controls.Add(lblDia);

                    DateTime inicio = (DateTime)tratamento["inicio"];
                    DateTime fim = (DateTime)tratamento["fim"];
                    Label lblDuracao = new Label() { AutoSize = true, Font = new Font(Font.FontFamily, 12), TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, Margin = new Padding(0,5,0,5) };
                    lblDuracao.Text = "Duração: " + inicio.ToString("yyyy/MM/dd") + " á " + fim.ToString("yyyy/MM/dd");
                    cardTratamento.Controls.Add(lblDuracao);

                    Button btnDetalhes = new Button() { AutoSize = true, Margin = new Padding(100,0,35,0)};
                    btnDetalhes.Text = "Detalhes";
                    btnDetalhes.Click += (s, e) =>
                    {
                        Detalhes detalhesConsulta = new Detalhes(tratamento, "Consulta");
                        detalhesConsulta.ShowDialog();
                    };
                    cardTratamento.Controls.Add(btnDetalhes);



                    linhaTratamento.Controls.Add(cardTratamento);
                    panelCardsTratamentos.Controls.Add(linhaTratamento); 

                   

                }

            }
            else
            {
                Label lblInfo = new Label() { AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Anchor = AnchorStyles.None, Width = 420, Height = 50 };
                lblInfo.Text = "Este pet não possui consultas";
                lblInfo.Font = new Font(lblInfo.Font.FontFamily, 18);
                panelCardsTratamentos.Controls.Add(lblInfo);
            }
        }

        private void panelCardsConsultas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            Owner.Show();
        }
    }
}
