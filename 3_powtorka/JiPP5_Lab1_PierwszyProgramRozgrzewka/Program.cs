using System;
using System.Collections.Generic;

namespace JiPP5_Lab1_PierwszyProgramRozgrzewka
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Pierwszy program - rozgrzewka
            ///Zadanie 1
            ///Stwórz nowy projekt typu Console App(.Net Core).

            ///Zadanie 2
            ///W metodzie Main umieść następujący kod:
            ///Console.WriteLine("Podaj swoje imię:");
            ///var name = Console.ReadLine();
            ///Console.WriteLine("Hello " + name);
            ///Uruchom projekt, wyświetli się okno konsoli.

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("---------------------------------------------------");

            ///Zadanie 3
            ///W metodzie Main umieść następujący kod:
            ///int result = 5 + 9
            ///Uruchom projekt.
            ///Jeśli uruchomienie zakończy się niepowodzeniem, znajdź i napraw błąd. Błędy możesz zobaczyć w oknie Error List.
            int result = 5 + 9;
            Console.WriteLine("5 + 9 = " + result);
            Console.WriteLine("---------------------------------------------------");

            ///Operatory
            ///Zadanie 1
            ///W metodzie Main utwórz 6 zmiennych.
            ///Każda zmienna powinna przechowywać odpowiednio dobrany przez Ciebie typ danych na podstawie opisu.
            ///Wartości mogą być dowolne.
            ///Zmienna o nazwie number przechowująca liczbę całkowitą.
            ///Zmienna o nazwie money przechowująca liczbę zmiennoprzecinkową(float).
            ///Zmienna o nazwie text przechowująca tekst.
            ///Zmienna o nazwie isLogged przechowująca wartość logiczną.
            ///Zmienna o nazwie myChar przechowująca pojedynczy znak.
            ///Zmienna o nazwie price przechowująca liczbę zmiennoprzecinkową z największą precyzją(decimal).
            ///Po deklaracji wszystkich zmiennych wyświetl je w konsoli.

            int number = 1;
            float money = 1.50f;
            string text = "przykładowy tekst";
            bool isLogged = true;
            char myChar = 'S';
            decimal price = 123456782.5012998877m;
            Console.WriteLine("number: " + number);
            Console.WriteLine("money: " + money);
            Console.WriteLine("text: " + text);
            Console.WriteLine("isLogged: " + isLogged);
            Console.WriteLine("myChar: " + myChar);
            Console.WriteLine("price: " + price);
            Console.WriteLine("---------------------------------------------------");

            ///Zadanie 2
            ///Utwórz zmienną o nazwie myAge typu string z wartością Age: .
            ///Utwórz zmienną o nazwie wifeAge typu int z wartością 18.
            ///Utwórz zmienną o nazwie result i przypisz do niej rezultat dodawania zmiennych myAge i wifeAge.
            ///Wyświetl zmienną result w konsoli.
            ///Jakie wnioski?

            string myAge = "Age: ";
            int wifeAge = 18;
            var result2 = myAge + wifeAge;
            Console.WriteLine("result2: " + result2);
            /// zmienna result2 jest typu string
             Console.WriteLine("---------------------------------------------------");

            ///Zadanie 3
            ///Utwórz 3 zmienne typu bool o następujących nazwach i wartościach:
            ///    isTrue o wartości true.
            ///    isFalse o wartości false.
            ///    isReallyTrue o wartości true.
            ///Utwórz 3 kolejne zmienne o następujących nazwach i przypisz do nich wyniki działań na zmiennych logicznych:
            ///    and powinna zwierać wynik działania isTrue AND isFalse.
            ///    or powinna zwierać wynik działania isTrue OR isReallyTrue.
            ///    negative powinna zawierać wynik negacji isFalse.
            ///Wyświetl zmienne and, or i negative w konsoli.

            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            Console.WriteLine("isTrue: " + isTrue);
            Console.WriteLine("isFalse: " + isFalse);
            Console.WriteLine("isReallyFalse: " + isReallyTrue);

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("and = isTrue && isFalse: " + and);
            Console.WriteLine("or = isTrue || isReallyTrue: " + or);
            Console.WriteLine("negative = !isFalse: " + negative);
            Console.WriteLine("---------------------------------------------------");

            ///Zadanie 4
            ///Utwórz dwie zmienne o nazwach a, b i przypisz do nich wartości 5, 12.
            ///Utwórz zmienne o nazwach add, sub, div, mul, mod i przypisz do nich kolejno wynik dodawania, odejmowania, dzielenia, mnożenia i modulo zmiennych a i b.
            ///Wyświetl zmienne add, sub, div, mul, mod w konsoli.

            double a;
            double b;
            a = 5;
            b = 12;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            double add, sub, div, mul, mod;
            add = a + b;
            sub = a - b;
            div = a / b;
            mul = a * b;
            mod = a % b;

            Console.WriteLine("add = a + b: " + add);
            Console.WriteLine("sub = a - b: " + sub);
            Console.WriteLine("div = a / b: " + div);
            Console.WriteLine("mul = a * b: " + mul);
            Console.WriteLine("mod = a % b: " + mod);
            Console.WriteLine("---------------------------------------------------");

            ///Zadanie 5
            ///Utwórz trzy zmienne typu string o nazwach a, b i c.
            ///Do zmiennych przypisz kolejno tekst Ala, ma, kota..
            ///Utwórz 4 zmienną o nazwie result i przypisz do niej wynik operacji a + b + c.
            ///Wyświetl zmienną result w konsoli.
            ///Napisz w komentarzu swoje spostrzeżenia dotyczące wyniku.

            string a1, b1, c1;
            a1 = "Ala";
            b1 = "ma";
            c1 = "kota";

            string result1 = a1 + b1 + c1;
            Console.WriteLine("a1: " + a1);
            Console.WriteLine("b1: " + b1);
            Console.WriteLine("c1: " + c1);
            Console.WriteLine("result1: " + result1);
            Console.WriteLine("---------------------------------------------------");
            ///suma stringów jest stringiem sklejonym z trzech składowych stringów

            ///Instrukcje sterujące i pętle
            ///Zadanie 1
            ///Utwórz dwie zmienne typu int o nazwach n1 i n2. Przypisz do nich liczby 10 i 20.
            ///Używając instrukcji if sprawdź wartości tych zmiennych i wypisz w konsoli, która z liczb jest większa lub czy są równe.
            ///Tekst powinien się wyświetlić według wzoru n1 jest większe od n2 lub n1 jest równe n2.

            int n1, n2;
            n1 = 10;
            n2 = 20;
            if (n1>n2)
                Console.WriteLine(n1 + " jest większe od " + n2);
            else if (n1==n2)
                Console.WriteLine(n1 + " jest równe " + n2);
            else
                Console.WriteLine(n2 + " jest większe od " + n1);
            Console.WriteLine("---------------------------------------------------");


            ///Zadanie 2
            ///Stwórz pętlę, która 10 razy wypisze w konsoli C#.
            ///Zadanie rozwiąż używając pętli for oraz pętli while.
            ///W sumie w konsoli wyraz C# powinien pojawić się 20 razy.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
            int iterator = 0;
            int ilosc = 10; 
            Console.WriteLine("---------------------------------------------------");
            while (iterator<ilosc)
            {
                Console.WriteLine("C#");
                iterator++;
            }
            Console.WriteLine("---------------------------------------------------");


            ///Zadanie 3
            ///Stwórz zmienną o nazwie n, które będzie zainicjowana wartością 10.
            ///Następnie wypisz w konsoli informacje czy liczba jest parzysta, czy nie, dla liczb od 0 do n.Wzór:
            ///    0 - Parzysta
            ///    1 - Nieparzysta
            ///    2 - Parzysta
            ///    itd...
            ///Jak sprawdzić czy liczba jest parzysta? Podpowiedź: modulo.
            int n = 10;
            for (int i = 0; i < n+1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " - Nieparzysta");
                }
            }
            Console.WriteLine("---------------------------------------------------");


            /**
            Zadanie 4 * dodatkowe
            Stwórz zmienną o nazwie n, która będzie zawierała wartość 5.
            Następnie napisz skrypt, który wypisze w konsoli poniższy schemat.
            Schemat dla n = 5.

                *
                **
                ***
                ****
                *****
            Schemat dla n = 3.

                *
                **
                ***
            */
            int n3 = 5;
            Console.WriteLine("n = " + n3);
            int iterator2 = 0;
            string linia="";
            while (iterator2 < n3)
            {
                linia += "*";
                Console.WriteLine(linia);
                iterator2++;
            }

            n3 = 3;
            Console.WriteLine("n = " + n3);
            iterator2 = 0;
            linia = "";
            while (iterator2 < n3)
            {
                linia += "*";
                Console.WriteLine(linia);
                iterator2++;
            }
            Console.WriteLine("---------------------------------------------------");


            /**
            Zadanie 5 * dodatkowe
            Utwórz zmienną exam, która będzie zawierała wartość od 0 do 100.
            Zmienna exam przechowuje wyniki egzaminu.
            Utwórz kod, który wyświetli w konsoli ocenę z testu na podstawie zmiennej point, według poniższego schematu.
                0 - 39 pkt - Ocena Niedostateczna
                40 - 54 pkt - Ocena Dopuszczająca
                55 - 69 pkt - Ocena Dostateczna
                70 - 84 pkt - Ocena Dobra
                85 - 98 pkt - Ocena Bardzo Dobra
                99 - 100 pkt - Ocena Celująca
            W przypadku gdy wartość exam jest mniejsza od 0 lub większa od 100 wyświetl komunikat: Wartość poza zakresem.
            Przykład: Dla point z wartością 57, w konsoli powinno wyświetlić się Ocena Dostateczna.
            */

            int exam;
            //int point;

            Console.WriteLine("Podaj ilość zdobytych punktów na egzaminie (zakres <0;100>)");
            if (!int.TryParse(Console.ReadLine(), out int point))
            {
                Console.WriteLine("Niepoprawnie wprowadzona liczba");
            }
            else
            {
                Console.WriteLine("Wprowadziłeś point = {0}", point);
                exam = point;
                if ((exam>=0)&&(exam<=39))
                {
                    Console.WriteLine("Ocena Niedostateczna");
                }
                else if ((exam >= 40) && (exam <= 54))
                {
                    Console.WriteLine("Ocena Dopuszczająca"); 
                }
                else if ((exam >= 55) && (exam <= 69))
                {
                    Console.WriteLine("Ocena Dostateczna");
                }
                else if ((exam >= 70) && (exam <= 84))
                {
                    Console.WriteLine("Ocena Dobra"); 
                }
                else if ((exam >= 85) && (exam <= 98))
                {
                    Console.WriteLine("Ocena Bardzo Dobra"); 
                }
                else if ((exam >= 99) && (exam <= 100))
                {
                    Console.WriteLine("Ocena Celująca"); 
                }
                else
                {
                    Console.WriteLine("Wartość poza zakresem");
                }
            }
            Console.WriteLine("---------------------------------------------------");



            /**
            Kolekcje
            Zadanie 1
            Utwórz czteroelementową tablicę typu string o nazwie colors.
            Tablicę uzupełnij dowolnymi nazwami kolorów.
            Wyświetl pierwszy kolor z tablicy w konsoli według wzoru Mój pierwszy kolor to: niebieski.
            Wyświetl ostatni kolor z tablicy w konsoli według wzoru Mój ostatni kolor to: czerwony.
             */
            string[] colors = new string[4];
            colors[0] = "niebieski";
            colors[1] = "zielony";
            colors[2] = "czerwony";
            colors[3] = "żółty";

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);
            Console.WriteLine("---------------------------------------------------");

            /**
            Zadanie 2
            Stwórz tablicę z 10 dowolnymi liczbami.
            Następnie wypisz w konsoli, przy użyciu pętli for, foreach i while 10 razy tekst Liczba: 13, gdzie 13 będzie kolejną liczbą z tablicy.
            Wzór
                Liczba: 0
                Liczba: 1
             */

            int[] tablica = new int[10] { 12, 15, 2, 89, 54, -12, 44, 0, 1, 100 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Liczba: {0}", tablica[i]);
            }
            Console.WriteLine("---------------------------------------------------");

            foreach (int item in tablica)
            {
                Console.WriteLine("Liczba: {0}", item);
            }
            Console.WriteLine("---------------------------------------------------");

            int iterator3 = 0;
            while (iterator3<10)
            {
                Console.WriteLine("Liczba: {0}", tablica[iterator3]);
                iterator3++;
            }
            Console.WriteLine("---------------------------------------------------");

            /**
            Zadanie 3
            Utwórz czteroelementową listę List<string> o nazwie fruits.
            Tablicę uzupełnij dowolnymi nazwami owoców, używając metody remove.
            Wyświetl w konsoli wszystkie owoce według wzoru Pomidor, Jabłko, Marchewka. Między nazwami owoców musi się znaleźć przecinek i spacja.
            Usuń za pomocą metod Revome i RemoveAt pierwszy i ostatni element listy.
            Wyświetl wszystkie elementy listy.
             */

            List<string> fruits = new List<string>();

            fruits.Add("śliwka");
            fruits.Add("jagoda");
            fruits.Add("grzyb");
            fruits.Add("pomarańcza");
            fruits.Add("porzeczka");
            fruits.Remove("grzyb");


            fruits.ForEach(fruit  => Console.Write(fruit + ", "));
            Console.WriteLine();
            //foreach (var item in fruits)
            //{
            //    Console.Write(item + ", ");
            //}
            fruits.Remove("śliwka");
            fruits.RemoveAt(fruits.Count - 1);
            fruits.ForEach(fruit => Console.Write(fruit + ", "));
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");



        }
    }
}
