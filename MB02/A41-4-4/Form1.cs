namespace A41_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Cmd_Bestimmen_Click(object sender, EventArgs e)
        {

            int zahla = Convert.ToInt32(TxtZahlA.Text);
            int zahlb = Convert.ToInt32(TxtZahlB.Text);

            if (zahla > zahlb)    
            {
                Lbl_Ergebnis.Text = "Zahl A ist größer ";
            }
            else if (zahla < zahlb)
            {
                Lbl_Ergebnis.Text = "Zahl B ist größer ";
            }
            else
            {
                Lbl_Ergebnis.Text = "Die Zahlen sind gleich groß";
            }
        }
    }
}
