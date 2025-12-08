namespace A11_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        enum hairColor
        {
            blond = 1,
            brown,
            red,
            black
        }

        public void Cmd_erzeugePerson1_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();

            person1.Firstname = "Max";
            person1.Lastname = "Mustermann";
            person1.Age = 29;
            person1.Height = 1.75;
            person1.hairColor = hairColor.blond;

            Txt_Ausgabe.AppendText(person1.ShowValues() + Environment.NewLine);

            // Button deaktivieren, damit nicht mehrere Personen erzeugt werden können
            Cmd_erzeugePerson1.Enabled = false;

        }


        public void Cmd_erzeugePerson2_Click(object sender, EventArgs e)
        {
            Person person2 = new Person();

            person2.Firstname = "Anna";
            person2.Lastname = "Muser";
            person2.Age = 40;
            person2.Height = 1.62;
            person2.hairColor = hairColor.red;

            Txt_Ausgabe.AppendText(person2.ShowValues() + Environment.NewLine);


            // Button deaktivieren, damit nicht mehrere Personen erzeugt werden können
            Cmd_erzeugePerson2.Enabled = false;
        }

        public void Cmd_erzeugePerson3_Click(object sender, EventArgs e)
        {
            Person person3 = new Person();

            person3.Firstname = "Peter";
            person3.Lastname = "Hampel";
            person3.Age = 60;
            person3.Height = 1.90;
            person3.hairColor = hairColor.brown;

            Txt_Ausgabe.AppendText(person3.ShowValues() + Environment.NewLine);

            // Button deaktivieren, damit nicht mehrere Personen erzeugt werden können
            Cmd_erzeugePerson3.Enabled = false;
        }

        class Person
        {
            //Eigenschaften der Klasse Person
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public double Height { get; set; }
            public hairColor hairColor { get; internal set; }

            public string ShowValues()
            {
                return $"Vorname: {Firstname}\n  Nachname: {Lastname}\n  Alter: {Age}\n  Größe: {Height}\n  Haarfarbe: {hairColor}";
                
            }
             
        }

    }
        
}
