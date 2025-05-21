namespace SelfServiceKaufland
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
            int Banknotes100 = 0;
            int Banknotes50 = 0;
            int Banknotes20 = 0;
            int Banknotes10 = 0;
            int Banknotes5 = 0;
            int Coins2 = 0;
            int Coins1 = 0;
            int Coins050 = 0;
            int Coins020 = 0;
            int Coins010 = 0;
            int Coins005 = 0;
            int Coins002 = 0;
            int Coins001 = 0;

            while (sum > 0)
            {
                double banknoteOrCoin = double.Parse(Console.ReadLine());

                switch (banknoteOrCoin)
                {
                    case 100:
                        sum = sum - banknoteOrCoin;
                        Banknotes100++;
                        break;
                    case 50:
                        sum = sum - banknoteOrCoin;
                        Banknotes50++;
                        break;
                    case 20:
                        sum = sum - banknoteOrCoin;
                        Banknotes20++;
                        break;
                    case 10:
                        sum = sum - banknoteOrCoin;
                        Banknotes10++;
                        break;
                    case 5:
                        sum = sum - banknoteOrCoin;
                        Banknotes5++;
                        break;
                    case 2:
                        sum = sum - banknoteOrCoin;
                        Coins2++;
                        break;
                    case 1:
                        sum = sum - banknoteOrCoin;
                        Coins1++;
                        break;
                    case 0.50:
                        sum = sum - banknoteOrCoin;
                        Coins050++;
                        break;
                    case 0.20:
                        sum = sum - banknoteOrCoin;
                        Coins020++;
                        break;
                    case 0.10:
                        sum = sum - banknoteOrCoin;
                        Coins010++;
                        break;
                    case 0.05:
                        sum = sum - banknoteOrCoin;
                        Coins005++;
                        break;
                    case 0.02:
                        sum = sum - banknoteOrCoin;
                        Coins002++;
                        break;
                    case 0.01:
                        sum = sum - banknoteOrCoin;
                        Coins001++;
                        break;
                }
                if (sum < 0)
                {
                    double change = Math.Abs(sum);
                    Console.WriteLine($"Вашето ресто е: {change:F2}лв.");
                    c = false;
                }
                if (!c)
                { break; }
                
            }

        }
    }
}
