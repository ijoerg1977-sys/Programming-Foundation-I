namespace A6_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int grössereZahl;
        int kleinereZahl;
        int faktor = 1;

        private void Zahlenauslesen()
        {
            int zahl1 = (int)Num_Zahl1.Value;
            int zahl2 = (int)Num_Zahl2.Value;

            if (zahl1 > zahl2)
            {
                grössereZahl = zahl1;
                kleinereZahl = zahl2;
            }
            else
            {
                grössereZahl = zahl2;
                kleinereZahl = zahl1;
            }
        }


        private void Cdm_kgV_bestimmen_Click(object sender, EventArgs e)
        {
            Zahlenauslesen();
            int i = 1;

            while ((kleinereZahl * i) % grössereZahl != 0)
            {
                i++;
            }

            int kgv = kleinereZahl * i;

            Txt_Ausgabe.Text = kgv.ToString();

        }
    }
}
