while (true)
{   int num1, num2;
    string op;
    double result = 0;
    Console.WriteLine("..............Simple Calculator............");
    Console.WriteLine("Please Enter Your First Number.");
    num1 =Int32.Parse(Console.ReadLine());
    Console.WriteLine("Please Enter Your Second Number,");
    num2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Please Enter the opperation.(+ , - , * , / ");
    op=Console.ReadLine();

    switch (op) {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
            {
                result = num1 / (double) num2;
                break;
            }
            else
            {
                Console.WriteLine("divid by 0!");
                continue;
            }
    }
    Console.WriteLine("The result is: " + result.ToString());
    Console.WriteLine("............Please Press Enter to continue........");
    
}
