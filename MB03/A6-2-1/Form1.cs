namespace A6_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        double zufallszahl;
        int anzahl;

        private void Cmd_Generiere_Click(object sender, EventArgs e)
        {
            Txt_Ausgabe.Clear();
            Random r = new Random();
            zufallszahl = r.Next(10, 10000);
            Txt_Zahl.Text = zufallszahl.ToString();
        }

        private void Cmd_Start_Click(object sender, EventArgs e)
        {
            // Prüfen, ob schon eine Zufallszahl existiert
            if (zufallszahl <= 1)
            {
                MessageBox.Show("Bitte zuerst eine Zahl generieren!");
                return; // Verarbeitung abbrechen
            }

            // Solange die Zahl größer als 1 ist halbieren
            while (zufallszahl > 1)
            {
                double zufallszahlneu = zufallszahl / 2;

                // Eine neue Zeile ausgeben
                Txt_Ausgabe.AppendText(Environment.NewLine +
                    zufallszahl + " /2 = " + zufallszahlneu);

                zufallszahl = zufallszahlneu;

                anzahl++;
                Txt_Anzal_Schleifen.Text = anzahl.ToString();
            }
        }
    }
}

