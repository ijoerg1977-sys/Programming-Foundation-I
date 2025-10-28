namespace A2_1_3
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
            LblZahl1 = new Label();
            TxtZahl1 = new TextBox();
            LblZahl2 = new Label();
            TxtZahl2 = new TextBox();
            LblResultat = new Label();
            TxtResultat = new TextBox();
            CdmAddition = new Button();
            CmdSubtraction = new Button();
            CmdMultiplikation = new Button();
            CmdDiffision = new Button();
            SuspendLayout();
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(40, 38);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(45, 15);
            LblZahl1.TabIndex = 0;
            LblZahl1.Text = "Zahl 1 :";
            // 
            // TxtZahl1
            // 
            TxtZahl1.Location = new Point(97, 35);
            TxtZahl1.Name = "TxtZahl1";
            TxtZahl1.Size = new Size(148, 23);
            TxtZahl1.TabIndex = 1;
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(40, 78);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(45, 15);
            LblZahl2.TabIndex = 2;
            LblZahl2.Text = "Zahl 2 :";
            // 
            // TxtZahl2
            // 
            TxtZahl2.Location = new Point(97, 78);
            TxtZahl2.Name = "TxtZahl2";
            TxtZahl2.Size = new Size(148, 23);
            TxtZahl2.TabIndex = 3;
            // 
            // LblResultat
            // 
            LblResultat.AutoSize = true;
            LblResultat.Location = new Point(40, 122);
            LblResultat.Name = "LblResultat";
            LblResultat.Size = new Size(58, 15);
            LblResultat.TabIndex = 4;
            LblResultat.Text = "Resultat : ";
            // 
            // TxtResultat
            // 
            TxtResultat.BackColor = Color.LightGreen;
            TxtResultat.Location = new Point(97, 119);
            TxtResultat.Name = "TxtResultat";
            TxtResultat.Size = new Size(148, 23);
            TxtResultat.TabIndex = 5;
            // 
            // CdmAddition
            // 
            CdmAddition.BackColor = Color.Silver;
            CdmAddition.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CdmAddition.Location = new Point(40, 172);
            CdmAddition.Name = "CdmAddition";
            CdmAddition.Size = new Size(45, 45);
            CdmAddition.TabIndex = 6;
            CdmAddition.Text = "+";
            CdmAddition.UseVisualStyleBackColor = false;
            CdmAddition.Click += CdmAddition_Click;
            // 
            // CmdSubtraction
            // 
            CmdSubtraction.BackColor = Color.Silver;
            CmdSubtraction.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmdSubtraction.Location = new Point(97, 172);
            CmdSubtraction.Name = "CmdSubtraction";
            CmdSubtraction.Size = new Size(45, 45);
            CmdSubtraction.TabIndex = 7;
            CmdSubtraction.Text = "-";
            CmdSubtraction.UseVisualStyleBackColor = false;
            CmdSubtraction.Click += CmdSubtraction_Click;
            // 
            // CmdMultiplikation
            // 
            CmdMultiplikation.BackColor = Color.Silver;
            CmdMultiplikation.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmdMultiplikation.Location = new Point(155, 172);
            CmdMultiplikation.Name = "CmdMultiplikation";
            CmdMultiplikation.Size = new Size(45, 45);
            CmdMultiplikation.TabIndex = 8;
            CmdMultiplikation.Text = "x";
            CmdMultiplikation.UseVisualStyleBackColor = false;
            CmdMultiplikation.Click += CmdMultiplikation_Click;
            // 
            // CmdDiffision
            // 
            CmdDiffision.BackColor = Color.Silver;
            CmdDiffision.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CmdDiffision.Location = new Point(208, 171);
            CmdDiffision.Name = "CmdDiffision";
            CmdDiffision.Size = new Size(45, 45);
            CmdDiffision.TabIndex = 9;
            CmdDiffision.Text = "/";
            CmdDiffision.UseVisualStyleBackColor = false;
            CmdDiffision.Click += CmdDiffision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 252);
            Controls.Add(CmdDiffision);
            Controls.Add(CmdMultiplikation);
            Controls.Add(CmdSubtraction);
            Controls.Add(CdmAddition);
            Controls.Add(TxtResultat);
            Controls.Add(LblResultat);
            Controls.Add(TxtZahl2);
            Controls.Add(LblZahl2);
            Controls.Add(TxtZahl1);
            Controls.Add(LblZahl1);
            Name = "Form1";
            Text = "Einfacher Rechner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl1;
        private TextBox TxtZahl1;
        private Label LblZahl2;
        private TextBox TxtZahl2;
        private Label LblResultat;
        private TextBox TxtResultat;
        private Button CdmAddition;
        private Button CmdSubtraction;
        private Button CmdMultiplikation;
        private Button CmdDiffision;
    }
}
