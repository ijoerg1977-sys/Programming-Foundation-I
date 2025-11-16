namespace A3_1_1
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
            CmdMontag = new Button();
            CmdDienstag = new Button();
            CmdMittwoch = new Button();
            CmdDonnerstag = new Button();
            CmdFreitag = new Button();
            CmdSamstag = new Button();
            CmdSonntag = new Button();
            LblWochentag = new Label();
            SuspendLayout();
            // 
            // CmdMontag
            // 
            CmdMontag.BackColor = Color.Silver;
            CmdMontag.Location = new Point(39, 42);
            CmdMontag.Name = "CmdMontag";
            CmdMontag.Size = new Size(84, 23);
            CmdMontag.TabIndex = 0;
            CmdMontag.Text = "Montag";
            CmdMontag.UseVisualStyleBackColor = false;
            CmdMontag.Click += CmdMontag_Click;
            // 
            // CmdDienstag
            // 
            CmdDienstag.BackColor = Color.Silver;
            CmdDienstag.Location = new Point(129, 42);
            CmdDienstag.Name = "CmdDienstag";
            CmdDienstag.Size = new Size(86, 23);
            CmdDienstag.TabIndex = 1;
            CmdDienstag.Text = "Dienstag";
            CmdDienstag.UseVisualStyleBackColor = false;
            CmdDienstag.Click += CmdDienstag_Click;
            // 
            // CmdMittwoch
            // 
            CmdMittwoch.BackColor = Color.Silver;
            CmdMittwoch.Location = new Point(221, 42);
            CmdMittwoch.Name = "CmdMittwoch";
            CmdMittwoch.Size = new Size(86, 23);
            CmdMittwoch.TabIndex = 2;
            CmdMittwoch.Text = "Mittwoch";
            CmdMittwoch.UseVisualStyleBackColor = false;
            CmdMittwoch.Click += CmdMittwoch_Click;
            // 
            // CmdDonnerstag
            // 
            CmdDonnerstag.BackColor = Color.Silver;
            CmdDonnerstag.Location = new Point(39, 71);
            CmdDonnerstag.Name = "CmdDonnerstag";
            CmdDonnerstag.Size = new Size(84, 23);
            CmdDonnerstag.TabIndex = 3;
            CmdDonnerstag.Text = "Donnerstag";
            CmdDonnerstag.UseVisualStyleBackColor = false;
            CmdDonnerstag.Click += CmdDonnerstag_Click;
            // 
            // CmdFreitag
            // 
            CmdFreitag.BackColor = Color.Silver;
            CmdFreitag.Location = new Point(129, 71);
            CmdFreitag.Name = "CmdFreitag";
            CmdFreitag.Size = new Size(86, 23);
            CmdFreitag.TabIndex = 4;
            CmdFreitag.Text = "Freitag";
            CmdFreitag.UseVisualStyleBackColor = false;
            CmdFreitag.Click += CmdFreitag_Click;
            // 
            // CmdSamstag
            // 
            CmdSamstag.BackColor = Color.Silver;
            CmdSamstag.Location = new Point(221, 71);
            CmdSamstag.Name = "CmdSamstag";
            CmdSamstag.Size = new Size(86, 23);
            CmdSamstag.TabIndex = 5;
            CmdSamstag.Text = "Samstag";
            CmdSamstag.UseVisualStyleBackColor = false;
            CmdSamstag.Click += CmdSamstag_Click;
            // 
            // CmdSonntag
            // 
            CmdSonntag.BackColor = Color.Silver;
            CmdSonntag.Location = new Point(129, 100);
            CmdSonntag.Name = "CmdSonntag";
            CmdSonntag.Size = new Size(86, 23);
            CmdSonntag.TabIndex = 6;
            CmdSonntag.Text = "Sonntag";
            CmdSonntag.UseVisualStyleBackColor = false;
            CmdSonntag.Click += CmdSonntag_Click;
            // 
            // LblWochentag
            // 
            LblWochentag.AutoSize = true;
            LblWochentag.Location = new Point(39, 170);
            LblWochentag.Name = "LblWochentag";
            LblWochentag.Size = new Size(139, 15);
            LblWochentag.TabIndex = 7;
            LblWochentag.Text = "Numerischer Wochentag";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 230);
            Controls.Add(LblWochentag);
            Controls.Add(CmdSonntag);
            Controls.Add(CmdSamstag);
            Controls.Add(CmdFreitag);
            Controls.Add(CmdDonnerstag);
            Controls.Add(CmdMittwoch);
            Controls.Add(CmdDienstag);
            Controls.Add(CmdMontag);
            Name = "Form1";
            Text = "Anzeige des Wochentages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdMontag;
        private Button CmdDienstag;
        private Button CmdMittwoch;
        private Button CmdDonnerstag;
        private Button CmdFreitag;
        private Button CmdSamstag;
        private Button CmdSonntag;
        private Label LblWochentag;
    }
}
