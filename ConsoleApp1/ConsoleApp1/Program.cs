double FirstNum, SecondNum;

string action;

Console.WriteLine("Enter first number");

FirstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");

SecondNum = double.Parse(Console.ReadLine());

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