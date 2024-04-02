using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_5_1
{
    internal class Program
    {
        static void UserInData(string StrValueInfo, out double num)
        {
            Console.Write($"Введите {StrValueInfo} число (для продолжения нажмите - Enter):");
            if (!double.TryParse(Console.ReadLine(), out num))
            {
                throw new MyException("Ошибка! Вы ввели не корректные данные! Пожалуйста, повторите ввод!");
            }
        }
        static void Main(string[] args)
        {
            bool isTry = false;

            var calculator = new Calculator();
            int index = 0;

            Console.WriteLine("Здравствуйте, вас приветствует программа калькулятор!");
            Console.WriteLine("Давайте попробуем сложить пару чисел!");
            double number1 = 0;
            double number2 = 0;
            do
            {
                try
                {
                    switch (index)
                    {
                        case 0:
                            UserInData("первое", out number1);
                            index++;
                            break;
                        case 1:
                            UserInData("второе", out number2);
                            index++;
                            break;
                        case 2:
                            Console.WriteLine($"Результат сложения чисел {number1} + {number2} = {calculator.Sum(number1, number2)}");
                            isTry = true;
                            break;
                    }
                }
                catch (Exception ex) when (ex is MyException)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (isTry) Console.WriteLine("Вычисление выполнено!");
                }
            } while (!isTry);
            Console.ReadKey();

        }
    }
}
