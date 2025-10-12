namespace HealthPetApp.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBtnHome = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pabelBtnPets = new System.Windows.Forms.Panel();
            this.btnMeusPets = new System.Windows.Forms.Button();
            this.panelBtnReceitas = new System.Windows.Forms.Panel();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.panelBtnTratamentos = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panelBtnsMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBtnHome.SuspendLayout();
            this.pabelBtnPets.SuspendLayout();
            this.panelBtnReceitas.SuspendLayout();
            this.panelBtnTratamentos.SuspendLayout();
            this.panelBtnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnMenu);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelBtnsMenu);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(-183, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(184, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Pet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelBtnHome
            // 
            this.panelBtnHome.Controls.Add(this.btnInicio);
            this.panelBtnHome.Location = new System.Drawing.Point(0, 0);
            this.panelBtnHome.Name = "panelBtnHome";
            this.panelBtnHome.Size = new System.Drawing.Size(184, 39);
            this.panelBtnHome.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(3, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(178, 32);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "           home";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // pabelBtnPets
            // 
            this.pabelBtnPets.Controls.Add(this.btnMeusPets);
            this.pabelBtnPets.Location = new System.Drawing.Point(0, 45);
            this.pabelBtnPets.Name = "pabelBtnPets";
            this.pabelBtnPets.Size = new System.Drawing.Size(184, 39);
            this.pabelBtnPets.TabIndex = 2;
            // 
            // btnMeusPets
            // 
            this.btnMeusPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMeusPets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeusPets.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusPets.Image = ((System.Drawing.Image)(resources.GetObject("btnMeusPets.Image")));
            this.btnMeusPets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeusPets.Location = new System.Drawing.Point(3, 4);
            this.btnMeusPets.Name = "btnMeusPets";
            this.btnMeusPets.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMeusPets.Size = new System.Drawing.Size(178, 32);
            this.btnMeusPets.TabIndex = 1;
            this.btnMeusPets.Text = "       Meus pets";
            this.btnMeusPets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMeusPets.UseVisualStyleBackColor = false;
            this.btnMeusPets.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelBtnReceitas
            // 
            this.panelBtnReceitas.Controls.Add(this.btnReceitas);
            this.panelBtnReceitas.Location = new System.Drawing.Point(0, 136);
            this.panelBtnReceitas.Name = "panelBtnReceitas";
            this.panelBtnReceitas.Size = new System.Drawing.Size(184, 39);
            this.panelBtnReceitas.TabIndex = 2;
            // 
            // btnReceitas
            // 
            this.btnReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReceitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceitas.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceitas.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitas.Image")));
            this.btnReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitas.Location = new System.Drawing.Point(3, 4);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReceitas.Size = new System.Drawing.Size(178, 32);
            this.btnReceitas.TabIndex = 1;
            this.btnReceitas.Text = "         Receitas";
            this.btnReceitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceitas.UseVisualStyleBackColor = false;
            // 
            // panelBtnTratamentos
            // 
            this.panelBtnTratamentos.Controls.Add(this.button5);
            this.panelBtnTratamentos.Location = new System.Drawing.Point(0, 90);
            this.panelBtnTratamentos.Name = "panelBtnTratamentos";
            this.panelBtnTratamentos.Size = new System.Drawing.Size(184, 39);
            this.panelBtnTratamentos.TabIndex = 3;
            this.panelBtnTratamentos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(178, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "     Tratamentos";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panelBtnsMenu
            // 
            this.panelBtnsMenu.Controls.Add(this.panelBtnTratamentos);
            this.panelBtnsMenu.Controls.Add(this.panelBtnReceitas);
            this.panelBtnsMenu.Controls.Add(this.pabelBtnPets);
            this.panelBtnsMenu.Controls.Add(this.panelBtnHome);
            this.panelBtnsMenu.Location = new System.Drawing.Point(0, 43);
            this.panelBtnsMenu.Name = "panelBtnsMenu";
            this.panelBtnsMenu.Size = new System.Drawing.Size(184, 214);
            this.panelBtnsMenu.TabIndex = 1;
            this.panelBtnsMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBtnMenu_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(6, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 33);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "HealthPet";
            this.panelPrincipal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelBtnHome.ResumeLayout(false);
            this.pabelBtnPets.ResumeLayout(false);
            this.panelBtnReceitas.ResumeLayout(false);
            this.panelBtnTratamentos.ResumeLayout(false);
            this.panelBtnsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBtnsMenu;
        private System.Windows.Forms.Panel panelBtnTratamentos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelBtnReceitas;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Panel pabelBtnPets;
        private System.Windows.Forms.Button btnMeusPets;
        private System.Windows.Forms.Panel panelBtnHome;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMenu;
    }
}