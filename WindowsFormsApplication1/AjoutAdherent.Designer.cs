namespace WindowsFormsApplication1
{
    partial class AjoutAdherent
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
            this.components = new System.ComponentModel.Container();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_CP = new System.Windows.Forms.TextBox();
            this.tb_cotisation = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_naissance = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_homme = new System.Windows.Forms.RadioButton();
            this.rb_femme = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(189, 88);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(241, 20);
            this.tb_nom.TabIndex = 0;
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.Location = new System.Drawing.Point(471, 356);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.bt_Ajouter.TabIndex = 26;
            this.bt_Ajouter.Text = "Valider";
            this.bt_Ajouter.Click += new System.EventHandler(this.bt_Ajouter_Click);
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(189, 152);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(241, 20);
            this.tb_prenom.TabIndex = 2;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(724, 88);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(241, 20);
            this.tb_adresse.TabIndex = 5;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(724, 152);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(241, 20);
            this.tb_ville.TabIndex = 6;
            // 
            // tb_CP
            // 
            this.tb_CP.Location = new System.Drawing.Point(724, 223);
            this.tb_CP.Name = "tb_CP";
            this.tb_CP.Size = new System.Drawing.Size(241, 20);
            this.tb_CP.TabIndex = 7;
            // 
            // tb_cotisation
            // 
            this.tb_cotisation.Location = new System.Drawing.Point(724, 290);
            this.tb_cotisation.Name = "tb_cotisation";
            this.tb_cotisation.Size = new System.Drawing.Size(241, 20);
            this.tb_cotisation.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prénom";
            // 
            // dtp_naissance
            // 
            this.dtp_naissance.Location = new System.Drawing.Point(189, 223);
            this.dtp_naissance.Name = "dtp_naissance";
            this.dtp_naissance.Size = new System.Drawing.Size(241, 20);
            this.dtp_naissance.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date de Naissance";
            // 
            // rb_homme
            // 
            this.rb_homme.AutoSize = true;
            this.rb_homme.Location = new System.Drawing.Point(189, 291);
            this.rb_homme.Name = "rb_homme";
            this.rb_homme.Size = new System.Drawing.Size(61, 17);
            this.rb_homme.TabIndex = 19;
            this.rb_homme.TabStop = true;
            this.rb_homme.Text = "Homme";
            this.rb_homme.UseVisualStyleBackColor = true;
            // 
            // rb_femme
            // 
            this.rb_femme.AutoSize = true;
            this.rb_femme.Location = new System.Drawing.Point(290, 293);
            this.rb_femme.Name = "rb_femme";
            this.rb_femme.Size = new System.Drawing.Size(59, 17);
            this.rb_femme.TabIndex = 20;
            this.rb_femme.TabStop = true;
            this.rb_femme.Text = "Femme";
            this.rb_femme.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sexe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Code postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cotisation";
            // 
            // AjoutAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 604);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_femme);
            this.Controls.Add(this.rb_homme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_naissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cotisation);
            this.Controls.Add(this.tb_CP);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.bt_Ajouter);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AjoutAdherent";
            this.Text = "AjoutAdherent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AjoutAdherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_CP;
        private System.Windows.Forms.TextBox tb_cotisation;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_naissance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_homme;
        private System.Windows.Forms.RadioButton rb_femme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}