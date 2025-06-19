namespace FianlProjectNonOfficial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int currentDay = now.Day;
            int currentMonth = now.Month;
            int currentYear = now.Year;

            Random random = new Random();
            int randomNum = random.Next(200, 300);
            int randomDiscount = random.Next(1, 15);

            char a = '"';
            Console.WriteLine($"Добре дошли в Kaufland! Въведете {a}Старт{a}.");
            string pass = Console.ReadLine();

            bool breakpoint = true;
            bool colision = true;
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
                    while (age > 134)
                    {
                        Console.WriteLine("Вие не съществувате! Въведете по - малка възраст:");
                        age = byte.Parse(Console.ReadLine());
                    }

                    Console.Write($"Въведете пола си (male/female): ");
                    string gender = Console.ReadLine().ToLower();


                    Console.WriteLine($"Въведете вашата реална дата на раждане (пример - 15): ");
                    Console.Write($"Ден(пример - 07): ");
                    byte day = byte.Parse(Console.ReadLine());
                    while (day > 31)
                    {
                        Console.WriteLine($"Въведете валиден ден:");
                        day = byte.Parse(Console.ReadLine());
                        if (day <= 31)
                        {
                            break;
                        }
                    }

                    Console.Write($"Месец (пример - 08): ");
                    byte month = byte.Parse(Console.ReadLine());
                    while (month > 12)
                    {
                        Console.WriteLine($"Въведете валиден месец:");
                        month = byte.Parse(Console.ReadLine());
                        if (month <= 12)
                        {
                            break;
                        }
                    }

                    Console.Write($"Година: ");
                    int Birthyear = 0;
                    if (month > currentMonth)
                    {
                        Birthyear = currentYear - age - 1;
                    }
                    else if (month < currentMonth)
                    {
                        Birthyear = currentYear - age;
                    }
                    else
                    {
                        Birthyear = currentYear - age;
                    }
                    Console.WriteLine(Birthyear);
                    Console.Write("Въведете брой артикули, които ще закупите (пример - 13): ");
                    int itemCount = int.Parse(Console.ReadLine());
                    while (itemCount > 50)
                    {
                        Console.WriteLine("Въведете по - малка стойност:");
                        itemCount = int.Parse(Console.ReadLine());
                        if (itemCount <= 50)
                        {
                            break;
                        }
                    }

                    double[] array = new double[itemCount];
                    Console.WriteLine("Въведете цената на всеки артикул по отделно (пример - 4.81 и натискате Enter): ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = double.Parse(Console.ReadLine());
                        sum += array[i];
                    }
                    if (day == currentDay && month == currentMonth)
                    {
                        if (gender == "male")
                        {
                            Console.WriteLine($"Понеже днес е Вашият рожден ден, днес ползвате еднократа отстъпка,");
                            Console.WriteLine($"която е -45% от общата сметка, която е {sum} лв!");
                            sum = sum * 0.55;
                        }
                        else if (gender == "female")
                        {
                            Console.WriteLine($"Понеже днес е Вашият рожден ден, днес ползвате еднократа отстъпка,");
                            Console.WriteLine($"която е -25% от общата сметка, която е {sum} лв!");
                            sum = sum * 0.75;
                        }
                    }
                    breakpoint = false;
                }
                if (!breakpoint)
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
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 50:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 20:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 10:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 5:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 2:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 1:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 0.50:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 0.20:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 0.10:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 0.05:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 0.02:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
                        }
                        break;
                    case 0.01:
                        sum = sum - banknoteOrCoin;
                        if (sum > 0)
                        {
                            Console.WriteLine($"Оставаща сума за доплащане: {sum:F2}лв.");
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
                    Console.WriteLine($"Понеже Вие сте наш лоялен клиент,");
                    Console.WriteLine($"ние Ви предоставяме безплатен промокод с номер {randomNum},");
                    Console.WriteLine($"който Ви дава -{randomDiscount}% отстъпка при следващо пазаруване!");
                    Console.WriteLine($"Пожелаваме Ви хубав ден!");
                    colision = false;
                }
                if (!colision)
                { break; }

            }
        }
    }
}