using System.Windows.Forms;

namespace A6_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zahl1;
        int zahl2;
        int grössereZahl;
        int kleinereZahl;

        private void Zahleneinlesen()
        {
            zahl1 = (int)Num_Zahl1.Value;
            zahl2 = (int)Num_Zahl2.Value;

            if (zahl1 > zahl2)
            {
                grössereZahl = zahl1;
                kleinereZahl = zahl2;
            }
            else if (zahl2 > zahl1)
            {
                grössereZahl = zahl2;
                kleinereZahl = zahl1;
            }
            else
            {
                // Beide Zahlen gleich -> GGT = Zahl selbst
                Txt_GGT.Text = zahl1.ToString();
            }
        }

        private void Num_Zahl1_ValueChanged(object sender, EventArgs e)
        {
            Zahleneinlesen();
        }

        private void Num_Zahl2_ValueChanged(object sender, EventArgs e)
        {
            Zahleneinlesen();
        }

        private void Cmd_Bestimme_GGT_Click(object sender, EventArgs e)
        {
            Zahleneinlesen();

            // Wenn beide Zahlen gleich waren, ist der Wert schon gesetzt
            if (zahl1 == zahl2)
                return;

            int a = grössereZahl;
            int b = kleinereZahl;

            // Algorithmus
            while (a % b != 0)
            {
                int rest = a % b;
                a = b;
                b = rest;
            }

            Txt_GGT.Text = b.ToString();
        }
    }
}

