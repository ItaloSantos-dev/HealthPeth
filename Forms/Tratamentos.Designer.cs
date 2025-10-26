namespace HealthPetApp.Forms
{
    partial class Tratamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelCardsTratamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(10, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 25);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelCardsTratamentos
            // 
            this.panelCardsTratamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCardsTratamentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelCardsTratamentos.Location = new System.Drawing.Point(87, 0);
            this.panelCardsTratamentos.Name = "panelCardsTratamentos";
            this.panelCardsTratamentos.Size = new System.Drawing.Size(438, 452);
            this.panelCardsTratamentos.TabIndex = 2;
            this.panelCardsTratamentos.WrapContents = false;
            this.panelCardsTratamentos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCardsConsultas_Paint);
            // 
            // Tratamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelCardsTratamentos);
            this.Name = "Tratamentos";
            this.Text = "Tratamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.FlowLayoutPanel panelCardsTratamentos;
    }
}