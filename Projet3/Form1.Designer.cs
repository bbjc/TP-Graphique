namespace Projet3
{
    partial class Calcul
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            TxtNom = new TextBox();
            TxtPrenom = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TxtTel = new TextBox();
            TxtCin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            TxtTech = new TextBox();
            TxtLang = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            RdFem = new RadioButton();
            RdMas = new RadioButton();
            groupBox4 = new GroupBox();
            ChkDip = new CheckBox();
            ChkMotiv = new CheckBox();
            ChkExper = new CheckBox();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            label14 = new Label();
            BtnChance = new Button();
            TxtChance = new TextBox();
            panel1 = new Panel();
            BtnAjout = new Button();
            BtnCalc = new Button();
            BtnQuit = new Button();
            BtnInit = new Button();
            panel2 = new Panel();
            LblHeure = new Label();
            LblDate = new Label();
            LblHeure1 = new Label();
            LblDate1 = new Label();
            groupBox5 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label10 = new Label();
            label9 = new Label();
            Lst4 = new ListBox();
            Lst3 = new ListBox();
            Lst2 = new ListBox();
            Lst1 = new ListBox();
            label13 = new Label();
            TxtScore = new TextBox();
            CmbAge = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 41);
            label1.Name = "label1";
            label1.Size = new Size(231, 41);
            label1.TabIndex = 0;
            label1.Text = "Calcul de Score";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtNom);
            groupBox1.Controls.Add(TxtPrenom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtTel);
            groupBox1.Controls.Add(TxtCin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(71, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations";
            // 
            // TxtNom
            // 
            TxtNom.Location = new Point(485, 30);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(227, 23);
            TxtNom.TabIndex = 7;
            // 
            // TxtPrenom
            // 
            TxtPrenom.Location = new Point(485, 60);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.Size = new Size(227, 23);
            TxtPrenom.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 64);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Prénom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 34);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Nom";
            // 
            // TxtTel
            // 
            TxtTel.Location = new Point(68, 61);
            TxtTel.Name = "TxtTel";
            TxtTel.Size = new Size(234, 23);
            TxtTel.TabIndex = 3;
            // 
            // TxtCin
            // 
            TxtCin.Location = new Point(68, 30);
            TxtCin.MaxLength = 8;
            TxtCin.Name = "TxtCin";
            TxtCin.Size = new Size(234, 23);
            TxtCin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 64);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 1;
            label3.Text = "Tél";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 0;
            label2.Text = "CIN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtTech);
            groupBox2.Controls.Add(TxtLang);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(71, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Notes";
            // 
            // TxtTech
            // 
            TxtTech.Location = new Point(107, 64);
            TxtTech.Name = "TxtTech";
            TxtTech.Size = new Size(142, 23);
            TxtTech.TabIndex = 3;
            TxtTech.Text = "0";
            TxtTech.TextChanged += TxtTech_TextChanged;
            // 
            // TxtLang
            // 
            TxtLang.Location = new Point(107, 28);
            TxtLang.Name = "TxtLang";
            TxtLang.Size = new Size(142, 23);
            TxtLang.TabIndex = 2;
            TxtLang.Text = "0";
            TxtLang.TextChanged += TxtLang_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 67);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 1;
            label8.Text = "Technique";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 31);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 0;
            label7.Text = "Langue";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RdFem);
            groupBox3.Controls.Add(RdMas);
            groupBox3.Location = new Point(543, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sexe";
            // 
            // RdFem
            // 
            RdFem.AutoSize = true;
            RdFem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RdFem.Location = new Point(113, 63);
            RdFem.Name = "RdFem";
            RdFem.Size = new Size(68, 19);
            RdFem.TabIndex = 4;
            RdFem.TabStop = true;
            RdFem.Text = "Féminin";
            RdFem.UseVisualStyleBackColor = true;
            // 
            // RdMas
            // 
            RdMas.AutoSize = true;
            RdMas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RdMas.Location = new Point(113, 27);
            RdMas.Name = "RdMas";
            RdMas.Size = new Size(73, 19);
            RdMas.TabIndex = 3;
            RdMas.TabStop = true;
            RdMas.Text = "Masculin";
            RdMas.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ChkDip);
            groupBox4.Controls.Add(ChkMotiv);
            groupBox4.Controls.Add(ChkExper);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Location = new Point(71, 362);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(774, 65);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bonus";
            // 
            // ChkDip
            // 
            ChkDip.AutoSize = true;
            ChkDip.Location = new Point(582, 26);
            ChkDip.Name = "ChkDip";
            ChkDip.Size = new Size(76, 19);
            ChkDip.TabIndex = 6;
            ChkDip.Text = "Diplomes";
            ChkDip.UseVisualStyleBackColor = true;
            // 
            // ChkMotiv
            // 
            ChkMotiv.AutoSize = true;
            ChkMotiv.Location = new Point(340, 29);
            ChkMotiv.Name = "ChkMotiv";
            ChkMotiv.Size = new Size(89, 19);
            ChkMotiv.TabIndex = 5;
            ChkMotiv.Text = "Motivations";
            ChkMotiv.UseVisualStyleBackColor = true;
            // 
            // ChkExper
            // 
            ChkExper.AutoSize = true;
            ChkExper.Location = new Point(49, 30);
            ChkExper.Name = "ChkExper";
            ChkExper.Size = new Size(166, 19);
            ChkExper.TabIndex = 4;
            ChkExper.Text = "Experience Professionnelle";
            ChkExper.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 30);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(68, 30);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 457);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 6;
            label6.Text = "Age";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(471, 457);
            label14.Name = "label14";
            label14.Size = new Size(96, 15);
            label14.TabIndex = 7;
            label14.Text = "Valeur de chance";
            // 
            // BtnChance
            // 
            BtnChance.Location = new Point(770, 453);
            BtnChance.Name = "BtnChance";
            BtnChance.Size = new Size(75, 23);
            BtnChance.TabIndex = 8;
            BtnChance.Text = "Générer";
            BtnChance.UseVisualStyleBackColor = true;
            BtnChance.Click += BtnChance_Click;
            // 
            // TxtChance
            // 
            TxtChance.Location = new Point(573, 453);
            TxtChance.Name = "TxtChance";
            TxtChance.ReadOnly = true;
            TxtChance.Size = new Size(156, 23);
            TxtChance.TabIndex = 9;
            TxtChance.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnAjout);
            panel1.Controls.Add(BtnCalc);
            panel1.Controls.Add(BtnQuit);
            panel1.Controls.Add(BtnInit);
            panel1.Location = new Point(71, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 50);
            panel1.TabIndex = 10;
            // 
            // BtnAjout
            // 
            BtnAjout.Enabled = false;
            BtnAjout.Location = new Point(400, 13);
            BtnAjout.Name = "BtnAjout";
            BtnAjout.Size = new Size(170, 23);
            BtnAjout.TabIndex = 3;
            BtnAjout.Text = "Ajouter";
            BtnAjout.UseVisualStyleBackColor = true;
            BtnAjout.Click += BtnAjout_Click;
            // 
            // BtnCalc
            // 
            BtnCalc.Location = new Point(210, 13);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(170, 23);
            BtnCalc.TabIndex = 2;
            BtnCalc.Text = "Calculer";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // BtnQuit
            // 
            BtnQuit.Location = new Point(589, 13);
            BtnQuit.Name = "BtnQuit";
            BtnQuit.Size = new Size(170, 23);
            BtnQuit.TabIndex = 1;
            BtnQuit.Text = "Quitter";
            BtnQuit.UseVisualStyleBackColor = true;
            BtnQuit.Click += BtnQuit_Click;
            // 
            // BtnInit
            // 
            BtnInit.Location = new Point(21, 13);
            BtnInit.Name = "BtnInit";
            BtnInit.Size = new Size(170, 23);
            BtnInit.TabIndex = 0;
            BtnInit.Text = "Initialiser";
            BtnInit.UseVisualStyleBackColor = true;
            BtnInit.Click += BtnInit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblHeure);
            panel2.Controls.Add(LblDate);
            panel2.Controls.Add(LblHeure1);
            panel2.Controls.Add(LblDate1);
            panel2.Location = new Point(460, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 56);
            panel2.TabIndex = 11;
            // 
            // LblHeure
            // 
            LblHeure.AutoSize = true;
            LblHeure.Location = new Point(292, 20);
            LblHeure.Name = "LblHeure";
            LblHeure.Size = new Size(44, 15);
            LblHeure.TabIndex = 3;
            LblHeure.Text = "label18";
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Location = new Point(83, 20);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(44, 15);
            LblDate.TabIndex = 2;
            LblDate.Text = "label17";
            // 
            // LblHeure1
            // 
            LblHeure1.AutoSize = true;
            LblHeure1.Location = new Point(225, 20);
            LblHeure1.Name = "LblHeure1";
            LblHeure1.Size = new Size(48, 15);
            LblHeure1.TabIndex = 1;
            LblHeure1.Text = "Heure : ";
            // 
            // LblDate1
            // 
            LblDate1.AutoSize = true;
            LblDate1.Location = new Point(33, 20);
            LblDate1.Name = "LblDate1";
            LblDate1.Size = new Size(37, 15);
            LblDate1.TabIndex = 0;
            LblDate1.Text = "Date :";
            LblDate1.Click += label9_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(Lst4);
            groupBox5.Controls.Add(Lst3);
            groupBox5.Controls.Add(Lst2);
            groupBox5.Controls.Add(Lst1);
            groupBox5.Location = new Point(346, 569);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(499, 163);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Liste de personnes";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(414, 19);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 14;
            label16.Text = "Score";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(290, 19);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 6;
            label15.Text = "Prénom";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 19);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 5;
            label10.Text = "Nom";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 19);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 4;
            label9.Text = "CIN";
            // 
            // Lst4
            // 
            Lst4.FormattingEnabled = true;
            Lst4.ItemHeight = 15;
            Lst4.Location = new Point(380, 37);
            Lst4.Name = "Lst4";
            Lst4.Size = new Size(104, 109);
            Lst4.TabIndex = 3;
            // 
            // Lst3
            // 
            Lst3.FormattingEnabled = true;
            Lst3.ItemHeight = 15;
            Lst3.Location = new Point(259, 37);
            Lst3.Name = "Lst3";
            Lst3.Size = new Size(104, 109);
            Lst3.TabIndex = 2;
            // 
            // Lst2
            // 
            Lst2.FormattingEnabled = true;
            Lst2.ItemHeight = 15;
            Lst2.Location = new Point(136, 37);
            Lst2.Name = "Lst2";
            Lst2.Size = new Size(104, 109);
            Lst2.TabIndex = 1;
            // 
            // Lst1
            // 
            Lst1.FormattingEnabled = true;
            Lst1.ItemHeight = 15;
            Lst1.Location = new Point(16, 37);
            Lst1.Name = "Lst1";
            Lst1.Size = new Size(104, 109);
            Lst1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(139, 606);
            label13.Name = "label13";
            label13.Size = new Size(77, 32);
            label13.TabIndex = 13;
            label13.Text = "Score";
            // 
            // TxtScore
            // 
            TxtScore.Location = new Point(81, 660);
            TxtScore.Name = "TxtScore";
            TxtScore.ReadOnly = true;
            TxtScore.Size = new Size(181, 23);
            TxtScore.TabIndex = 14;
            TxtScore.Text = "0";
            // 
            // CmbAge
            // 
            CmbAge.FormattingEnabled = true;
            CmbAge.Items.AddRange(new object[] { "20 - 30", "30 - 40", "40 et plus" });
            CmbAge.Location = new Point(139, 454);
            CmbAge.Name = "CmbAge";
            CmbAge.Size = new Size(181, 23);
            CmbAge.TabIndex = 15;
            // 
            // Calcul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 739);
            Controls.Add(CmbAge);
            Controls.Add(TxtScore);
            Controls.Add(label13);
            Controls.Add(groupBox5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TxtChance);
            Controls.Add(BtnChance);
            Controls.Add(label14);
            Controls.Add(label6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Calcul";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox TxtTel;
        private TextBox TxtCin;
        private Label label3;
        private Label label2;
        private TextBox TxtNom;
        private TextBox TxtPrenom;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label14;
        private Button BtnChance;
        private TextBox TxtChance;
        private Panel panel1;
        private Button BtnAjout;
        private Button BtnCalc;
        private Button BtnQuit;
        private Button BtnInit;
        private TextBox TxtTech;
        private TextBox TxtLang;
        private RadioButton RdFem;
        private RadioButton RdMas;
        private CheckBox ChkDip;
        private CheckBox ChkMotiv;
        private CheckBox ChkExper;
        private Panel panel2;
        private Label LblHeure1;
        private Label LblDate1;
        private GroupBox groupBox5;
        private Label label13;
        private TextBox TxtScore;
        private Label label10;
        private Label label9;
        private ListBox Lst4;
        private ListBox Lst3;
        private ListBox Lst2;
        private ListBox Lst1;
        private Label label16;
        private Label label15;
        private ComboBox CmbAge;
        private System.Windows.Forms.Timer timer1;
        private Label LblHeure;
        private Label LblDate;
    }
}
