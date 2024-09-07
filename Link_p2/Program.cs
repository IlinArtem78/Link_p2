// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Program
{
    static void Main(string[] args)
    {
        long t = Factorial(10); 
        Console.WriteLine("Результат равен {0}", t);
    }


    static long Factorial(int number)
    {
        // Ваш код здесь
        if (number == 0)
        {
            long result = 0;
        }
        else{
            var numbers = new List<int>();

            // Добавляем все числа от 1 до n в коллекцию
            for (int i = 1; i <= number; i++)
                numbers.Add(i);


            result = numbers.Aggregate((x, y) => x * y);

        }
        return result;
    }
}






