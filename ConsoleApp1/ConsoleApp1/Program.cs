while (true)
{
    Console.Clear();

    double FirstNum, SecondNum;
    string action;

    try
    {
        Console.WriteLine("Enter first number");
        FirstNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        SecondNum = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Error.");
        Console.WriteLine("Press Enter to Restart Calculator");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("select operation: '+' '-' '/' '*' ");
    action = Console.ReadLine();

    switch (action)
    {
        case "+":
            Console.WriteLine(FirstNum + SecondNum);
            break;
        case "-":
            Console.WriteLine(FirstNum - SecondNum);
            break;
        case "*":
            Console.WriteLine(FirstNum * SecondNum);
            break;
        case "/":
            if (SecondNum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(FirstNum / SecondNum);
            }
            break;
        default:
            Console.WriteLine("Error! unknown action!");
            break;
    }
    Console.WriteLine("Press Enter to Restart Calculator");
    Console.ReadLine();
}