namespace A9_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmd_Start_Click(object sender, EventArgs e)
        {
            int[] data = new int[20];
            Random r = new Random();

            for (int c = 0; c < data.Length; c++)
            {
                data[c] = r.Next(0, 100);
            }
            int count = 0;
            while (count < data.Length)
            {
                Txt_Ausgabe.Text += Convert.ToString(data[count] + "\r\n");
                count++;
            }

        }
    }
}
