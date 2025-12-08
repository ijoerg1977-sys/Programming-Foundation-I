namespace A11_1_2
{
    partial class Form1
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
            Lbl_Produktverwaltung = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Lbl_GespeicherteProdukte = new Label();
            Cmd_Speichern = new Button();
            Txt_Verkaufspreis = new TextBox();
            Txt_Einkaufspreis = new TextBox();
            Lbl_Verkaufspreis = new Label();
            Lbl_Einkaufspreis = new Label();
            Txt_Produktname = new TextBox();
            Lbl_Produktname = new Label();
            tabPage2 = new TabPage();
            Txt_Ausgabe = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Produktverwaltung
            // 
            Lbl_Produktverwaltung.AutoSize = true;
            Lbl_Produktverwaltung.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Lbl_Produktverwaltung.Location = new Point(12, 9);
            Lbl_Produktverwaltung.Name = "Lbl_Produktverwaltung";
            Lbl_Produktverwaltung.Size = new Size(188, 25);
            Lbl_Produktverwaltung.TabIndex = 0;
            Lbl_Produktverwaltung.Text = "Produktverwaltung";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(605, 380);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += Cmd_Anzeigen_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Lbl_GespeicherteProdukte);
            tabPage1.Controls.Add(Cmd_Speichern);
            tabPage1.Controls.Add(Txt_Verkaufspreis);
            tabPage1.Controls.Add(Txt_Einkaufspreis);
            tabPage1.Controls.Add(Lbl_Verkaufspreis);
            tabPage1.Controls.Add(Lbl_Einkaufspreis);
            tabPage1.Controls.Add(Txt_Produktname);
            tabPage1.Controls.Add(Lbl_Produktname);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(597, 352);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produkte erstellen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lbl_GespeicherteProdukte
            // 
            Lbl_GespeicherteProdukte.AutoSize = true;
            Lbl_GespeicherteProdukte.Location = new Point(37, 249);
            Lbl_GespeicherteProdukte.Name = "Lbl_GespeicherteProdukte";
            Lbl_GespeicherteProdukte.Size = new Size(129, 15);
            Lbl_GespeicherteProdukte.TabIndex = 7;
            Lbl_GespeicherteProdukte.Text = "Gespeicherte Produkte:";
            // 
            // Cmd_Speichern
            // 
            Cmd_Speichern.BackColor = Color.Gray;
            Cmd_Speichern.Location = new Point(105, 150);
            Cmd_Speichern.Name = "Cmd_Speichern";
            Cmd_Speichern.Size = new Size(187, 42);
            Cmd_Speichern.TabIndex = 6;
            Cmd_Speichern.Text = "Speichern";
            Cmd_Speichern.UseVisualStyleBackColor = false;
            Cmd_Speichern.Click += Cmd_Speichern_Click;
            // 
            // Txt_Verkaufspreis
            // 
            Txt_Verkaufspreis.Location = new Point(105, 106);
            Txt_Verkaufspreis.Name = "Txt_Verkaufspreis";
            Txt_Verkaufspreis.Size = new Size(187, 23);
            Txt_Verkaufspreis.TabIndex = 5;
            // 
            // Txt_Einkaufspreis
            // 
            Txt_Einkaufspreis.Location = new Point(105, 59);
            Txt_Einkaufspreis.Name = "Txt_Einkaufspreis";
            Txt_Einkaufspreis.Size = new Size(187, 23);
            Txt_Einkaufspreis.TabIndex = 4;
            // 
            // Lbl_Verkaufspreis
            // 
            Lbl_Verkaufspreis.AutoSize = true;
            Lbl_Verkaufspreis.Location = new Point(23, 106);
            Lbl_Verkaufspreis.Name = "Lbl_Verkaufspreis";
            Lbl_Verkaufspreis.Size = new Size(76, 15);
            Lbl_Verkaufspreis.TabIndex = 3;
            Lbl_Verkaufspreis.Text = "Verkaufspreis";
            // 
            // Lbl_Einkaufspreis
            // 
            Lbl_Einkaufspreis.AutoSize = true;
            Lbl_Einkaufspreis.Location = new Point(23, 62);
            Lbl_Einkaufspreis.Name = "Lbl_Einkaufspreis";
            Lbl_Einkaufspreis.Size = new Size(76, 15);
            Lbl_Einkaufspreis.TabIndex = 2;
            Lbl_Einkaufspreis.Text = "Einkaufspreis";
            // 
            // Txt_Produktname
            // 
            Txt_Produktname.Location = new Point(105, 11);
            Txt_Produktname.Name = "Txt_Produktname";
            Txt_Produktname.Size = new Size(187, 23);
            Txt_Produktname.TabIndex = 1;
            // 
            // Lbl_Produktname
            // 
            Lbl_Produktname.AutoSize = true;
            Lbl_Produktname.Location = new Point(23, 17);
            Lbl_Produktname.Name = "Lbl_Produktname";
            Lbl_Produktname.Size = new Size(79, 15);
            Lbl_Produktname.TabIndex = 0;
            Lbl_Produktname.Text = "Produktname";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Txt_Ausgabe);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(597, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Produkte verwalten";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(17, 9);
            Txt_Ausgabe.Multiline = true;
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.Size = new Size(505, 330);
            Txt_Ausgabe.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(tabControl1);
            Controls.Add(Lbl_Produktverwaltung);
            Name = "Form1";
            Text = "Aufgabe A11-1-2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Produktverwaltung;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2;
        private TextBox Txt_Einkaufspreis;
        private Label Lbl_Verkaufspreis;
        private Label Lbl_Einkaufspreis;
        private TextBox Txt_Produktname;
        private Label Lbl_Produktname;
        private Button Cmd_Speichern;
        private TextBox Txt_Verkaufspreis;
        private Label Lbl_GespeicherteProdukte;
        private TextBox Txt_Ausgabe;
    }
}
