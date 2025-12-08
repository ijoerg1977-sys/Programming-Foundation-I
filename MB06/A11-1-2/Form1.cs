namespace A11_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Deklaration der Zählvariable
        int anzahl = 0;

        // Deklaration des Arrays für die Produktliste (20 Produkte, 2 Eigenschaften)
        string[,] produktliste = new string[20, 3]; // [Produktname, Einkauspreis, Verkaufspreis]

        private int x;
        private int y;

        private void Cmd_Speichern_Click(object sender, EventArgs e)
        {
            //Überprüfung ob das Array voll ist
            if (anzahl >= 19)
            {
                MessageBox.Show("Der Speicherplatz voll. Es können nur 20 Produkte gespeichert werden.", "Speicher voll", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmd_Speichern.Enabled = false;
                return;
            }
            Product product = new Product();

            //Eingabe Produktname
            product.name = Txt_Produktname.Text;
            produktliste[x, y] = product.name;


            //Eine Spalte weiter
            y += 1;

            //Eingabe Einkaufspreis
            product.purchasingPrice = Double.Parse(Txt_Einkaufspreis.Text);
            produktliste[x, y] = product.purchasingPrice.ToString();

            //Eine Spalte weiter
            y += 1;

            //Eingabe Verkaufspreis
            product.retailPrice = Double.Parse(Txt_Verkaufspreis.Text);
            produktliste[x, y] = product.retailPrice.ToString();

            //Zurück zur ersten Spalte
            x += 1;
            y -= 2;

            //Produkte Zählvariable erhöhen
            anzahl += 1;

            //Anzahl gespeicherte Produkte anzeigen
            Lbl_GespeicherteProdukte.Text = $"Gespeicherte Produkte: {anzahl}";

            //Eingabefelder leeren  
            Txt_Produktname.Clear();
            Txt_Einkaufspreis.Clear();
            Txt_Verkaufspreis.Clear();

            //Cursor in erstes Eingabefeld setzen
            Txt_Produktname.Focus();
        }

        private void Cmd_Anzeigen_Click(object sender, EventArgs e)
        {
            Txt_Ausgabe.Clear();

            int a = 0;

            for (int i = 0; i < anzahl; i++)
            {
                Txt_Ausgabe.AppendText($"Produkt: {produktliste[a, 0]} Einkaufspreis: {produktliste[a, 1]} CHF, Verkaufspreis: {produktliste[a, 2]} CHF {Environment.NewLine}");
                a += 1;
            }

        }

        class Product
        {
            internal string name { get; set; }
            internal double purchasingPrice { get; set; }
            internal double retailPrice { get; set; }
        }


    }
}

