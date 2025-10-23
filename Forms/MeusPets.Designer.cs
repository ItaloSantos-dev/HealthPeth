namespace HealthPetApp.Forms
{
    partial class MeusPets
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelCardsPet = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PanelCardsPet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 455);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meus pets:";
            // 
            // PanelCardsPet
            // 
            this.PanelCardsPet.AutoScroll = true;
            this.PanelCardsPet.Location = new System.Drawing.Point(12, 108);
            this.PanelCardsPet.Name = "PanelCardsPet";
            this.PanelCardsPet.Size = new System.Drawing.Size(776, 226);
            this.PanelCardsPet.TabIndex = 1;
            this.PanelCardsPet.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar novo pet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MeusPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MeusPets";
            this.Text = "MeusPets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel PanelCardsPet;
        private System.Windows.Forms.Label label1;
    }
}