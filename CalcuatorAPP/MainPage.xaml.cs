
namespace CalcuatorAPP
{
    public partial class MainPage : ContentPage
    {
        public string number1;
        public string number2;
        public string operator1;
        public bool clear = false;

        public MainPage()
        {
            InitializeComponent();
        }


        private void NumClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (clear)
            {
                textBox1.Text = "";
                //CalInfo.Text = "";
                clear = false;
            }

            textBox1.Text += btn.Text;
            //CalInfo.Text += btn.Text;
        }
        private void OperatorBtnClick(object sender, EventArgs e)
        {
            operator1 = (string)((Button)sender).BindingContext;
            number1 = textBox1.Text;
            //CalInfo.Text += ((Button)sender).Text;
            textBox1.Text = "";
        }
        private void AC_BtnClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = "";
            number2 = "";
            //CalInfo.Text = "";
        }
        private void equal(object sender, EventArgs e)
        {
            // 物件導向封裝: 使用者不應該也不需要知道該類別是如何實作的，只要會用即可
            number2 = textBox1.Text;
            string calcresult = CalcResult(number1, number2, operator1);
            textBox1.Text = calcresult;
            clear = true;
            //CalInfo.Text += "=";
            //textBox2.Text = CalInfo.Text + calcresult + Environment.NewLine + textBox2.Text;

        }
        private void DirectlyEqual(object sender, EventArgs e)
        {

            number2 = textBox1.Text;
            string calcresult = CalcResult(number1, number2, (string)((Button)sender).BindingContext);
            textBox1.Text = calcresult;
            clear = true;
            //CalInfo.Text += ((Button)sender).Text;
            //CalInfo.Text += "=";
            //textBox2.Text = CalInfo.Text + calcresult + Environment.NewLine + textBox2.Text;
        }
        private string CalcResult(string number1, string number2, string oper)
        {
            Calc calc = new Calc();
            calc.Number1 = number1;
            calc.Number2 = number2;
            calc.Operators = oper;
            return calc.Result();
        }

    }

}
