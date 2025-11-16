using System.Drawing.Text;

namespace A4_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Methode wenn für Button-Klick
        private void Cmd_Bestimmen_Click(object sender, EventArgs e)
        {
            int zahl1 = (int)NumZahl1.Value;//Konvertierung von Decimal zu Int inkl Wert auslesen
            int zahl2 = (int)NumZahl2.Value;//Konvertierung von Decimal zu Int inkl Wert auslesen

            if (zahl1 > zahl2)
            {
                NumZahl1.BackColor = Color.Green;//Hintergrundfarbe Grün
                LblZahl1.Visible = true;
                LblZahl1.Text = "Zahl 1 ist grösser !";
            }
            else if (zahl1 < zahl2)
            {
                NumZahl2.BackColor = Color.Green;//Hintergrundfarbe Grün
                LblZahl2.Visible = true;
            }
            else
            {
                NumZahl1.BackColor = Color.Red;  //Hintergrundfarbe Rot
                NumZahl2.BackColor = Color.Red;//Hintergrundfarbe Rot
                LblZahl1.Visible = true;
                LblZahl1.Text = "Zahl2 ist gleich gross wie Zahl 1!";
            }
        }

            //Löschen der Texte und Rücksetzten der Hintergrundfarbe
            private void ValueChanged(object sender, EventArgs e)
            {
                NumZahl1.BackColor=Color.White;//Hintergrundfarbe Weiss
                NumZahl2.BackColor=Color.White;//Hintergrundfarbe Weiss
                LblZahl1.Visible=false;
                LblZahl2.Visible=false;
            }
        }
    }
