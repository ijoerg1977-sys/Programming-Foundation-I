using static System.Windows.Forms.AxHost;

namespace A4_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int state = 0; // Anfangszustand
        private void Cnd_Schalten_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0:
                    Rot();
                    break;
                case 1:
                    RotOrange();
                    break;
                case 2:
                    Grün();
                    break;
                case 3:
                    Orange();
                    break;
            }

            state++; // Zustand erhöhen

            if (state > 3)  // Wenn wir über 3 sind → zurück zu 0
                state = 0;
        }

        private void Rot()
        {
            Pic_Rot.BackColor = Color.Red;
            Pic_Orange.BackColor = Color.Gray;
            Pic_Grün.BackColor = Color.Gray;

        }

        private void RotOrange()
        {
            Pic_Rot.BackColor = Color.Red;
            Pic_Orange.BackColor = Color.Orange;
            Pic_Grün.BackColor = Color.Gray;
        } 

        private void Grün()
        {
            Pic_Rot.BackColor = Color.Gray;
            Pic_Orange.BackColor = Color.Gray;
            Pic_Grün.BackColor = Color.Lime;
        }

        private void Orange()
        {
            Pic_Rot.BackColor = Color.Gray;
            Pic_Orange.BackColor = Color.Orange;
            Pic_Grün.BackColor = Color.Gray;
        }
    }
}
