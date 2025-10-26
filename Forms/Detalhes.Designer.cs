namespace HealthPetApp.Forms
{
    partial class Detalhes
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
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelDetalhes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Location = new System.Drawing.Point(91, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 51);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 2);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 22);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Compromisso:";
            this.lblTipo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDetalhes
            // 
            this.panelDetalhes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDetalhes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDetalhes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDetalhes.Location = new System.Drawing.Point(32, 82);
            this.panelDetalhes.Name = "panelDetalhes";
            this.panelDetalhes.Padding = new System.Windows.Forms.Padding(5);
            this.panelDetalhes.Size = new System.Drawing.Size(358, 323);
            this.panelDetalhes.TabIndex = 4;
            this.panelDetalhes.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDetalhes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 448);
            this.panel1.TabIndex = 1;
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Detalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DtalhesCompromissos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.FlowLayoutPanel panelDetalhes;
        private System.Windows.Forms.Panel panel1;
    }
}