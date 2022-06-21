int num1 = 0; int num2 = 0;

Console.WriteLine("Calculadora em C#\r");
Console.WriteLine("-----------------\n");

Console.WriteLine("num1");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("num2");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escolha uma opção:");
Console.WriteLine("\ts - Soma");
Console.WriteLine("\tsub - subtração");
Console.WriteLine("\tm - multiplicação");
Console.WriteLine("\td - divisão");
Console.WriteLine("?");

switch (Console.ReadLine())
{
    case "s":
        Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
        break;
    case "sub":
        Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
        break;
}
