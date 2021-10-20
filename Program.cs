using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в консольный калькулятор");
            Console.WriteLine("Выбор функций калькулятора:\n(1) - деление\n(2) - умножение\n(3) - возведние в степень\n(4) - сложение\n(5)- вычетание\n(6)- взять корень числа" +
                 "\n(7)- факториал числа\n(8)- остаток от деления");
            string choose_function = Console.ReadLine();
            MathActions start = new MathActions();
            start.Work(choose_function);
        }
    }
}
