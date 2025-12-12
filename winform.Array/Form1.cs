namespace winform.Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] date = textBox1.Lines;
            int[] numbers = new int[date.Length];


            for (int i = 0; i < date.Length; i++)
            {
                if (int.TryParse(date[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    numbers[i] = 0;
                }
            }


            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }


            double average = Convert.ToDouble(sum) / numbers.Length;



			int min = numbers[0];
			int max = numbers[0];

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] < min) min = numbers[i];
				if (numbers[i] > max) max = numbers[i];
			}


			label3.Text = "จำนวนสมาชิก : " + numbers.Length;
            label4.Text = "ผลรวม : " + sum;
            label5.Text = "ค่าเฉลี่ย : " + average;
			label6.Text = "ค่าต่ำสุด : " + min;
			label7.Text = "ค่าสูงสุด : " + max;
		}

        
    }
}
