using System;

namespace pierwsze_zajecia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybiierz zadanie:");
            Console.WriteLine("Zad 1 - Napisz program, który sprawdzi, czy podana przez użytkownika liczba jestparzysta czy nieparzysta.");
            Console.WriteLine("Zad 2 - Napisz program, który wypisze na konsoli wszystkie parzyste liczby od 1 do N,gdzie N jest liczbą wprowadzoną przez użytkownika.");
            Console.WriteLine("Zad 4 - Napisz program, który obliczy silnie ze wskazanej przez użytkownika liczby.");
            Console.WriteLine("Zad 5 - Napisz grę, w której komputer losuje liczbę, a użytkownik próbuje odgadnąć ją w jak najmniejszej liczbie prób.");
            Console.WriteLine("Zad 6 - Napisz program, które umożliwia przeliczanie jednostek miar, takich jak przeliczanie temperatury między stopniami Celsiusza a stopniami Fahrenheita lub między jednostkami długości, np. metrami i centymetrami.");


            var input = Console.ReadLine();
            switch (int.Parse(input))
            {
                case 1:
                    zadanie1();
                    break;
                case 2:
                    zadanie2();
                    break;
                case 4:
                    zadanie4();
                    break;
                case 5:
                    zadanie5();
                    break;
                case 6:
                    zadanie6();
                    break;
                case 0:
                    return;
            }


            static void zadanie1()
            {
                //ZADANIE 1
                Console.WriteLine("ZADANIE 1: Napisz program, który sprawdzi, czy podana przez użytkownika liczba jestparzysta czy nieparzysta.");
                Console.WriteLine("Podaj liczbe");
                int zad1 = int.Parse(Console.ReadLine());
                if (zad1 % 2 == 0)
                {
                    Console.WriteLine("Liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba jest nieparzysta");
                }
            }
            static void zadanie2()
            {
                //ZADANIE 2
                Console.WriteLine("Napisz program, który wypisze na konsoli wszystkie parzyste liczby od 1 do N, gdzie N jest liczbą wprowadzoną przez użytkownika.");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= 1)
                    {
                        Console.WriteLine($"Parzyste liczby od 1 do {n}:");
                        for (int i = 2; i <= n; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("N musi być liczbą większą lub równą 1.");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest poprawna liczba całkowita.");
                }
            }

            static void zadanie4()
            {
                //zadanie 4
                Console.WriteLine("Napisz program, który obliczy silnie ze wskazanej przez użytkownika liczby.");
                Console.WriteLine("Podaj liczbe");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n >= 0)
                    {
                        int silnia = liczsilnia(n);
                        Console.WriteLine($"Silnia z {n} wynosi: {silnia}");
                    }
                    else
                    {
                        Console.WriteLine("Podaj nieujemną liczbę całkowitą.");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest poprawna liczba całkowita.");
                }
                static int liczsilnia(int n)
                {
                    if (n == 0)
                        return 1;

                    int result = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }

                    return result;
                };


            }
            static void zadanie5()
            {
                //zadanie 5
                var random = new Random();
                var number = random.Next(1, 11);//od 1 do 10
                int count = 0;
                int shoot;
                do
                {
                    count++;
                    Console.WriteLine("podaj liczbe");
                    var input = Console.ReadLine();
                    shoot = int.Parse(input);

                }
                while (shoot != number);
                Console.WriteLine($"Zgadłeś! za {count}");

            }
            static void zadanie6()
            {
                //zadanie 6
                Console.WriteLine("Wybierz jednostki, które chcesz przeliczać:");
                Console.WriteLine("1. Metry na centymetry");
                Console.WriteLine("2. Centymetry na metry");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MetrNaCentymetr();
                            break;
                        case 2:
                            CentymetrNaMetr();
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Wybierz 1 lub 2.");
                }
                static void MetrNaCentymetr()
                {
                    Console.Write("Podaj długość w metrach: ");
                    if (double.TryParse(Console.ReadLine(), out double m))
                    {
                        double cm = m * 100;
                        Console.WriteLine($"Długość w centymetrach: {cm} cm");
                    }
                    else
                    {
                        Console.WriteLine("To nie jest prawidłowa długość w metrach.");
                    }
                }
                static void CentymetrNaMetr()
                {
                    Console.Write("Podaj długość w centymetrach: ");
                    if (double.TryParse(Console.ReadLine(), out double cm))
                    {
                        double m = cm / 100;
                        Console.WriteLine($"Długość w metrach: {m} m");
                    }
                    else
                    {
                        Console.WriteLine("To nie jest prawidłowa długość w centymetrach.");
                    }
                }


            }
        }
    }
}
