﻿namespace SelfServiceKaufland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = '"';
            Console.WriteLine($"Добре дошли в Kaufland! Въведете {a}Старт{a}.");
            string pass = Console.ReadLine();

            bool b = true;
            bool c = true;
            double sum = 0;
            while (true)
            {
                if (pass != "Старт")
                {
                    Console.WriteLine($"Не сте въвели {a}Старт{a}.Моля, опитайте отново.");
                    pass = Console.ReadLine();
                }
                else
                {

                    Console.Write("Въведете брой артикули: ");
                    int itemCount = int.Parse(Console.ReadLine());

                    double[] array = new double[itemCount];
                    Console.WriteLine("Въведете цената на всеки артикул по отделно:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = double.Parse(Console.ReadLine());
                        sum += array[i];
                    }
                        b = false;
                }
                if (!b)
                {
                    break;
                }
            }
            Console.WriteLine("Вкарайте необходимите банкноти и/или монети:");

            while (sum > 0)
            {
                double banknoteOrCoin = double.Parse(Console.ReadLine());
                switch (banknoteOrCoin)
                {
                    case 100:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 50:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 20:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 10:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 5:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 2:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 1:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 0.50:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 0.20:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 0.10:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 0.05:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 0.02:
                        sum = sum - banknoteOrCoin;
                        break;
                    case 0.01:
                        sum = sum - banknoteOrCoin;
                        break;
                    default:
                        Console.WriteLine("Това не е реална банкнота/монета и няма да бъде зачетена!");
                        break;
                }
                if (sum < 0)
                {
                    double change = Math.Abs(sum);
                    List<int> list = new List<int>();
                    while (change > 0)
                    {
                        if (change - 50 > 0)
                        {
                            list.Add(50);
                        }
                        else if (change - 20 > 0)
                        {
                            list.Add(20);
                            if (change - 20 > 0)
                            {
                                list.Add(20);
                            }
                        }
                        else if (change - 10 > 0)
                        {
                            list.Add(10);
                        }
                        else if (change - 5 > 0)
                        {
                            list.Add(5);
                        }
                        else if (change - 2 > 0)
                        {
                            list.Add(2);
                        }
                        else if (change - 1 > 0)
                        {
                            list.Add(1);
                        }
                        else if (change - 0.50 > 0)
                        {
                            list.Add(1/2);
                        }
                        else if (change - 0.20 > 0)
                        {
                            list.Add(1/5);
                        }
                        else if (change - 0.10 > 0)
                        {
                            list.Add(1/10);
                        }
                        else if (change - 0.05 > 0)
                        {
                            list.Add(1/20);
                        }
                        else if (change - 0.02 > 0)
                        {
                            list.Add(1/50);
                        }
                        else if (change - 0.01 > 0)
                        {
                            list.Add(1/100);
                        }
                    }
                    for (int i = 0; i <= list.Count; i++)
                    {
                        Console.WriteLine(list[i] + "лв");
                    }
                    Console.WriteLine($"Вашето ресто е: {change:F2}лв.");
                    c = false;
                }
                if (!c)
                { break; }
                
            }

        }
    }
}
