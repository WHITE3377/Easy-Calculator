double FirstNum, SecondNum;

string action;

Console.WriteLine("Введiть перше число");

FirstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Введiть друге число");

SecondNum = double.Parse(Console.ReadLine());

Console.WriteLine("Виберiть операцію: '+' '-' '/' '*' ");
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
        Console.WriteLine("Ви написали не той знак");
        break;

}