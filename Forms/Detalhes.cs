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
        string _tipo;
        DataRow _compromisso;
        string _diagnostico;
        public Detalhes(object compromisso, string tipo)
        {
            InitializeComponent();
            
             _tipo= tipo;
            if (_tipo.Equals("diagnostico"))
            {
                _diagnostico = (string)compromisso;
                ExibirDiagnostico();
            }
            else
            {
                _compromisso = (DataRow)compromisso;
                ExibirInformacoes();
            }
                
        }
        public void ExibirDiagnostico()
        {
            FlowLayoutPanel diagnosticoPaanel = new FlowLayoutPanel();
            lblTipo.Text = "Diagnostico";
            TextBox txtDiagnostico = new TextBox();
            txtDiagnostico.Text = _diagnostico;
            txtDiagnostico.Width = 200;
            txtDiagnostico.Height = 200;
            txtDiagnostico.ReadOnly = true;
            txtDiagnostico.Multiline = true;
            txtDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            diagnosticoPaanel.Controls.Add(txtDiagnostico);
            flowLayoutPanel1.Controls.Add(diagnosticoPaanel);


        }
        public void ExibirInformacoes()
        {
            Label lblDesc = new Label();
            Label lblFreq = new Label();
            Label lbl3campo = new Label();
            Label lbl4campo = new Label();
            Label lbl5Campo = new Label();
            Label lbl6Campo = new Label();



            if (_tipo.Equals("Tratamento"))
            {
                lblTipo.Text = "Tratamento";

                lblDesc.Text = "Tratamento: " + _compromisso["descricao"].ToString();
                lblFreq.Text = "Dias: " + _compromisso["dias_semana"].ToString() + " ás " + _compromisso["horario"].ToString();
                lbl3campo.Text = "Duração: " + ((DateTime)_compromisso["inicio"]).ToString("yyyy-MM-dd") + " á " + ((DateTime)_compromisso["fim"]).ToString("yyyy/MM-dd");
                lbl4campo.Text = "Status: " + _compromisso["status"].ToString();
                lbl5Campo.Text = "Observações: " + _compromisso["observacoes"].ToString();
            }
            else
            {
                lblTipo.Text = "Receita";
                lblDesc.Text = "Medicamento: " + _compromisso["medicamento"].ToString();
                lblFreq.Text = _compromisso["frequencia"].ToString();
                lbl3campo.Text = "Dosagem: " + _compromisso["dosagem"] + " " + _compromisso["unidade"].ToString();
                lbl4campo.Text = "Duração: " + ((DateTime)_compromisso["inicio"]).ToString("yyyy-MM-dd") + " á " + ((DateTime)_compromisso["fim"]).ToString("yyyy/MM-dd");
                lbl5Campo.Text = "Status: " + _compromisso["status"].ToString();
                lbl6Campo.Text = "Observações: " + _compromisso["observacoes"].ToString();


            }
            flowLayoutPanel1.Controls.Add(lblDesc);
            lblDesc.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblFreq);
            lblFreq.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl3campo);
            lbl3campo.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl4campo);
            lbl4campo.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl5Campo);
            lbl4campo.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl6Campo);
            lbl5Campo.AutoSize = true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl3campo_Click(object sender, EventArgs e)
        {

        }
    }
}
