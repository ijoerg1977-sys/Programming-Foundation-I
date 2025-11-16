using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace A3_1_6
{
    public partial class Form1 : Form
    {
        // Variablen für alle Byte-Werte
        int x1, x2, x4, x8, x16, x32, x64, x128;
        int y1, y2, y4, y8, y16, y32, y64, y128;
        int summe1;
        int summe2;
        int summe1und2;
        int binär1;
        int binär2;
        int oderbinär;

        public Form1()
        {
            InitializeComponent();
        }


        // Hilfsmethode um Summe Byte 1 zu aktualisieren
        private void AktualisiereSumme1()
        {
            summe1 = x1 * 1 + x2 * 2 + x4 * 4 + x8 * 8 + x16 * 16 + x32 * 32 + x64 * 64 + x128 * 128; // Berechnung der Summe
            Lbl_Dezimal_Byte1.Text = "Dezimal" + "  " + summe1.ToString(); // Anzeige der Summe

        }
        // Hilfsmethode um Summe Byte 2 zu aktualisieren
        private void AktualisiereSumme2()
        {
            summe2 = y1 * 1 + y2 * 2 + y4 * 4 + y8 * 8 + y16 * 16 + y32 * 32 + y64 * 64 + y128 * 128; // Berechnung der Summe
            Lbl_Dezimal_Byte2.Text = "Dezimal" + "  " + summe2.ToString();// Anzeige der Summe

        }
        // Ereignismethoden für alle NumericUpDown-Steuerelemente
        private void Num_Byte1_Wert1_ValueChanged(object sender, EventArgs e)
        {
            x1 = (int)Num_Byte1_Wert1.Value; // Wert auslesen
            AktualisiereSumme1();// Summe aktualisieren
        }

        private void Num_Byte1_Wert2_ValueChanged(object sender, EventArgs e)
        {
            x2 = (int)Num_Byte1_Wert2.Value;
            AktualisiereSumme1();
        }

        private void Num_Byte1_Wert4_ValueChanged(object sender, EventArgs e)
        {
            x4 = (int)Num_Byte1_Wert4.Value;
            AktualisiereSumme1();
        }
        private void Num_Byte1_Wert8_ValueChanged(object sender, EventArgs e)
        {
            x8 = (int)Num_Byte1_Wert8.Value;
            AktualisiereSumme1();
        }
        private void Num_Byte1_Wert16_ValueChanged(object sender, EventArgs e)
        {
            x16 = (int)Num_Byte1_Wert16.Value;
            AktualisiereSumme1();
        }
        private void Num_Byte1_Wert32_ValueChanged(object sender, EventArgs e)
        {
            x32 = (int)Num_Byte1_Wert32.Value;
            AktualisiereSumme1();
        }
        private void Num_Byte1_Wert64_ValueChanged(object sender, EventArgs e)
        {
            x64 = (int)Num_Byte1_Wert64.Value;
            AktualisiereSumme1();
        }
        private void Num_Byte1_Wert128_ValueChanged(object sender, EventArgs e)
        {
            x128 = (int)Num_Byte1_Wert128.Value;
            AktualisiereSumme1();
        }
        private void Num_Byte2_Wert1_ValueChanged(object sender, EventArgs e)
        {
            y1 = (int)Num_Byte2_Wert1.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert2_ValueChanged(object sender, EventArgs e)
        {
            y2 = (int)Num_Byte2_Wert2.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert4_ValueChanged(object sender, EventArgs e)
        {
            y4 = (int)Num_Byte2_Wert4.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert8_ValueChanged(object sender, EventArgs e)
        {
            y8 = (int)Num_Byte2_Wert8.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert16_ValueChanged(object sender, EventArgs e)
        {
            y16 = (int)Num_Byte2_Wert16.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert32_ValueChanged(object sender, EventArgs e)
        {
            y32 = (int)Num_Byte2_Wert32.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert64_ValueChanged(object sender, EventArgs e)
        {
            y64 = (int)Num_Byte2_Wert64.Value;
            AktualisiereSumme2();
        }
        private void Num_Byte2_Wert128_ValueChanged(object sender, EventArgs e)
        {
            y128 = (int)Num_Byte2_Wert128.Value;
            AktualisiereSumme2();
        }

        // Methode für drn AND Button
        private void CmdAND_Click(object sender, EventArgs e)
        {
            summe1und2 = summe1 + summe2;// Berechnung der Summe der beiden Bytes
            string binär1und2 = Convert.ToString(summe1und2, 2).PadLeft(8, '0');// Umwandlung in Binär und Auffüllen auf 8 Stellen
            Lbl_Ergebnis_Dezimal.Text = "Ergebnis Dezimal" + "  " + summe1und2.ToString();// Anzeige des Ergebnisses in Dezimal
            Lbl_Ergebnis_binaer.Text = "Ergebnis Binär" + "  " + binär1und2;// Anzeige des Ergebnisses in Binär
        }

        // Methode für den OR Button
        // Methode für den OR Button
        private void CmdOR_Click(object sender, EventArgs e)
        {
            // Umwandlung der Dezimalzahlen in Binärstrings
            string binär1 = Convert.ToString(summe1, 2);
            string binär2 = Convert.ToString(summe2, 2);

            // Umwandlung der Binärstrings zurück in Ganzzahlen
            int zahl1 = Convert.ToInt32(binär1, 2); // Umwandlung von Binärstring in Integer
            int zahl2 = Convert.ToInt32(binär2, 2); // Umwandlung von Binärstring in Integer

            // Durchführung der OR-Operation
            int oderErgebnis = zahl1 | zahl2;

            // Anzeige des Ergebnisses in Dezimal
            Lbl_Ergebnis_Dezimal.Text = "Ergebnis Dezimal: " + oderErgebnis.ToString();

            // Anzeige des Ergebnisses in Binär (mit führenden Nullen auf 8 Bits aufgefüllt)
            Lbl_Ergebnis_binaer.Text = "Ergebnis Binär: " + Convert.ToString(oderErgebnis, 2).PadLeft(8, '0');
        }


        // Methode für den XOR Button

        private void CmdXOR_Click(object sender, EventArgs e)
        {
            // Umwandlung der Dezimalzahlen in Binärstrings
            string binär1 = Convert.ToString(summe1, 2);
            string binär2 = Convert.ToString(summe2, 2);

            // Umwandlung der Binärstrings zurück in Ganzzahlen
            int zahl1 = Convert.ToInt32(binär1, 2); // Umwandlung von Binärstring in Integer
            int zahl2 = Convert.ToInt32(binär2, 2); // Umwandlung von Binärstring in Integer

            // Durchführung der XOR-Operation
            int xorErgebnis = zahl1 ^ zahl2;

            // Anzeige des Ergebnisses in Dezimal
            Lbl_Ergebnis_Dezimal.Text = "Ergebnis Dezimal: " + xorErgebnis.ToString();

            // Anzeige des Ergebnisses in Binär (mit führenden Nullen auf 8 Bits aufgefüllt)
            Lbl_Ergebnis_binaer.Text = "Ergebnis Binär: " + Convert.ToString(xorErgebnis, 2).PadLeft(8, '0');
        }

    }
}


