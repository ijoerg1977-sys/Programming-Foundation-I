namespace Stromverbrauch
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
            LblEingabe = new Label();
            NumStromverbrauch = new NumericUpDown();
            CmdBerechnen = new Button();
            LblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)NumStromverbrauch).BeginInit();
            SuspendLayout();
            // 
            // LblEingabe
            // 
            LblEingabe.AutoSize = true;
            LblEingabe.Location = new Point(60, 39);
            LblEingabe.Name = "LblEingabe";
            LblEingabe.Size = new Size(88, 15);
            LblEingabe.TabIndex = 0;
            LblEingabe.Text = "Strimverbrauch";
            // 
            // NumStromverbrauch
            // 
            NumStromverbrauch.Location = new Point(164, 37);
            NumStromverbrauch.Name = "NumStromverbrauch";
            NumStromverbrauch.Size = new Size(120, 23);
            NumStromverbrauch.TabIndex = 1;
            // 
            // CmdBerechnen
            // 
            CmdBerechnen.Location = new Point(115, 84);
            CmdBerechnen.Name = "CmdBerechnen";
            CmdBerechnen.Size = new Size(169, 23);
            CmdBerechnen.TabIndex = 2;
            CmdBerechnen.Text = "Berechne Stromverbrauch";
            CmdBerechnen.UseVisualStyleBackColor = true;
            CmdBerechnen.Click += CmdBerechnen_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(94, 132);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(16, 15);
            LblResult.TabIndex = 3;
            LblResult.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResult);
            Controls.Add(CmdBerechnen);
            Controls.Add(NumStromverbrauch);
            Controls.Add(LblEingabe);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumStromverbrauch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEingabe;
        private NumericUpDown NumStromverbrauch;
        private Button CmdBerechnen;
        private Label LblResult;
    }
}
