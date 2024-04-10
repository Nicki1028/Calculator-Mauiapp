using Calculator.Backend;

namespace Calculator;

public partial class MainPage : ContentPage
{
    private string calculate;
    private string beforevalue;
    private bool clear = false;
    public MainPage()
	{
		InitializeComponent();
	}

    private void NumberClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Console.WriteLine(button.Text);

        if (textBox.Text == "0")
        {
            textBox.Text = button.Text;
        }
        else
        {
            textBox.Text += button.Text;
        }

        if (clear)
        {
            textBox.Text = button.Text;
            clear = false;
        }

    }
    private void CalcutorClick(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Console.WriteLine(button.Text);

        calculate = button.Text;
        beforevalue = textBox.Text;
        textBox.Text += button.Text;
        clear = true;

    }
    private void button15_Click(object sender, EventArgs e)
    {
        // 封裝: 使用者不應該也不需要知道該類別是如何運作的，只要學會如何使用即可。
        Calculate calc = new Calculate();
        calc.Num1 = beforevalue;
        calc.Num2 = textBox.Text;
        calc.Oper = calculate;
        textBox.Text = calc.Cal();
        // calc.Number2 = yyy
        // calc.Oper = zzz
        // textBox1.text = calc.Result()
        //Double getbeforevalue = Double.Parse(beforevalue);
        //Double getlastvalue = Double.Parse(textBox.Text);
        //Double final = 0;

        //switch (calculate)
        //{
        //    case "+":
        //        final = getbeforevalue + getlastvalue;
        //        break;
        //    case "-":
        //        final = getbeforevalue - getlastvalue; 
        //        break;
        //    case "*":
        //        final = getbeforevalue * getlastvalue;
        //        break;
        //    case "/":
        //        final = getbeforevalue / getlastvalue;
        //        break;

        //}

    }
    private void button16_Click(object sender, EventArgs e)
    {
        textBox.Text = "0";
    }
}

