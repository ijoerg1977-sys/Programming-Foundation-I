namespace A1_2_4
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
            CmdFensterhöhegrösser = new Button();
            CmdFensterhöhekleiner = new Button();
            CmdFensterbreitegrösser = new Button();
            CmdFensterbreitekleiner = new Button();
            LblPos = new Label();
            LblDimension = new Label();
            Lbl_Position = new Label();
            Lbl_Grösse = new Label();
            SuspendLayout();
            // 
            // CmdFensterhöhegrösser
            // 
            CmdFensterhöhegrösser.Location = new Point(28, 52);
            CmdFensterhöhegrösser.Name = "CmdFensterhöhegrösser";
            CmdFensterhöhegrösser.Size = new Size(209, 23);
            CmdFensterhöhegrösser.TabIndex = 0;
            CmdFensterhöhegrösser.Text = "Fensterhöhe vergrössern";
            CmdFensterhöhegrösser.UseVisualStyleBackColor = true;
            CmdFensterhöhegrösser.Click += CmdFensterhöhegrösser_Click;
            // 
            // CmdFensterhöhekleiner
            // 
            CmdFensterhöhekleiner.Location = new Point(28, 81);
            CmdFensterhöhekleiner.Name = "CmdFensterhöhekleiner";
            CmdFensterhöhekleiner.Size = new Size(209, 23);
            CmdFensterhöhekleiner.TabIndex = 1;
            CmdFensterhöhekleiner.Text = "Fensterhöhe verkleinern";
            CmdFensterhöhekleiner.UseVisualStyleBackColor = true;
            CmdFensterhöhekleiner.Click += CmdFensterhöhekleiner_Click;
            // 
            // CmdFensterbreitegrösser
            // 
            CmdFensterbreitegrösser.Location = new Point(28, 110);
            CmdFensterbreitegrösser.Name = "CmdFensterbreitegrösser";
            CmdFensterbreitegrösser.Size = new Size(209, 23);
            CmdFensterbreitegrösser.TabIndex = 2;
            CmdFensterbreitegrösser.Text = "Fensterbreite vergrössern";
            CmdFensterbreitegrösser.UseVisualStyleBackColor = true;
            CmdFensterbreitegrösser.Click += CmdFensterbreitegrösser_Click;
            // 
            // CmdFensterbreitekleiner
            // 
            CmdFensterbreitekleiner.Location = new Point(28, 139);
            CmdFensterbreitekleiner.Name = "CmdFensterbreitekleiner";
            CmdFensterbreitekleiner.Size = new Size(209, 23);
            CmdFensterbreitekleiner.TabIndex = 3;
            CmdFensterbreitekleiner.Text = "Fensterbreite verkleinern";
            CmdFensterbreitekleiner.UseVisualStyleBackColor = true;
            CmdFensterbreitekleiner.Click += CmdFensterbreitekleiner_Click;
            // 
            // LblPos
            // 
            LblPos.AutoSize = true;
            LblPos.Location = new Point(12, 212);
            LblPos.Name = "LblPos";
            LblPos.Size = new Size(56, 15);
            LblPos.TabIndex = 4;
            LblPos.Text = "Position :";
            // 
            // LblDimension
            // 
            LblDimension.AutoSize = true;
            LblDimension.Location = new Point(170, 212);
            LblDimension.Name = "LblDimension";
            LblDimension.Size = new Size(67, 15);
            LblDimension.TabIndex = 5;
            LblDimension.Text = "Dimension:";
            // 
            // Lbl_Position
            // 
            Lbl_Position.AutoSize = true;
            Lbl_Position.Location = new Point(73, 212);
            Lbl_Position.Name = "Lbl_Position";
            Lbl_Position.Size = new Size(16, 15);
            Lbl_Position.TabIndex = 6;
            Lbl_Position.Text = "...";
            // 
            // Lbl_Grösse
            // 
            Lbl_Grösse.AutoSize = true;
            Lbl_Grösse.Location = new Point(243, 212);
            Lbl_Grösse.Name = "Lbl_Grösse";
            Lbl_Grösse.Size = new Size(16, 15);
            Lbl_Grösse.TabIndex = 7;
            Lbl_Grösse.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(Lbl_Grösse);
            Controls.Add(Lbl_Position);
            Controls.Add(LblDimension);
            Controls.Add(LblPos);
            Controls.Add(CmdFensterbreitekleiner);
            Controls.Add(CmdFensterbreitegrösser);
            Controls.Add(CmdFensterhöhekleiner);
            Controls.Add(CmdFensterhöhegrösser);
            Name = "Form1";
            Text = "Aufgabe A1-2-4";
            Move += Form1_Move;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdFensterhöhegrösser;
        private Button CmdFensterhöhekleiner;
        private Button CmdFensterbreitegrösser;
        private Button CmdFensterbreitekleiner;
        private Label LblPos;
        private Label LblDimension;
        private Label Lbl_Position;
        private Label Lbl_Grösse;
    }
}
