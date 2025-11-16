namespace A6_2_1
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
            Lbl_Zahl = new Label();
            Txt_Zahl = new TextBox();
            Cmd_Generiere = new Button();
            Cmd_Start = new Button();
            Txt_Ausgabe = new TextBox();
            Lbl_Anzahl_Schleifen = new Label();
            Txt_Anzal_Schleifen = new TextBox();
            SuspendLayout();
            // 
            // Lbl_Zahl
            // 
            Lbl_Zahl.AutoSize = true;
            Lbl_Zahl.Location = new Point(12, 22);
            Lbl_Zahl.Name = "Lbl_Zahl";
            Lbl_Zahl.Size = new Size(33, 15);
            Lbl_Zahl.TabIndex = 0;
            Lbl_Zahl.Text = "Zahl:";
            // 
            // Txt_Zahl
            // 
            Txt_Zahl.Location = new Point(51, 19);
            Txt_Zahl.Name = "Txt_Zahl";
            Txt_Zahl.ReadOnly = true;
            Txt_Zahl.Size = new Size(100, 23);
            Txt_Zahl.TabIndex = 1;
            // 
            // Cmd_Generiere
            // 
            Cmd_Generiere.Location = new Point(168, 18);
            Cmd_Generiere.Name = "Cmd_Generiere";
            Cmd_Generiere.Size = new Size(161, 23);
            Cmd_Generiere.TabIndex = 2;
            Cmd_Generiere.Text = "Generiere Zufallszahl";
            Cmd_Generiere.UseVisualStyleBackColor = true;
            Cmd_Generiere.Click += Cmd_Generiere_Click;
            // 
            // Cmd_Start
            // 
            Cmd_Start.Location = new Point(335, 19);
            Cmd_Start.Name = "Cmd_Start";
            Cmd_Start.Size = new Size(75, 23);
            Cmd_Start.TabIndex = 3;
            Cmd_Start.Text = "Start";
            Cmd_Start.UseVisualStyleBackColor = true;
            Cmd_Start.Click += Cmd_Start_Click;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(12, 48);
            Txt_Ausgabe.Multiline = true;
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.ReadOnly = true;
            Txt_Ausgabe.Size = new Size(400, 314);
            Txt_Ausgabe.TabIndex = 4;
            // 
            // Lbl_Anzahl_Schleifen
            // 
            Lbl_Anzahl_Schleifen.AutoSize = true;
            Lbl_Anzahl_Schleifen.Location = new Point(12, 386);
            Lbl_Anzahl_Schleifen.Name = "Lbl_Anzahl_Schleifen";
            Lbl_Anzahl_Schleifen.Size = new Size(183, 15);
            Lbl_Anzahl_Schleifen.TabIndex = 5;
            Lbl_Anzahl_Schleifen.Text = "Anzahl Schleifenwiederholungen:";
            // 
            // Txt_Anzal_Schleifen
            // 
            Txt_Anzal_Schleifen.Location = new Point(201, 383);
            Txt_Anzal_Schleifen.Name = "Txt_Anzal_Schleifen";
            Txt_Anzal_Schleifen.ReadOnly = true;
            Txt_Anzal_Schleifen.Size = new Size(100, 23);
            Txt_Anzal_Schleifen.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(Txt_Anzal_Schleifen);
            Controls.Add(Lbl_Anzahl_Schleifen);
            Controls.Add(Txt_Ausgabe);
            Controls.Add(Cmd_Start);
            Controls.Add(Cmd_Generiere);
            Controls.Add(Txt_Zahl);
            Controls.Add(Lbl_Zahl);
            Name = "Form1";
            Text = "Aufgabe A6-2-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Zahl;
        private TextBox Txt_Zahl;
        private Button Cmd_Generiere;
        private Button Cmd_Start;
        private TextBox Txt_Ausgabe;
        private Label Lbl_Anzahl_Schleifen;
        private TextBox Txt_Anzal_Schleifen;
    }
}
