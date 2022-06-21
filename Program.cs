Console.WriteLine("C# loops");

Console.Write("ingresa el primer numero : ");
int firstNumber = Int32.Parse(Console.ReadLine() ?? "0");

Console.Write("ingresa el segundo numero : ");
int secondNumbber = Int32.Parse(Console.ReadLine() ?? "1000");

for (int i = firstNumber; i < 1000; i++)

{
    if ( i % 2 == 0)
    {
    Console.WriteLine(i);
    }
    
}


Console.WriteLine("Termina el programa...");