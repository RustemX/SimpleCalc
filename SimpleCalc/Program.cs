while(true){
Console.Write("Введите первое число:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число:");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Выберите операцию (+ - * /):");
string mathOperator = Console.ReadLine()!;
if (mathOperator.Equals("+"))
{
    Console.WriteLine(a + b);
}
if (mathOperator.Equals("-"))
{
    Console.WriteLine(a - b);
}
if(mathOperator.Equals("*"))
{
    Console.WriteLine(a * b);
}
if(mathOperator.Equals("/"))
{
    if(b == 0)
    {
        Console.WriteLine("На ноль делить нельзя!");
    }
    else{Console.WriteLine(a / b);}
    
}
}