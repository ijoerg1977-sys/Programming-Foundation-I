namespace A4_2_2
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
            Cnd_Schalten = new Button();
            label1 = new Label();
            Pic_Rot = new PictureBox();
            Pic_Orange = new PictureBox();
            Pic_Grün = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pic_Rot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Orange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Grün).BeginInit();
            SuspendLayout();
            // 
            // Cnd_Schalten
            // 
            Cnd_Schalten.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cnd_Schalten.Location = new Point(57, 246);
            Cnd_Schalten.Name = "Cnd_Schalten";
            Cnd_Schalten.Size = new Size(95, 37);
            Cnd_Schalten.TabIndex = 0;
            Cnd_Schalten.Text = "Schalten";
            Cnd_Schalten.UseVisualStyleBackColor = true;
            Cnd_Schalten.Click += Cnd_Schalten_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 217);
            label1.TabIndex = 1;
            // 
            // Pic_Rot
            // 
            Pic_Rot.BackColor = Color.Red;
            Pic_Rot.Location = new Point(82, 44);
            Pic_Rot.Name = "Pic_Rot";
            Pic_Rot.Size = new Size(45, 50);
            Pic_Rot.TabIndex = 2;
            Pic_Rot.TabStop = false;
            // 
            // Pic_Orange
            // 
            Pic_Orange.BackColor = Color.FromArgb(64, 64, 64);
            Pic_Orange.Location = new Point(82, 103);
            Pic_Orange.Name = "Pic_Orange";
            Pic_Orange.Size = new Size(45, 50);
            Pic_Orange.TabIndex = 3;
            Pic_Orange.TabStop = false;
            // 
            // Pic_Grün
            // 
            Pic_Grün.BackColor = Color.FromArgb(64, 64, 64);
            Pic_Grün.Location = new Point(82, 167);
            Pic_Grün.Name = "Pic_Grün";
            Pic_Grün.Size = new Size(45, 50);
            Pic_Grün.TabIndex = 4;
            Pic_Grün.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 297);
            Controls.Add(Pic_Grün);
            Controls.Add(Pic_Orange);
            Controls.Add(Pic_Rot);
            Controls.Add(label1);
            Controls.Add(Cnd_Schalten);
            Name = "Form1";
            Text = "Aufgabe A4-2-2 Ampel";
            ((System.ComponentModel.ISupportInitialize)Pic_Rot).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Orange).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_Grün).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Cnd_Schalten;
        private Label label1;
        private PictureBox Pic_Rot;
        private PictureBox Pic_Orange;
        private PictureBox Pic_Grün;
    }
}
