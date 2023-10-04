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
                case 6:
                    zadanie6();
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
                int zad2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < zad2; i++) 
                {
                    if (zadanie1(i))
                    {
                        Console.WriteLine(i);
                    }

                }   
            }
            static void zadanie4()
            {
                //zadanie 4
                Console.WriteLine("Napisz program, który obliczy silnie ze wskazanej przez użytkownika liczby.");
                Console.WriteLine("Podaj liczbe");
                int silnia;
                
            }
            static void zadanie5()
            {
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
            
        }
    }
}
