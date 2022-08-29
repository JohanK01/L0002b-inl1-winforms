namespace WinFormsCheckout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clears listbox from previous answers 
            listBox1.Items.Clear();
            int[] money = { 500, 200, 100, 50, 20, 10, 5, 1 };

            int owe = Int32.Parse(textBox1.Text);
            int payed = Int32.Parse(textBox2.Text);
            int afterTrans = payed - owe;

            //checks if you have enought money
            if (afterTrans < 0)
            {
                listBox1.Items.Add($"Det saknas: {-afterTrans} kr");
            }
            else
            {
                foreach (int i in money)
                {
                    if (afterTrans >= i)
                    {
                        listBox1.Items.Add($"Antal {i} kr: {(afterTrans - afterTrans % i) / i}");
                        afterTrans = afterTrans % i;
                    }
                }
            }

        }

        //ends application 
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}