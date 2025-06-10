namespace FianlProjectNonOfficial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int currentDay = now.Day;
            int currentMonth = now.Month;

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
                    Console.WriteLine($"Първо искаме да разберем малко повече за Вас!");
                    Console.Write($"Въведете Вашата реална възраст: ");
                    byte age = byte.Parse(Console.ReadLine());

                    Console.Write($"Въведете пола си (male/female): ");
                    string gender = Console.ReadLine().ToLower();

                    Console.WriteLine($"Въведете вашата реална дата на раждане: ");
                    Console.Write($"Ден: ");
                    byte day = byte.Parse(Console.ReadLine());

                    Console.Write($"Месец: ");
                    byte month = byte.Parse(Console.ReadLine());

                    Console.Write($"Година: ");
                    ushort year = ushort.Parse(Console.ReadLine());

                    Console.Write("Въведете брой артикули, които ще закупите: ");
                    int itemCount = int.Parse(Console.ReadLine());

                    double[] array = new double[itemCount];
                    Console.WriteLine("Въведете цената на всеки артикул по отделно: ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = double.Parse(Console.ReadLine());
                        sum += array[i];
                    }
                    if (day == currentDay && month == currentMonth)
                    {
                        if (gender == "male")
                        {
                            Console.WriteLine($"Понеже днес е Вашият рожден ден, днес ползвате еднократа отстъпка, която е -90% от общата сметка, която е {sum} лв!");
                            sum = sum * 0.10;
                        }
                        else if (gender == "female")
                        {
                            Console.WriteLine($"Понеже днес е Вашият рожден ден, днес ползвате еднократа отстъпка, която е -50% от общата сметка, която е {sum} лв!");
                            sum = sum * 0.50;
                        }
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
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 50:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 20:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 10:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 5:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 2:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 1:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 0.50:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 0.20:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 0.10:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 0.05:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 0.02:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    case 0.01:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum}");
                        }
                        break;
                    default:
                        Console.WriteLine("Това не е реална банкнота/монета и няма да бъде зачетена!");
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
