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
            this.panelVet = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblVet = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBtnsMenu = new System.Windows.Forms.Panel();
            this.panelBtnTratamentos = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panelBtnReceitas = new System.Windows.Forms.Panel();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.pabelBtnPets = new System.Windows.Forms.Panel();
            this.btnMeusPets = new System.Windows.Forms.Button();
            this.panelBtnHome = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsultas = new System.Windows.Forms.Panel();
            this.panelCardsConsultas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelVet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBtnsMenu.SuspendLayout();
            this.panelBtnTratamentos.SuspendLayout();
            this.panelBtnReceitas.SuspendLayout();
            this.pabelBtnPets.SuspendLayout();
            this.panelBtnHome.SuspendLayout();
            this.panelConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelVet);
            this.panelPrincipal.Controls.Add(this.btnMenu);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Controls.Add(this.panelConsultas);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // panelVet
            // 
            this.panelVet.Controls.Add(this.dataGridView2);
            this.panelVet.Controls.Add(this.lblVet);
            this.panelVet.Location = new System.Drawing.Point(28, 261);
            this.panelVet.Name = "panelVet";
            this.panelVet.Size = new System.Drawing.Size(740, 185);
            this.panelVet.TabIndex = 5;
            this.panelVet.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVet_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(712, 120);
            this.dataGridView2.TabIndex = 4;
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVet.Location = new System.Drawing.Point(3, 5);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(355, 26);
            this.lblVet.TabIndex = 3;
            this.lblVet.Text = "Conheça alguns de nossos veterinários";
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
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panelBtnsMenu);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(-185, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(184, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
            // panelConsultas
            // 
            this.panelConsultas.Controls.Add(this.panelCardsConsultas);
            this.panelConsultas.Controls.Add(this.lblConsultas);
            this.panelConsultas.Location = new System.Drawing.Point(28, 39);
            this.panelConsultas.Name = "panelConsultas";
            this.panelConsultas.Size = new System.Drawing.Size(740, 185);
            this.panelConsultas.TabIndex = 2;
            this.panelConsultas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultas_Paint);
            // 
            // panelCardsConsultas
            // 
            this.panelCardsConsultas.AutoScroll = true;
            this.panelCardsConsultas.Location = new System.Drawing.Point(17, 34);
            this.panelCardsConsultas.Name = "panelCardsConsultas";
            this.panelCardsConsultas.Size = new System.Drawing.Size(712, 117);
            this.panelCardsConsultas.TabIndex = 4;
            this.panelCardsConsultas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(3, 5);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(127, 26);
            this.lblConsultas.TabIndex = 3;
            this.lblConsultas.Text = "Consultas de";
            this.lblConsultas.Click += new System.EventHandler(this.lblConsultas_Click);
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
            this.panelVet.ResumeLayout(false);
            this.panelVet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelBtnsMenu.ResumeLayout(false);
            this.panelBtnTratamentos.ResumeLayout(false);
            this.panelBtnReceitas.ResumeLayout(false);
            this.pabelBtnPets.ResumeLayout(false);
            this.panelBtnHome.ResumeLayout(false);
            this.panelConsultas.ResumeLayout(false);
            this.panelConsultas.PerformLayout();
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
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Panel panelConsultas;
        private System.Windows.Forms.Panel panelVet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.FlowLayoutPanel panelCardsConsultas;
    }
}