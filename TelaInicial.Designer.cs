namespace HealthPetApp
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmaiLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadvw = new System.Windows.Forms.Button();
            this.panelCad = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoginvw = new System.Windows.Forms.Button();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSobrenomeCad = new System.Windows.Forms.Label();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndCad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelCad = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogin.Controls.Add(this.btnCadvw);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.txtSenhaLogin);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.txtEmaiLogin);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(235, 23);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(307, 353);
            this.panelLogin.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(232)))), ((int)(((byte)(153)))));
            this.btnEntrar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(24, 292);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(106, 28);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(93, 239);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(127, 20);
            this.txtSenhaLogin.TabIndex = 11;
            this.txtSenhaLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // txtEmaiLogin
            // 
            this.txtEmaiLogin.Location = new System.Drawing.Point(93, 155);
            this.txtEmaiLogin.Name = "txtEmaiLogin";
            this.txtEmaiLogin.Size = new System.Drawing.Size(127, 20);
            this.txtEmaiLogin.TabIndex = 9;
            this.txtEmaiLogin.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnCadvw
            // 
            this.btnCadvw.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadvw.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadvw.Location = new System.Drawing.Point(174, 292);
            this.btnCadvw.Name = "btnCadvw";
            this.btnCadvw.Size = new System.Drawing.Size(106, 28);
            this.btnCadvw.TabIndex = 13;
            this.btnCadvw.Text = "Registrar-se";
            this.btnCadvw.UseVisualStyleBackColor = false;
            // 
            // panelCad
            // 
            this.panelCad.Controls.Add(this.maskedTextBox1);
            this.panelCad.Controls.Add(this.label10);
            this.panelCad.Controls.Add(this.txtTelCad);
            this.panelCad.Controls.Add(this.label7);
            this.panelCad.Controls.Add(this.txtEndCad);
            this.panelCad.Controls.Add(this.label9);
            this.panelCad.Controls.Add(this.textBox1);
            this.panelCad.Controls.Add(this.txtSobrenomeCad);
            this.panelCad.Controls.Add(this.txtNomeCad);
            this.panelCad.Controls.Add(this.label8);
            this.panelCad.Controls.Add(this.button1);
            this.panelCad.Controls.Add(this.btnLoginvw);
            this.panelCad.Controls.Add(this.txtSenhaCad);
            this.panelCad.Controls.Add(this.label4);
            this.panelCad.Controls.Add(this.txtEmailCad);
            this.panelCad.Controls.Add(this.label5);
            this.panelCad.Controls.Add(this.label6);
            this.panelCad.Location = new System.Drawing.Point(83, 23);
            this.panelCad.Name = "panelCad";
            this.panelCad.Size = new System.Drawing.Size(597, 382);
            this.panelCad.TabIndex = 1;
            this.panelCad.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(320, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Registrar-se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoginvw
            // 
            this.btnLoginvw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(232)))), ((int)(((byte)(153)))));
            this.btnLoginvw.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginvw.Location = new System.Drawing.Point(170, 301);
            this.btnLoginvw.Name = "btnLoginvw";
            this.btnLoginvw.Size = new System.Drawing.Size(106, 28);
            this.btnLoginvw.TabIndex = 19;
            this.btnLoginvw.Text = "Login";
            this.btnLoginvw.UseVisualStyleBackColor = false;
            this.btnLoginvw.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(238, 201);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(127, 20);
            this.txtSenhaCad.TabIndex = 18;
            this.txtSenhaCad.TextChanged += new System.EventHandler(this.txtSenhaCad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(238, 117);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(127, 20);
            this.txtEmailCad.TabIndex = 16;
            this.txtEmailCad.TextChanged += new System.EventHandler(this.txtEmailCad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cadastrar-se";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtSobrenomeCad
            // 
            this.txtSobrenomeCad.AutoSize = true;
            this.txtSobrenomeCad.BackColor = System.Drawing.Color.Transparent;
            this.txtSobrenomeCad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomeCad.Location = new System.Drawing.Point(92, 166);
            this.txtSobrenomeCad.Name = "txtSobrenomeCad";
            this.txtSobrenomeCad.Size = new System.Drawing.Size(87, 22);
            this.txtSobrenomeCad.TabIndex = 23;
            this.txtSobrenomeCad.Text = "Sobrenome";
            this.txtSobrenomeCad.Click += new System.EventHandler(this.txtSobrenomeCad_Click);
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(71, 117);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(127, 20);
            this.txtNomeCad.TabIndex = 22;
            this.txtNomeCad.TextChanged += new System.EventHandler(this.txtNomeCad_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nome";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEndCad
            // 
            this.txtEndCad.Location = new System.Drawing.Point(403, 117);
            this.txtEndCad.Name = "txtEndCad";
            this.txtEndCad.Size = new System.Drawing.Size(127, 20);
            this.txtEndCad.TabIndex = 26;
            this.txtEndCad.TextChanged += new System.EventHandler(this.txtEndCad_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Endereço";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTelCad
            // 
            this.txtTelCad.Location = new System.Drawing.Point(403, 201);
            this.txtTelCad.Mask = "(XX) XXXXX-XXXX";
            this.txtTelCad.Name = "txtTelCad";
            this.txtTelCad.Size = new System.Drawing.Size(127, 20);
            this.txtTelCad.TabIndex = 28;
            this.txtTelCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelCad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelCad_MaskInputRejected);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(145, 256);
            this.maskedTextBox1.Mask = "XXX.XXX.XXX-XX";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(304, 20);
            this.maskedTextBox1.TabIndex = 30;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "CPF";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.panelCad);
            this.Controls.Add(this.panelLogin);
            this.Name = "TelaInicial";
            this.Text = "HealthPet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCad.ResumeLayout(false);
            this.panelCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmaiLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadvw;
        private System.Windows.Forms.Panel panelCad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoginvw;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtSobrenomeCad;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelCad;
    }
}

