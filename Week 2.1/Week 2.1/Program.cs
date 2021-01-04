using System;

namespace Week_2._1
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 2; i < 1025; i = i * 2)
            {
                Console.WriteLine(i);
            }
            int j = 1;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            int k = 2;
            do
            {
                Console.WriteLine(k);
                k = k * 2;
            } while (k < 1025);

            //opdracht 2
            int Dice1 = 0;
            int Dice2 = 0;
            Random NumberGen = new Random();

            Console.WriteLine("Voer een inzet in:");
            int inzet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("wat is de naam van player1");
            string Player1 = Console.ReadLine();

            Console.WriteLine("wat is de naam van player2");
            string Player2 = Console.ReadLine();

            Console.WriteLine("de spelers " + Player1 + " en " + Player2 + " beginnen met een inzet van {0} euro", inzet);
            Console.ReadLine();


            for (int counter = 0; counter < 3; counter++)
            {
                if (counter == 0)
                {
                    Console.WriteLine(Player1 + " gooit de dobbelsteen!");
                    Dice1 = NumberGen.Next(1, 7);
                    Dice2 = NumberGen.Next(1, 7);
                    Console.WriteLine(Player1 + " gooide " + Dice1 + " en " + Dice2);

                    if (Dice1 == Dice2)
                    {
                        inzet = (inzet * 2) + 10;
                    }
                    else if (Dice1 + Dice2 == 12)
                    {
                        inzet = (inzet * 2) + 50;
                    }
                    else if (Dice1 + Dice2 == 2)
                    {
                        inzet = 0;
                    }
                }
                if (counter == 1)
                {
                    Console.WriteLine(Player2 + " gooit de dobbelsteen!");
                    Dice1 = NumberGen.Next(1, 7);
                    Dice2 = NumberGen.Next(1, 7);
                    Console.WriteLine(Player1 + " gooide " + Dice1 + " en " + Dice2);

                    if (Dice1 == Dice2)
                    {
                        inzet = (inzet * 2) + 10;
                    }
                    else if (Dice1 + Dice2 == 12)
                    {
                        inzet = (inzet * 2) + 50;
                    }
                    else if (Dice1 + Dice2 == 2)
                    {
                        inzet = 0;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine("De winnaar met een prijs van {0} is :", inzet);

                }
            }

            Console.Clear();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        if ((x * y) <= 25)
                            Console.Write("-");
                        else
                            break;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
