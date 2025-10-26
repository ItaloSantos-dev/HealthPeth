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
    public partial class Detalhes : Form
    {

        public Detalhes(object infos, string tipo)
        {
            InitializeComponent();

            ExibirDetalhes(infos, tipo);
                
        }


        private void ExibirDetalhes(object infos, string tipo)
        {
            panelDetalhes.Controls.Clear();
            lblTipo.Text = tipo;
            if (tipo.Equals("Diagnostico"))
            {
                FlowLayoutPanel diagnosticoPanel = new FlowLayoutPanel();
                
                TextBox txtDiagnostico = new TextBox() { Width=200, Height=200,ReadOnly=true, Multiline = true  };
                txtDiagnostico.Text = infos.ToString();
                diagnosticoPanel.Controls.Add(txtDiagnostico);
                panelDetalhes.Controls.Add(diagnosticoPanel);
            }
            else if (tipo.Equals("Consulta"))
            {
                
                DataRow _infos = (DataRow)infos;
                DateTime data = (DateTime)_infos["data"];
                
                Label lblData = new Label() { AutoSize = true};
                lblData.Text = "Data: " + data.ToString("yyyy/MM/dd");
                panelDetalhes.Controls.Add(lblData);

                
                Label lblTipoc= new Label() { AutoSize = true };
                lblTipoc.Text = "Tipo: " + _infos["tipo"];
                panelDetalhes.Controls.Add(lblTipoc);


                Label lblStatus = new Label() { AutoSize = true };
                lblStatus.Text = "Status: " + _infos["status_consulta"];
                panelDetalhes.Controls.Add(lblStatus);

                if (_infos["status_consulta"].ToString().Equals("realizado"))
                {
                    TextBox diagnostico = new TextBox() { BorderStyle = BorderStyle.Fixed3D, ReadOnly = true, Multiline = true};
                    diagnostico.Text= _infos["diagnostico"].ToString();
                    panelDetalhes.Controls.Add(diagnostico);


                }





            }
            else if (tipo.Equals("Receita"))
            {
                DataRow _infos = (DataRow)infos;
                Label lblDesc = new Label(){AutoSize = true};
                Label lblFreq = new Label() { AutoSize = true };
                Label lbl3campo = new Label(){AutoSize = true};
                Label lbl4campo = new Label(){AutoSize = true};
                Label lbl5Campo = new Label(){AutoSize = true};
                Label lbl6Campo = new Label(){AutoSize = true};

                
                lblDesc.Text = "Medicamento: " + _infos["medicamento"].ToString();
                lblFreq.Text = _infos["frequencia"].ToString();
                lbl3campo.Text = "Dosagem: " + _infos["dosagem"] + " " + _infos["unidade"].ToString();
                lbl4campo.Text = "Duração: " + ((DateTime)_infos["inicio"]).ToString("yyyy-MM-dd") + " á " + ((DateTime)_infos["fim"]).ToString("yyyy/MM-dd");
                lbl5Campo.Text = "Status: " + _infos["status"].ToString();
                lbl6Campo.Text = "Observações: " + _infos["observacoes"].ToString();

                panelDetalhes.Controls.Add(lblDesc);
                panelDetalhes.Controls.Add(lblFreq);
                panelDetalhes.Controls.Add(lbl3campo);
                panelDetalhes.Controls.Add(lbl4campo);
                panelDetalhes.Controls.Add(lbl5Campo);
                panelDetalhes.Controls.Add(lbl6Campo);


            }
            else if (tipo.Equals("Tratamento"))
            {
                DataRow _infos = (DataRow)infos;
                Label lblDesc = new Label(){AutoSize = true};
                Label lblFreq = new Label(){AutoSize = true};
                Label lbl3campo = new Label(){AutoSize = true};
                Label lbl4campo = new Label(){AutoSize = true};
                Label lbl5Campo = new Label(){AutoSize = true};
                Label lbl6Campo = new Label(){AutoSize = true};
                

                lblDesc.Text = "Tratamento: " + _infos["tratamento"].ToString();
                lblFreq.Text = "Dias: " + _infos["dias_semana"].ToString() + " ás " + _infos["horario"].ToString();
                lbl3campo.Text = "Duração: " + ((DateTime)_infos["inicio"]).ToString("yyyy-MM-dd") + " á " + ((DateTime)_infos["fim"]).ToString("yyyy/MM-dd");
                lbl4campo.Text = "Status: " + _infos["status"].ToString();
                lbl5Campo.Text = "Observações: " + _infos["observacoes"].ToString();


                panelDetalhes.Controls.Add(lblDesc);
                panelDetalhes.Controls.Add(lblFreq);
                panelDetalhes.Controls.Add(lbl3campo);
                panelDetalhes.Controls.Add(lbl4campo);
                panelDetalhes.Controls.Add(lbl5Campo);
                panelDetalhes.Controls.Add(lbl6Campo);

            }
        }



        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl3campo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
