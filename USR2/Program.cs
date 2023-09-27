using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hub();

            float GetN()
            {
                float x = Convert.ToSingle(Console.ReadLine());
                return x;
            }

            char GetCh()
            {
                char x = Convert.ToChar(Console.ReadLine());
                return x;
            }

            void Hub()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Примитивный калькулятор");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Доступные операции:");
                Console.WriteLine("+ -- Сложение");
                Console.WriteLine("- -- Вычитание");
                Console.WriteLine("* -- Умножение");
                Console.WriteLine("/ -- Деление");
                Console.WriteLine("^ -- Возведение в степень");
                Console.WriteLine("X -- Очистить панель");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите первое число");
                Console.ForegroundColor = ConsoleColor.Cyan;
                float a = GetN();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите знак операции");
                Console.ForegroundColor = ConsoleColor.Cyan;
                char op = GetCh();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите второе число");
                Console.ForegroundColor = ConsoleColor.Cyan;
                float b = GetN();
                float x = Op(op, a, b);
                Con(x);
            }

            float Op(char op, float a, float b)
            {
                Console.WriteLine("");
                switch (op)
                {
                    case '+':
                        float x1 = Add(a, b);
                        return x1;
                    case '-':
                        float x2 = Sub(a, b);
                        return x2;
                    case '*':
                        float x3 = Mul(a, b);
                        return x3;
                    case '/':
                        float x4 = Div(a, b);
                        return x4;
                    case '^':
                        float x5 = Exp(a, b);
                        return x5;
                    case 'X':
                    case 'x':
                    case 'Ч':
                    case 'ч':
                        return float.NaN;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный знак операции");
                        Del();
                        return float.NaN;
                }
            }

            void Con(float a2)
            {
                if ((a2 == 0) || (a2 > 0) || (a2 < 0))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine($"Ваше текущее число: {a2}");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите знак операции");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    char op2 = GetCh();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите второе число");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    float b2 = GetN();
                    Console.WriteLine("");
                    float z = Op(op2, a2, b2);
                    Con(z);
                }
                else
                    Del();
            }

            float Add(float i, float j)
            {
                float x = i + j;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Сумма ваших чисел равна {x}");
                return x;
            }

            float Sub(float i, float j)
            {
                float x = i - j;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Разница ваших чисел равна {x}");
                return x;
            }

            float Mul(float i, float j)
            {
                float x = i * j;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Произведение ваших чисел равно {x}");
                return x;
            }

            float Div(float i, float j)
            {
                float x;
                if ((i == 0) || (j == 0))
                {
                    x = float.NaN;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("На ноль делить нельзя!");
                }
                else
                {
                    x = i / j;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Частное деления числа a на число b равно {x}");
                }
                return x;
            }

            float Exp(float i, float j)
            {
                float x = 1;
                for (; ; j--)
                {
                    x *= i;
                    if (j == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Число a в степени b равно {x}");
                        return x;
                    }
                }
            }

            void Del()
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("");
                Console.WriteLine("Вернуться к началу? (y/n)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                char answ = GetCh();
                switch (answ)
                {
                    case 'y':
                    case 'н':
                        Console.Clear();
                        Hub();
                        break;
                    case 'n':
                    case 'т':
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ответ, попробуйте снова");
                        Console.WriteLine("");
                        Del();
                        break;
                }
            }
        }
    }
}
