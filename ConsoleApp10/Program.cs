using System;

namespace Codick
{
    internal class Program
    {
        static DateTime vremya = DateTime.Now;
        /// <summary>
        /// Влево вправо
        /// </summary>
        static int TudaSuda = 0;
        static int Dela = 2;
        static void Main(string[] args)
        {
            Zametka z = new Zametka()
            {
                Day = 6,
                name = "Кушаать",
                description = "хочу покушать, покушал"
            };
            Zametka.zametks.Add(z);
            Zametka o = new Zametka()
            {
                Day = 6,
                name = "спать",
                description = "график"
            };
            Zametka.zametks.Add(o);
            Zametka v = new Zametka()
            {
                Day = 6,
                name = "отдых",
                description = "пойти с друщьями погулять "
            };
            Zametka.zametks.Add(v);
            Zametka x = new Zametka()
            {
                Day = 7,
                name = "Музыка",
                description = "ну музыка явно не помешает"
            };
            Zametka.zametks.Add(x);
            Zametka r = new Zametka()
            {
                Day = 8,
                name = "Неделя длинная так что снова на пары",
                description = "прийти на пары, чтобы поучиться"
            };
            Zametka.zametks.Add(r);
            Zametka s = new Zametka()
            {
                Day = 8,
                name = "сходить в магаз",
                description = "купить еду чтобы ее дома приготовить"
            };
            Zametka.zametks.Add(s);
            Zametka j = new Zametka()
            {
                Day = 9,
                name = "Пубгм",
                description = "Пубгм одна из лучших мобильных игр "
            };
            Zametka.zametks.Add(j);
            Zametka k = new Zametka()
            {
                Day = 9,
                name = "Кушать",
                description = "хочу покушать, значит буду"
            };
            Zametka.zametks.Add(k);
            Zametka d = new Zametka()
            {
                Day = 10,
                name = "прийти на пары",
                description = "Чтобы узнать что то новое"
            };
            Zametka.zametks.Add(d);

            while (true)
            {
                Alfavite();
                Clavishka();
                Strelochechka();
            }
        }


        private static void Alfavite()
        {
            int mestniiyNomerok = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Дела на:{vremya.AddDays(TudaSuda).Day}.{vremya.AddDays(TudaSuda).Month}.{vremya.AddDays(TudaSuda).Year}");
            foreach (var elementik in Zametka.zametks)
            {
                if (elementik.Day == vremya.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    Console.SetCursorPosition(4, mestniiyNomerok + 1);
                    elementik.Number = mestniiyNomerok;
                    Console.Write($"{elementik.Number}.{elementik.name}\n");
                }
            }

        }
        private static void Clavishka()
        //метод отрисовки задач
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    TudaSuda--;
                    break;
                case ConsoleKey.RightArrow:
                    TudaSuda++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Dela < 3)
                    {
                        Dela = 2;
                    }
                    else
                    {
                        Dela--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Dela > 3)
                    {
                        Dela = 4;
                    }
                    else
                    {
                        Dela++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometochkka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("Пока покаа!");
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void Pometochkka()
        {
            int mestniiyNomerok = 0;
            Console.Clear();
            foreach (var elementik in Zametka.zametks)
            {
                if (elementik.Day == vremya.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    elementik.Number = mestniiyNomerok;
                    if (mestniiyNomerok == Dela - 1)
                    {
                        Console.Write($"  {elementik.name}\n");
                        Console.Write(" " + elementik.description);
                    }
                }
            }
        }

        private static void Strelochechka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Dela);
            Console.Write("-->");
        }
    }
}