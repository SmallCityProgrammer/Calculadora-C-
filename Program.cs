using System;



namespace MyFirstProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      do 
      {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.WriteLine("------------------");
        Console.WriteLine("Escolha um numero");
        Console.WriteLine("------------------");

        Console.Write("Escolha o primeiro numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escolha o segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma operação: ");
        Console.WriteLine("\t+ : Adição");
        Console.WriteLine("\t- : Subtração");
        Console.WriteLine("\t* : Multiplicação");
        Console.WriteLine("\t/ : Divisão");
        Console.Write("Escolha a operação: ");

        switch (Console.ReadLine()) 
        {
          case "+":
            result = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = " + result);
            break;
          case "-":
            result = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = " + result);
            break;
          case "*":
            result = num1 * num2;
            Console.WriteLine($"Resultado: {num1} * {num2} = " + result);
            break;
          case "/":
            result = num1 / num2;
            Console.WriteLine($"Resultado: {num1} / {num2} = " + result);
            break;
        }
        Console.WriteLine("Continuar (S/N)?: ");
      } while (Console.ReadLine().ToUpper() == "S");

      Console.WriteLine("Operação Finalizada!");
      Console.ReadKey();
    }
  }
}