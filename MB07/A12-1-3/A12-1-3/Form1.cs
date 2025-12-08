using System.Security.Cryptography.Pkcs;

namespace A12_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Definieren der Klasse Person
        class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }

            // Konstructor
            public Person(string firstname, string lastname, int age)
            {
                Firstname = firstname;
                Lastname = lastname;
                Age = age;
            }

            // Methode zum Zurückgeben der Felder als String
            public string getFieldasString()
            {
                return Firstname + "," + Lastname + "," + Age;
            }
        }
        private void Cmd_Aufgabe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;// Sicherheitsabfrage

            //Buttons einen Tag zuweisen
            Cmd_Aufgabe_A.Tag = 1;
            Cmd_Aufgabe_B.Tag = 2;
            Cmd_Aufgabe_C.Tag = 3;
            Cmd_Aufgabe_D.Tag = 4;

            int tag = (int)btn.Tag;

            if (tag == 1)

            {
                //Aufgabe A
                Person p1 = new Person("Max", "Muster", 22); // Person Max Muster, 22 Jahre alt wir erstellt
                Lbl1.Text = p1.getFieldasString(); // Ausgabe : Max,Muster,22
            }

            else if (tag == 2)
            {
            //Aufgabe B
            Person p1 = new Person("Max", "Muster", 22); // Person Max Muster, 22 Jahre alt wir erstellt
            Person p2 = p1;// p2 wird auf Max Muster 22 gesetzt
            Person p3 = p2;// p3 wird auf Max Muster 22 gesetzt
            p3.Firstname = "Hans";// Vorname von p3 wird auf Hans geändert also neu Hans Muster 22
            Lbl1.Text = p1.getFieldasString();// Ausgabe : Hans,Muster,22
            Lbl1.Text += "\r\n";// Zeilenumbruch
            Lbl1.Text += p2.getFieldasString();// Ausgabe : Hans,Muster,22
            Lbl1.Text += "\r\n";// Zeilenumbruch
            Lbl1.Text += p3.getFieldasString();// Ausgabe : Hans,Muster,22
            }

            else if (tag == 3)
            {
                //Aufgabe C
                Person p1 = new Person("Max", "Muster", 22); // Person Max Muster, 22 Jahre alt wir erstellt
                Person p2 = new Person("Anna", "Bolika", 33); // Person Anna Bolika, 33 Jahre alt wir erstellt
                Person p3; // Deklaration der Person p3
                p3 = p1; // p3 wird  jetzt auf Max Muster 22 gesetzt
                p1 = p2; // p1 wird jetzt auf Anna Bolika 33 gesetzt
                p2 = p3; // p2 wird jetzt auf Max Muster 22 gesetzt
                Lbl1.Text = p1.getFieldasString(); // Ausgabe : Anna,Bolika,33
                Lbl1.Text += "\r\n"; // Zeilenumbruch
                Lbl1.Text += p2.getFieldasString();// Ausgabe : Max,Muster,22
            }

            else if (tag == 4)
            {
                //Aufgabe D
                Person p1 = new Person("Max", "Muster", 22);// Person Max Muster, 22 Jahre alt wir erstellt
                Person p2 = p1;// p2 wird auf Max Muster 22 gesetzt
                Person p3 = p2;// p3 wird auf Max Muster 22 gesetzt
                p1 = p3;// p1 wird auf Max Muster 22 gesetzt
                p2.Lastname = "Keller";// Nachname von p2 wird auf Keller geändert also neu Max Keller 22
                p3.Firstname = "Hans";// Vorname von p3 wird auf Hans geändert also neu Hans Keller 22
                p1 = null;// p1 wird auf null gesetzt also p1 existiert nicht mehr
                p2 = null;// p2 wird auf null gesetzt also p2 existiert nicht mehr
                Lbl1.Text = p3.getFieldasString(); // Ausgabe : Hans,Keller,22
            }
        }
    }
}
