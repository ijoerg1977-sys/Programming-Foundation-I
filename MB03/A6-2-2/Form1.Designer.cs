namespace A6_2_2
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
            Lbl_Ganze_Zahl_eingeben = new Label();
            Num_ganze_Zahl = new NumericUpDown();
            Cmd_Binaerwert_berechnen = new Button();
            Txt_Ausgabe = new TextBox();
            Llb_Binaerwert = new Label();
            ((System.ComponentModel.ISupportInitialize)Num_ganze_Zahl).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Ganze_Zahl_eingeben
            // 
            Lbl_Ganze_Zahl_eingeben.AutoSize = true;
            Lbl_Ganze_Zahl_eingeben.Location = new Point(12, 19);
            Lbl_Ganze_Zahl_eingeben.Name = "Lbl_Ganze_Zahl_eingeben";
            Lbl_Ganze_Zahl_eingeben.Size = new Size(117, 15);
            Lbl_Ganze_Zahl_eingeben.TabIndex = 0;
            Lbl_Ganze_Zahl_eingeben.Text = "Ganze Zahl eingeben";
            // 
            // Num_ganze_Zahl
            // 
            Num_ganze_Zahl.Location = new Point(135, 17);
            Num_ganze_Zahl.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            Num_ganze_Zahl.Name = "Num_ganze_Zahl";
            Num_ganze_Zahl.Size = new Size(120, 23);
            Num_ganze_Zahl.TabIndex = 1;
            Num_ganze_Zahl.ValueChanged += Num_ganze_Zahl_ValueChanged;
            // 
            // Cmd_Binaerwert_berechnen
            // 
            Cmd_Binaerwert_berechnen.Location = new Point(73, 57);
            Cmd_Binaerwert_berechnen.Name = "Cmd_Binaerwert_berechnen";
            Cmd_Binaerwert_berechnen.Size = new Size(146, 23);
            Cmd_Binaerwert_berechnen.TabIndex = 2;
            Cmd_Binaerwert_berechnen.Text = "Binärwert berechnen";
            Cmd_Binaerwert_berechnen.UseVisualStyleBackColor = true;
            Cmd_Binaerwert_berechnen.Click += Cmd_Binaerwert_berechnen_Click;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(12, 111);
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.Size = new Size(243, 23);
            Txt_Ausgabe.TabIndex = 3;
            // 
            // Llb_Binaerwert
            // 
            Llb_Binaerwert.AutoSize = true;
            Llb_Binaerwert.Location = new Point(12, 84);
            Llb_Binaerwert.Name = "Llb_Binaerwert";
            Llb_Binaerwert.Size = new Size(60, 15);
            Llb_Binaerwert.TabIndex = 4;
            Llb_Binaerwert.Text = "Binärwert:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 157);
            Controls.Add(Llb_Binaerwert);
            Controls.Add(Txt_Ausgabe);
            Controls.Add(Cmd_Binaerwert_berechnen);
            Controls.Add(Num_ganze_Zahl);
            Controls.Add(Lbl_Ganze_Zahl_eingeben);
            Name = "Form1";
            Text = "Aufgabe A6-2-2";
            ((System.ComponentModel.ISupportInitialize)Num_ganze_Zahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Ganze_Zahl_eingeben;
        private NumericUpDown Num_ganze_Zahl;
        private Button Cmd_Binaerwert_berechnen;
        private TextBox Txt_Ausgabe;
        private Label Llb_Binaerwert;
    }
}
