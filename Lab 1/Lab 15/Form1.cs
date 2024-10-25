namespace Lab_15
{
    public partial class Form1 : Form
    {
        double result;
        int[] nums;
        //string[] operators;
        List<string> operators = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = string.Empty;
            }
            Button buttion = (Button)sender;
            txtDisplay.Text += buttion.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (new char[] { '+', '-', '*', '/' }.Contains(txtDisplay.Text[^1]))
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                // Your code here

            }

            txtDisplay.Text += button.Text;
            operators.Add(button.Text);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string[] operatorsArray = operators.ToArray();
            string calcText = txtDisplay.Text;

            nums = calcText.Split(new char[] { '+', '-', '*', '/' }).Select(num => Convert.ToInt32(num)).ToArray();

            result = Calculate(nums, operatorsArray);

            Array.Clear(nums, 0, nums.Length);
            operators.Clear();
            txtDisplay.Text = Convert.ToString(result);
        }

        static double Calculate(int[] nums, string[] operators)
        {
            double total = nums[0];

            for (int i = 0; i < operators.Length; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        total += nums[i + 1];
                        break;
                    case "-":
                        total -= nums[i + 1];
                        break;
                    case "*":
                        total *= nums[i + 1];
                        break;
                    case "/":
                        if (nums[i + 1] != 0)
                        {
                            total /= nums[i + 1];
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero");
                            return double.NaN; // Return NaN for division by zero
                        }
                        break;
                }
            }
            return total;
        }
    }
}
