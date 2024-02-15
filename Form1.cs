namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] values = listBox1.Items.Cast<double>().ToArray();

            double answer = values[0];

            int i = 1;

            while (i < values.Length)
            {
                answer += values[i];
                i++;

            }

            label2.Text = answer.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            listBox1.Items.Add(value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] values = listBox1.Items.Cast<double>().ToArray();

            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            label1.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            double[] values = listBox1.Items.Cast<double>().ToArray();
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > 0)
                {
                    listBox2.Items.Add(values[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
            }
        }


    }
}