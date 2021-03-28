using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using Vyp;

namespace pract4
{
    class Program
    {
        static void Main()
        {
            try
            {
                Write("Введите название фигуры(1 - параллелограмм, 2 - ромб, 3 - квадрат): ");
                int x = int.Parse(ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            var paral = new paral();
                            paral.name = "Параллелограмм";
                            Write("Введите x1: ");
                            paral.t1[0] = int.Parse(ReadLine());
                            Write("Введите y1: ");
                            paral.t1[1] = int.Parse(ReadLine());
                            Write("Введите x2: ");
                            paral.t2[0] = int.Parse(ReadLine());
                            Write("Введите y2: ");
                            paral.t2[1] = int.Parse(ReadLine());
                            Write("Введите x3: ");
                            paral.t3[0] = int.Parse(ReadLine());
                            Write("Введите y3: ");
                            paral.t3[1] = int.Parse(ReadLine());
                            Write("Введите x4: ");
                            paral.t4[0] = int.Parse(ReadLine());
                            Write("Введите y4: ");
                            paral.t4[1] = int.Parse(ReadLine());
                            paral.get();
                        }
                        break;
                    case 2:
                        {
                            var romb = new romb();
                            romb.name = "Ромб";
                            Write("Введите x1: ");
                            romb.t1[0] = int.Parse(ReadLine());
                            Write("Введите y1: ");
                            romb.t1[1] = int.Parse(ReadLine());
                            Write("Введите x2: ");
                            romb.t2[0] = int.Parse(ReadLine());
                            Write("Введите y2: ");
                            romb.t2[1] = int.Parse(ReadLine());
                            Write("Введите x3: ");
                            romb.t3[0] = int.Parse(ReadLine());
                            Write("Введите y3: ");
                            romb.t3[1] = int.Parse(ReadLine());
                            Write("Введите x4: ");
                            romb.t4[0] = int.Parse(ReadLine());
                            Write("Введите y4: ");
                            romb.t4[1] = int.Parse(ReadLine());
                            romb.get();
                        }
                        break;
                    case 3:
                        {
                            var kvadrat = new kvadrat();
                            kvadrat.name = "Квадрат";
                            Write("Введите x1: ");
                            kvadrat.t1[0] = int.Parse(ReadLine());
                            Write("Введите y1: ");
                            kvadrat.t1[1] = int.Parse(ReadLine());
                            Write("Введите x2: ");
                            kvadrat.t2[0] = int.Parse(ReadLine());
                            Write("Введите y2: ");
                            kvadrat.t2[1] = int.Parse(ReadLine());
                            Write("Введите x3: ");
                            kvadrat.t3[0] = int.Parse(ReadLine());
                            Write("Введите y3: ");
                            kvadrat.t3[1] = int.Parse(ReadLine());
                            Write("Введите x4: ");
                            kvadrat.t4[0] = int.Parse(ReadLine());
                            Write("Введите y4: ");
                            kvadrat.t4[1] = int.Parse(ReadLine());
                            kvadrat.get();
                        }
                        break;
                    default: WriteLine("Такого четырёхугольника нет"); break;
                }
            }
            catch
            {
                WriteLine("Произошла ошибочка");
            }
            ReadKey();
        }
    }
}
