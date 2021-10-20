using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MathActions
    {
        private double double_result;
        private string string_result;



        public void Work(string choose_function)
        {
            if (choose_function == "(1)" || choose_function == "1")
            {
                Console.WriteLine("Введите число которое будете делить");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите число на которое будете делить");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Divide(number_1, number_2);
            }

            if (choose_function == "(2)" || choose_function == "2")
            {
                Console.WriteLine("Введите первое число");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите второе число");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Multiply(number_1, number_2);
            }

            if (choose_function == "(3)" || choose_function == "3")
            {
                Console.WriteLine("Введите число,которе хотие возвести в степень");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите степень");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Involute(number_1, number_2);
            }

            if (choose_function == "(4)" || choose_function == "4")
            {
                Console.WriteLine("Введите первое число");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите второе число");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Add_up(number_1, number_2);
            }

            if (choose_function == "(5)" || choose_function == "5")
            {
                Console.WriteLine("Введите первое число");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите второе число");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Subtract(number_1, number_2);

            }
            if (choose_function == "(6)" || choose_function == "6")
            {
                Console.WriteLine("Введите число,из которого хотите взять корень");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите степень");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Number_root(number_1, number_2);
            }
            if (choose_function == "(7)" || choose_function == "7")
            {
                Console.WriteLine("Введите число");
                int number_1 = Convert.ToInt32((Console.ReadLine()));
                Factorial(number_1);
            }
            if (choose_function == "(8)" || choose_function == "8")
            {
                Console.WriteLine("Введите число которое будете делить");
                double number_1 = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Введите число на которое будете делить");
                double number_2 = Convert.ToDouble((Console.ReadLine()));
                Remainder_of_the_division(number_1, number_2);
            }
        }


        private void Show(int choose_function, double number_1, double number_2, string string_result, double result)
        {
            if (choose_function == 1)
            {
                if (number_2 == 0)
                {
                    Console.WriteLine(string_result);
                }
                else
                {
                    Console.WriteLine(number_1 + "/" + number_2 + "=" + result);
                }
            }

            if (choose_function == 2)
            {
                Console.WriteLine(number_1 + "*" + number_2 + "=" + result);
            }

            if (choose_function == 3)
            {
                Console.WriteLine(number_1 + "^" + number_2 + "=" + result);
            }

            if (choose_function == 4)
            {
                Console.WriteLine(number_1 + "+" + number_2 + "=" + result);
            }

            if (choose_function == 5)
            {
                Console.WriteLine(number_1 + "-" + number_2 + "=" + result);
            }

            if (choose_function == 6)
            {
                if (number_2 == 0)
                {
                    Console.WriteLine(string_result);
                }
                else
                {
                    Console.WriteLine(number_1 + "1/" + number_2 + "=" + result);
                }
            }

            if (choose_function == 7)
            {
                if (number_1 > 0)
                {
                    Console.WriteLine(number_1 + "!" + result);
                }
                else
                {
                    Console.WriteLine(string_result);
                }
            }

            if (choose_function == 8)
            {
                if (number_1 > number_2)
                {
                    Console.WriteLine(number_1 + "%" + number_2 + "=" + result);

                }
                else if (number_2 == 0)
                {
                    Console.WriteLine(string_result);
                }
                else
                {
                    Console.WriteLine(number_1 + "%" + number_2 + "=" + result);

                }
            }
        }

        private void Divide(double number_1, double number_2)
        {
            int choose_function = 1;
            if (number_2 == 0)
            {
                string string_result = "Я сломался,пока";
                double result = 0;
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);

            }
            else
            {
                double result = number_1 / number_2;
                string string_result = "";
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }
        }

        private void Multiply(double number_1, double number_2)
        {
            int choose_function = 2;
            double result = number_1 * number_2;
            string string_result = "";
            this.double_result = result;
            this.string_result = string_result;
            Show(choose_function, number_1, number_2, string_result, result);
        }

        private void Involute(double number_1, double number_2)
        {
            int choose_function = 3;
            double result = Math.Pow(number_1, number_2);
            string string_result = "";
            this.double_result = result;
            this.string_result = string_result;
            Show(choose_function, number_1, number_2, string_result, result);
        }

        private void Add_up(double number_1, double number_2)
        {
            int choose_function = 4;
            double result = number_1 + number_2;
            string string_result = "";
            this.double_result = result;
            this.string_result = string_result;
            Show(choose_function, number_1, number_2, string_result, result);
        }

        private void Subtract(double number_1, double number_2)
        {
            int choose_function = 5;
            double result = number_1 - number_2;
            string string_result = "";
            this.double_result = result;
            this.string_result = string_result;
            Show(choose_function, number_1, number_2, string_result, result);
        }

        private void Number_root(double number_1, double number_2)
        {
            int choose_function = 6;
            if (number_2 == 0)
            {
                double result = 0;
                string string_result = "Я сломался пока)";
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }
            else
            {
                double result = Math.Pow(number_1, 1 / number_2);
                string string_result = "";
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }
        }

        private void Factorial(int number_1)
        {
            int choose_function = 7;
            int number_2 = 0;
            string string_result;
            double result = 1;
            if (number_1 > 0)
            {
                for (int i = 1; i <= number_1; i++)
                {

                    result *= i;
                }
                string_result = "";
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }
            else
            {
                string_result = "Я сломался пока)";
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }
        }

        private void Remainder_of_the_division(double number_1, double number_2)
        {
            int choose_function = 8;
            string string_result = "";
            if (number_1 > number_2)
            {
                int int_number_1 = Convert.ToInt32(number_1);
                int int_number_2 = Convert.ToInt32(number_2);
                int integer = int_number_1 / int_number_2;
                int result = Convert.ToInt32(number_1 - (number_2 * integer));
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }

            else if (number_2 == 0)
            {
                string_result = "Я сломался пока)";
                int result = 0;
                this.double_result = result;
                this.string_result = string_result;
                Show(choose_function, number_1, number_2, string_result, result);
            }

            else
            {
                int result = 0;
                if (number_1 == 0)
                {
                    this.double_result = result;
                    this.string_result = string_result;
                    Show(choose_function, number_1, number_2, string_result, result);
                }
                else
                {
                    int count_2 = 0;
                    string str_result = Convert.ToString(number_1 / number_2);
                    int Length_result = str_result.Length;
                    int count = 0;
                    string short_result = "";
                    while (str_result[count] != ',' && Length_result != 1)
                    {
                        short_result = short_result + str_result[count];
                        count++;
                    }
                    while (count_2 != 3)
                    {
                        short_result = short_result + str_result[count];
                        count++;
                        count_2++;
                    }
                    double double_short_result = Convert.ToDouble(short_result);
                    result = Convert.ToInt32(100 * (number_1 - (double_short_result * number_2)));
                    this.double_result = result;
                    this.string_result = string_result;
                    Show(choose_function, number_1, number_2, string_result, result);
                }

            }


        }
    }
}