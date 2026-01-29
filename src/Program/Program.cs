public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Suma.Sumar(1, 2));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Dividir(7, 8));
    }
}

public class Substraction
{
   public static int Substract(int a, int b)
   {
       return a - b;
   }
}

public class Addition
{
   public static int Add(int a, int b)
   {
       return a + b;
   }
}