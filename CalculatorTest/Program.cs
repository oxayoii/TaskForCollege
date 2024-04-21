namespace CalculatorTest
{
    public abstract class Calculator
    {
        public abstract double Action();

    }
    public class Addition(double a, double b) : Calculator
    {
        public override double Action()
        {
            return a + b;
        }
    }
    public class Subtract(double a, double b) : Calculator
    {
        public override double Action()
        {
            return a - b;
        }
    }
    public class Multply(double a, double b) : Calculator
    {
        public override double Action()
        {
            return a * b;
        }
    }
    public class Divide(double a, double b) : Calculator
    {
        public override double Action()
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на 0 запрещено");
            }
            else return a / b;
        }
    }
    public class Square(double a) : Calculator
    {
        public override double Action()
        {
            return Math.Pow(a, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. квадрат");
            int choice = int.Parse(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case 1:
                    Calculator calculator = new Addition(a, b);
                    result = calculator.Action();
                    break;
                case 2:
                    calculator = new Subtract(a, b);
                    result = calculator.Action();
                    break;
                case 3:
                    calculator = new Multply(a, b);
                    result = calculator.Action();
                    break;
                case 4:
                    try
                    {
                        calculator = new Divide(a, b);
                        result = calculator.Action();
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        return;
                    }
                    break;
                case 5:
                    calculator = new Square(a);
                    result = calculator.Action();
                    break;
                default:
                    Console.WriteLine("Неправильно выбран знак");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
