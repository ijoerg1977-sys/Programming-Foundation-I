namespace ArrayUebung1
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
            Num_Eingabe = new NumericUpDown();
            Cmd_Hinzufuegen = new Button();
            Cmd_Ausgeben = new Button();
            textBox1 = new TextBox();
            Num_Entfernen = new NumericUpDown();
            Cmd_Entfernen = new Button();
            ((System.ComponentModel.ISupportInitialize)Num_Eingabe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_Entfernen).BeginInit();
            SuspendLayout();
            // 
            // Num_Eingabe
            // 
            Num_Eingabe.Location = new Point(68, 41);
            Num_Eingabe.Name = "Num_Eingabe";
            Num_Eingabe.Size = new Size(120, 23);
            Num_Eingabe.TabIndex = 0;
            Num_Eingabe.ValueChanged += Num_Eingabe_ValueChanged;
            // 
            // Cmd_Hinzufuegen
            // 
            Cmd_Hinzufuegen.Location = new Point(68, 82);
            Cmd_Hinzufuegen.Name = "Cmd_Hinzufuegen";
            Cmd_Hinzufuegen.Size = new Size(120, 23);
            Cmd_Hinzufuegen.TabIndex = 1;
            Cmd_Hinzufuegen.Text = "Hinzufügen";
            Cmd_Hinzufuegen.UseVisualStyleBackColor = true;
            Cmd_Hinzufuegen.Click += Cmd_Hinzufuegen_Click;
            // 
            // Cmd_Ausgeben
            // 
            Cmd_Ausgeben.Location = new Point(68, 128);
            Cmd_Ausgeben.Name = "Cmd_Ausgeben";
            Cmd_Ausgeben.Size = new Size(120, 23);
            Cmd_Ausgeben.TabIndex = 2;
            Cmd_Ausgeben.Text = "Ausgeben";
            Cmd_Ausgeben.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(168, 228);
            textBox1.TabIndex = 3;
            // 
            // Num_Entfernen
            // 
            Num_Entfernen.Location = new Point(70, 431);
            Num_Entfernen.Name = "Num_Entfernen";
            Num_Entfernen.Size = new Size(120, 23);
            Num_Entfernen.TabIndex = 4;
            // 
            // Cmd_Entfernen
            // 
            Cmd_Entfernen.Location = new Point(70, 483);
            Cmd_Entfernen.Name = "Cmd_Entfernen";
            Cmd_Entfernen.Size = new Size(120, 23);
            Cmd_Entfernen.TabIndex = 5;
            Cmd_Entfernen.Text = "Entfernen";
            Cmd_Entfernen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 568);
            Controls.Add(Cmd_Entfernen);
            Controls.Add(Num_Entfernen);
            Controls.Add(textBox1);
            Controls.Add(Cmd_Ausgeben);
            Controls.Add(Cmd_Hinzufuegen);
            Controls.Add(Num_Eingabe);
            Name = "Form1";
            Text = "Array Uebung 1";
            ((System.ComponentModel.ISupportInitialize)Num_Eingabe).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_Entfernen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown Num_Eingabe;
        private Button Cmd_Hinzufuegen;
        private Button Cmd_Ausgeben;
        private TextBox textBox1;
        private NumericUpDown Num_Entfernen;
        private Button Cmd_Entfernen;
    }
}
