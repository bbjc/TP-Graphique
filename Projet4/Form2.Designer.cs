namespace Projet4
{
    partial class Form2
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            Txt1 = new TextBox();
            BtnSupprimer1 = new Button();
            BtnVider1 = new Button();
            BtnAjouter1 = new Button();
            BtnTDG1 = new Button();
            BtnDG1 = new Button();
            BtnTGD1 = new Button();
            BtnGD1 = new Button();
            LstD1 = new ListBox();
            LstG1 = new ListBox();
            tabPage2 = new TabPage();
            Txt2 = new TextBox();
            BtnSupprimer2 = new Button();
            BtnVider2 = new Button();
            BtnAjouter2 = new Button();
            BtnTDG2 = new Button();
            BtnDG2 = new Button();
            BtnTGD2 = new Button();
            BtnGD2 = new Button();
            LstD2 = new ListBox();
            LstG2 = new ListBox();
            tabPage3 = new TabPage();
            checkedListBox2 = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            tabPage4 = new TabPage();
            label1 = new Label();
            Txt4 = new TextBox();
            BtnSupprimer4 = new Button();
            BtnVider4 = new Button();
            BtnAjouter4 = new Button();
            LstD4 = new ListBox();
            LstG4 = new ListBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Location = new Point(28, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(740, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Txt1);
            tabPage1.Controls.Add(BtnSupprimer1);
            tabPage1.Controls.Add(BtnVider1);
            tabPage1.Controls.Add(BtnAjouter1);
            tabPage1.Controls.Add(BtnTDG1);
            tabPage1.Controls.Add(BtnDG1);
            tabPage1.Controls.Add(BtnTGD1);
            tabPage1.Controls.Add(BtnGD1);
            tabPage1.Controls.Add(LstD1);
            tabPage1.Controls.Add(LstG1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(732, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1 er Cas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Txt1
            // 
            Txt1.Location = new Point(83, 243);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(88, 23);
            Txt1.TabIndex = 11;
            // 
            // BtnSupprimer1
            // 
            BtnSupprimer1.Location = new Point(83, 294);
            BtnSupprimer1.Name = "BtnSupprimer1";
            BtnSupprimer1.Size = new Size(75, 23);
            BtnSupprimer1.TabIndex = 10;
            BtnSupprimer1.Text = "Supprimer";
            BtnSupprimer1.UseVisualStyleBackColor = true;
            BtnSupprimer1.Click += BtnSupprimer_Click;
            // 
            // BtnVider1
            // 
            BtnVider1.Location = new Point(177, 294);
            BtnVider1.Name = "BtnVider1";
            BtnVider1.Size = new Size(75, 23);
            BtnVider1.TabIndex = 9;
            BtnVider1.Text = "Vider";
            BtnVider1.UseVisualStyleBackColor = true;
            BtnVider1.Click += BtnVider_Click;
            // 
            // BtnAjouter1
            // 
            BtnAjouter1.Location = new Point(177, 243);
            BtnAjouter1.Name = "BtnAjouter1";
            BtnAjouter1.Size = new Size(75, 23);
            BtnAjouter1.TabIndex = 8;
            BtnAjouter1.Text = "Ajouter";
            BtnAjouter1.UseVisualStyleBackColor = true;
            BtnAjouter1.Click += BtnAjouter_Click;
            // 
            // BtnTDG1
            // 
            BtnTDG1.Location = new Point(352, 178);
            BtnTDG1.Name = "BtnTDG1";
            BtnTDG1.Size = new Size(41, 25);
            BtnTDG1.TabIndex = 7;
            BtnTDG1.Text = "<<";
            BtnTDG1.UseVisualStyleBackColor = true;
            // 
            // BtnDG1
            // 
            BtnDG1.Location = new Point(352, 136);
            BtnDG1.Name = "BtnDG1";
            BtnDG1.Size = new Size(41, 25);
            BtnDG1.TabIndex = 6;
            BtnDG1.Text = "<";
            BtnDG1.UseVisualStyleBackColor = true;
            BtnDG1.Click += BtnDG1_Click;
            // 
            // BtnTGD1
            // 
            BtnTGD1.Location = new Point(352, 91);
            BtnTGD1.Name = "BtnTGD1";
            BtnTGD1.Size = new Size(41, 25);
            BtnTGD1.TabIndex = 5;
            BtnTGD1.Text = ">>";
            BtnTGD1.UseVisualStyleBackColor = true;
            // 
            // BtnGD1
            // 
            BtnGD1.Location = new Point(352, 46);
            BtnGD1.Name = "BtnGD1";
            BtnGD1.Size = new Size(41, 25);
            BtnGD1.TabIndex = 4;
            BtnGD1.Text = ">";
            BtnGD1.UseVisualStyleBackColor = true;
            BtnGD1.Click += BtnGD1_Click;
            // 
            // LstD1
            // 
            LstD1.FormattingEnabled = true;
            LstD1.ItemHeight = 15;
            LstD1.Location = new Point(484, 35);
            LstD1.Name = "LstD1";
            LstD1.Size = new Size(169, 184);
            LstD1.TabIndex = 3;
            // 
            // LstG1
            // 
            LstG1.FormattingEnabled = true;
            LstG1.ItemHeight = 15;
            LstG1.Location = new Point(83, 35);
            LstG1.Name = "LstG1";
            LstG1.Size = new Size(169, 184);
            LstG1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Txt2);
            tabPage2.Controls.Add(BtnSupprimer2);
            tabPage2.Controls.Add(BtnVider2);
            tabPage2.Controls.Add(BtnAjouter2);
            tabPage2.Controls.Add(BtnTDG2);
            tabPage2.Controls.Add(BtnDG2);
            tabPage2.Controls.Add(BtnTGD2);
            tabPage2.Controls.Add(BtnGD2);
            tabPage2.Controls.Add(LstD2);
            tabPage2.Controls.Add(LstG2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(732, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2 ème Cas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(59, 264);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(100, 23);
            Txt2.TabIndex = 11;
            // 
            // BtnSupprimer2
            // 
            BtnSupprimer2.Location = new Point(59, 315);
            BtnSupprimer2.Name = "BtnSupprimer2";
            BtnSupprimer2.Size = new Size(75, 23);
            BtnSupprimer2.TabIndex = 10;
            BtnSupprimer2.Text = "Supprimer";
            BtnSupprimer2.UseVisualStyleBackColor = true;
            BtnSupprimer2.Click += BtnSupprimer2_Click;
            // 
            // BtnVider2
            // 
            BtnVider2.Location = new Point(168, 315);
            BtnVider2.Name = "BtnVider2";
            BtnVider2.Size = new Size(75, 23);
            BtnVider2.TabIndex = 9;
            BtnVider2.Text = "Vider";
            BtnVider2.UseVisualStyleBackColor = true;
            BtnVider2.Click += BtnVider2_Click;
            // 
            // BtnAjouter2
            // 
            BtnAjouter2.Location = new Point(168, 264);
            BtnAjouter2.Name = "BtnAjouter2";
            BtnAjouter2.Size = new Size(75, 23);
            BtnAjouter2.TabIndex = 8;
            BtnAjouter2.Text = "Ajouter";
            BtnAjouter2.UseVisualStyleBackColor = true;
            BtnAjouter2.Click += BtnAjouter2_Click;
            // 
            // BtnTDG2
            // 
            BtnTDG2.Location = new Point(346, 192);
            BtnTDG2.Name = "BtnTDG2";
            BtnTDG2.Size = new Size(49, 35);
            BtnTDG2.TabIndex = 7;
            BtnTDG2.Text = "<<";
            BtnTDG2.UseVisualStyleBackColor = true;
            BtnTDG2.Click += BtnTDG2_Click;
            // 
            // BtnDG2
            // 
            BtnDG2.Location = new Point(346, 142);
            BtnDG2.Name = "BtnDG2";
            BtnDG2.Size = new Size(49, 35);
            BtnDG2.TabIndex = 6;
            BtnDG2.Text = "<";
            BtnDG2.UseVisualStyleBackColor = true;
            // 
            // BtnTGD2
            // 
            BtnTGD2.Location = new Point(346, 90);
            BtnTGD2.Name = "BtnTGD2";
            BtnTGD2.Size = new Size(49, 35);
            BtnTGD2.TabIndex = 5;
            BtnTGD2.Text = ">>";
            BtnTGD2.UseVisualStyleBackColor = true;
            BtnTGD2.Click += BtnTGD2_Click;
            // 
            // BtnGD2
            // 
            BtnGD2.Location = new Point(346, 39);
            BtnGD2.Name = "BtnGD2";
            BtnGD2.Size = new Size(49, 35);
            BtnGD2.TabIndex = 4;
            BtnGD2.Text = ">";
            BtnGD2.UseVisualStyleBackColor = true;
            // 
            // LstD2
            // 
            LstD2.FormattingEnabled = true;
            LstD2.ItemHeight = 15;
            LstD2.Location = new Point(490, 30);
            LstD2.Name = "LstD2";
            LstD2.SelectionMode = SelectionMode.MultiExtended;
            LstD2.Size = new Size(184, 214);
            LstD2.TabIndex = 1;
            // 
            // LstG2
            // 
            LstG2.FormattingEnabled = true;
            LstG2.ItemHeight = 15;
            LstG2.Location = new Point(59, 30);
            LstG2.Name = "LstG2";
            LstG2.SelectionMode = SelectionMode.MultiSimple;
            LstG2.Size = new Size(184, 214);
            LstG2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkedListBox2);
            tabPage3.Controls.Add(checkedListBox1);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(732, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3 ème Cas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(490, 57);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(184, 220);
            checkedListBox2.TabIndex = 23;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(59, 57);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(184, 220);
            checkedListBox1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(59, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(168, 342);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Vider";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(168, 291);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Ajouter";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(346, 219);
            button4.Name = "button4";
            button4.Size = new Size(49, 35);
            button4.TabIndex = 17;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(346, 169);
            button5.Name = "button5";
            button5.Size = new Size(49, 35);
            button5.TabIndex = 16;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(346, 117);
            button6.Name = "button6";
            button6.Size = new Size(49, 35);
            button6.TabIndex = 15;
            button6.Text = ">>";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(346, 66);
            button7.Name = "button7";
            button7.Size = new Size(49, 35);
            button7.TabIndex = 14;
            button7.Text = ">";
            button7.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(Txt4);
            tabPage4.Controls.Add(BtnSupprimer4);
            tabPage4.Controls.Add(BtnVider4);
            tabPage4.Controls.Add(BtnAjouter4);
            tabPage4.Controls.Add(LstD4);
            tabPage4.Controls.Add(LstG4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(732, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "4 ème Cas";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(312, 154);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 22;
            label1.Text = "Drag and Drop";
            // 
            // Txt4
            // 
            Txt4.Location = new Point(59, 291);
            Txt4.Name = "Txt4";
            Txt4.Size = new Size(100, 23);
            Txt4.TabIndex = 21;
            // 
            // BtnSupprimer4
            // 
            BtnSupprimer4.Location = new Point(59, 342);
            BtnSupprimer4.Name = "BtnSupprimer4";
            BtnSupprimer4.Size = new Size(75, 23);
            BtnSupprimer4.TabIndex = 20;
            BtnSupprimer4.Text = "Supprimer";
            BtnSupprimer4.UseVisualStyleBackColor = true;
            BtnSupprimer4.Click += BtnSupprimer4_Click;
            // 
            // BtnVider4
            // 
            BtnVider4.Location = new Point(168, 342);
            BtnVider4.Name = "BtnVider4";
            BtnVider4.Size = new Size(75, 23);
            BtnVider4.TabIndex = 19;
            BtnVider4.Text = "Vider";
            BtnVider4.UseVisualStyleBackColor = true;
            BtnVider4.Click += BtnVider4_Click;
            // 
            // BtnAjouter4
            // 
            BtnAjouter4.Location = new Point(168, 291);
            BtnAjouter4.Name = "BtnAjouter4";
            BtnAjouter4.Size = new Size(75, 23);
            BtnAjouter4.TabIndex = 18;
            BtnAjouter4.Text = "Ajouter";
            BtnAjouter4.UseVisualStyleBackColor = true;
            BtnAjouter4.Click += BtnAjouter4_Click;
            // 
            // LstD4
            // 
            LstD4.AllowDrop = true;
            LstD4.FormattingEnabled = true;
            LstD4.ItemHeight = 15;
            LstD4.Location = new Point(490, 57);
            LstD4.Name = "LstD4";
            LstD4.Size = new Size(184, 214);
            LstD4.TabIndex = 13;
            LstD4.DragDrop += LstD4_DragDrop;
            LstD4.DragEnter += LstD4_DragEnter;
            LstD4.MouseDown += LstD4_MouseDown;
            // 
            // LstG4
            // 
            LstG4.AllowDrop = true;
            LstG4.FormattingEnabled = true;
            LstG4.ItemHeight = 15;
            LstG4.Location = new Point(59, 57);
            LstG4.Name = "LstG4";
            LstG4.Size = new Size(184, 214);
            LstG4.TabIndex = 12;
            LstG4.DragDrop += LstG4_DragDrop;
            LstG4.DragEnter += LstG4_DragEnter;
            LstG4.MouseDown += LstG4_MouseDown;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 505);
            Controls.Add(tabControl);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox Txt1;
        private Button BtnSupprimer1;
        private Button BtnVider1;
        private Button BtnAjouter1;
        private Button BtnTDG1;
        private Button BtnDG1;
        private Button BtnTGD1;
        private Button BtnGD1;
        private ListBox LstD1;
        private ListBox LstG1;
        private TextBox Txt2;
        private Button BtnSupprimer2;
        private Button BtnVider2;
        private Button BtnAjouter2;
        private Button BtnTDG2;
        private Button BtnDG2;
        private Button BtnTGD2;
        private Button BtnGD2;
        private ListBox LstD2;
        private ListBox LstG2;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private TextBox Txt4;
        private Button BtnSupprimer4;
        private Button BtnVider4;
        private Button BtnAjouter4;
        private ListBox LstD4;
        private ListBox LstG4;
    }
}