namespace практическая_работа_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите программу, которую вы хотите запустить: \r\n1-Угадай число\r\n2-Таблица умножения\r\n3-Выйти из программы");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 3)
            {
                switch (a)
                {
                    case 1:
                        UgadaiChislo();
                        break;


                    case 2:
                        TablicaUmnogenie();
                        break;
                }

                Console.WriteLine("выберите программу, которую вы хотите запустить: \r\n1-Угадай число\r\n2-Таблица умножения\r\n3-Выйти из программы");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void UgadaiChislo()
        {
            Console.WriteLine("отгадай число от 1 до 100!");
            int b = 1;
            Random rand = new Random();
            int chislo = rand.Next(9);
            int ugadai_chislo = Convert.ToInt32(Console.ReadLine());
            while (ugadai_chislo != chislo)
            {
                if (ugadai_chislo < chislo)
                {
                    Console.WriteLine("нужно больше ваше число!");
                }
                else
                {
                    Console.WriteLine("нужно меньше ваше число!");
                }

                {
                    b++;

                    Console.WriteLine("Нет, это не число " + ugadai_chislo + "! Попытка № " + b + ":");
                    ugadai_chislo = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (ugadai_chislo == chislo)
            {
                Console.WriteLine("вы угадали число, молодец!!" + ugadai_chislo + "!");

            }
            Console.WriteLine();
        }
        static void TablicaUmnogenie()
        {
            int x = 2;
            Console.WriteLine();


            int i;
            int umnogenie;
            for (i = 1; i <= 9; i++)
            {
                Console.WriteLine("\t");
                for (umnogenie = 1; umnogenie <= 9; umnogenie++)
                {
                    Console.Write("\t" + i * umnogenie);
                }
            }
            Console.WriteLine();
        }
    }
}
