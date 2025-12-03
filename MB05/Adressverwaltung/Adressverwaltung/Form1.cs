namespace Adressverwaltung
{
    /// <summary>
    ///   Repräsentiert eine Person in der Adressverwaltung.
    ///   Diese Klasse dient als Datenmodell für die Speicherung von Personendaten.
    /// </summary>
    /// <remarks>
    ///   Diese Klasse ist noch nicht vollständig implementiert und dient als Grundlage
    ///   für Übungen in der objektorientierten Programmierung.
    /// </remarks>
    /// 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Person person1 = new Person();
            person1.Name = "";
        }

        public class Person
        {

            public string Name { get; set; }

            public string Vorname { get; set; }

            public int Alter { get; set; }
       
        }
    } 
}
