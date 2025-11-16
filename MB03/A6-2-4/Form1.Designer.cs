namespace A6_2_4
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
            Lbl_ErsteZahl = new Label();
            Lbl_ZweiteZahl = new Label();
            Num_Zahl1 = new NumericUpDown();
            Num_Zahl2 = new NumericUpDown();
            Cdm_kgV_bestimmen = new Button();
            Txt_Ausgabe = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Num_Zahl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_Zahl2).BeginInit();
            SuspendLayout();
            // 
            // Lbl_ErsteZahl
            // 
            Lbl_ErsteZahl.AutoSize = true;
            Lbl_ErsteZahl.Location = new Point(27, 26);
            Lbl_ErsteZahl.Name = "Lbl_ErsteZahl";
            Lbl_ErsteZahl.Size = new Size(39, 15);
            Lbl_ErsteZahl.TabIndex = 0;
            Lbl_ErsteZahl.Text = "1.Zahl";
            // 
            // Lbl_ZweiteZahl
            // 
            Lbl_ZweiteZahl.AutoSize = true;
            Lbl_ZweiteZahl.Location = new Point(27, 58);
            Lbl_ZweiteZahl.Name = "Lbl_ZweiteZahl";
            Lbl_ZweiteZahl.Size = new Size(39, 15);
            Lbl_ZweiteZahl.TabIndex = 1;
            Lbl_ZweiteZahl.Text = "2.Zahl";
            // 
            // Num_Zahl1
            // 
            Num_Zahl1.Location = new Point(72, 24);
            Num_Zahl1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Num_Zahl1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Num_Zahl1.Name = "Num_Zahl1";
            Num_Zahl1.Size = new Size(208, 23);
            Num_Zahl1.TabIndex = 2;
            Num_Zahl1.Value = new decimal(new int[] { 1, 0, 0, 0 });
           
            // 
            // Num_Zahl2
            // 
            Num_Zahl2.Location = new Point(72, 56);
            Num_Zahl2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Num_Zahl2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Num_Zahl2.Name = "Num_Zahl2";
            Num_Zahl2.Size = new Size(208, 23);
            Num_Zahl2.TabIndex = 3;
            Num_Zahl2.Value = new decimal(new int[] { 1, 0, 0, 0 });
           
            // 
            // Cdm_kgV_bestimmen
            // 
            Cdm_kgV_bestimmen.Location = new Point(27, 105);
            Cdm_kgV_bestimmen.Name = "Cdm_kgV_bestimmen";
            Cdm_kgV_bestimmen.Size = new Size(113, 23);
            Cdm_kgV_bestimmen.TabIndex = 4;
            Cdm_kgV_bestimmen.Text = "Bestimme kgV";
            Cdm_kgV_bestimmen.UseVisualStyleBackColor = true;
            Cdm_kgV_bestimmen.Click += Cdm_kgV_bestimmen_Click;
            // 
            // Txt_Ausgabe
            // 
            Txt_Ausgabe.Location = new Point(144, 106);
            Txt_Ausgabe.Name = "Txt_Ausgabe";
            Txt_Ausgabe.Size = new Size(136, 23);
            Txt_Ausgabe.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 140);
            Controls.Add(Txt_Ausgabe);
            Controls.Add(Cdm_kgV_bestimmen);
            Controls.Add(Num_Zahl2);
            Controls.Add(Num_Zahl1);
            Controls.Add(Lbl_ZweiteZahl);
            Controls.Add(Lbl_ErsteZahl);
            Name = "Form1";
            Text = "Aufgabe A6-2-4";
            ((System.ComponentModel.ISupportInitialize)Num_Zahl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_Zahl2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_ErsteZahl;
        private Label Lbl_ZweiteZahl;
        private NumericUpDown Num_Zahl1;
        private NumericUpDown Num_Zahl2;
        private Button Cdm_kgV_bestimmen;
        private TextBox Txt_Ausgabe;
    }
}
