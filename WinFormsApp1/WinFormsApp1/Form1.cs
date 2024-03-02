namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f1 = 0, f2 = 1, f3 = 0, i = 1;

            if (int.TryParse(textBox1.Text, out int num))
            {
                while (i < num)
                {
                    f1 = f2;
                    f2 = f3;
                    f3 = f1 + f2;
                    i++;
                }
                MessageBox.Show(f3.ToString());
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
