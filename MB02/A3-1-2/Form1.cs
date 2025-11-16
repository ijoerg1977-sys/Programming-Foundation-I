namespace A3_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum NUmberToMonth
        {
            Januar = 1,
            Februar,
            März,
            April,
            Mai,
            Juni,
            Juli,
            August,
            September,
            Oktober,
            November,
            Dezember
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LblAusgabe.Text = ((NUmberToMonth)numericUpDown1.Value).ToString();
        }
    }
}
