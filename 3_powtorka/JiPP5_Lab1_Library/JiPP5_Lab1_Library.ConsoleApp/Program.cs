using JiPP5_Lab1_Library.Domain;
using JiPP5_Lab1_Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP5_Lab1_Library.ConsoleApp
{
    class Program
    {
        
        ///Warsztat
        ///Zadanie 1: Zapoznanie się z Visual Studio
        ///1. Utwórz nową solucję o nazwie Library
        ///2. W solucji utwórz projekt Library.ConsoleApp typu aplikacja konsolowa
        ///3. W solucji utwórz projekt Library.Domain typu ClassLib
        ///4. W solucji utwórz projekt Library.Persistence typu ClassLib
        ///5. W projekcie Library.Persistence dodaj referencję do projektu Library.Domain
        ///6. W projekcie Library.ConsoleApp dodaj referencję do projektów Library.Domain i Library.Persistence
        ///7. W projekcie Library.Domain utwórz klasę ksiązki, mozesz ją skopiowac z kodu ponizej
        ///    public class Book
        ///    {
        ///        public string Title { get; set; }
        ///        public string Author { get; set; }
        ///        public int PublicationYear { get; set; }
        ///        public string ISBN { get; set; }

        ///        public int ProductsAvailable { get; set; }
        ///        public decimal Price { get; set; }
        
        ///        public Book() {}

        ///        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        ///        {
        ///            Title = title;
        ///            Author = author;
        ///            ISBN = isbn;
        ///            PublicationYear = publicationYear;
        ///            ProductsAvailable = productsAvailable;
        ///            Price = price;
        ///        }

        ///        public override string ToString()
        ///        {
        ///            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        ///        }
        ///    }
        ///8. W projekcie Library.Persistence utwórz klasę BooksRepository, na chwilę obecną moze to byc pusta klasa
        ///9. W projekcie Library.ConsoleApp w pliku Program.cs utworz obiekt wczesniej utworzonych klas
        ///    Book book = new Book(/*uzupelnij parametry*/);
        ///    BooksRepository repository = new BooksRepository();
        ///10. Skompiluj projek aby sprawdzic czy nie ma w nim błędów.
        ///11. *Utwórz katalog solucji Presentation
        ///12. *Przenies do katalogu Presentation projekt Library.ConsoleApp
        ///13. *Utworz katalog solucji Logic
        ///14. *Przenies do katalogu Logic projekty Library.Domain oraz Library.Persistence
         
        static void Main(string[] args)
        {
            Book book = new Book("Janko Muzykant", "Henryk Sienkiewicz",2020, "83-7327-179-1", 10,3.49m);
            //BooksRepository repository = new BooksRepository();


            ///Zadanie 2: Instrukcje Warunkowe / Debugowanie
            ///1. Otwórz plik Program.cs w projekcie Library.ConsoleApp
            ///2. Za pomocą API obiektu console, pobierz od uzytkownika jego login i haslo
            ///     string text = Console.ReadLine();
            Console.Write("login: ");
            string login = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();
            ///3. Jezeli login to Admin a haslo to password wypisz na consoli napis Access Granted
            ///4. W przeciwnym wypadku wypisz napis Access Denied
            if ((login=="Admin") && (password=="password"))
            {
                Console.WriteLine("Access Granted");


                ///5. Za pomocą przycisku F9(lub klikając w lewą kolumnę edytora) oznacz miejsce z if-em, tak aby wykonywanie programu zatrzymało się.
                ///6. Urucham projekt Library.ConsoleApp w trybie Debug
                ///7. Za pomocą przycisku F10 przejdź przez flow programu



                ///Zadanie 3: Utworzenie menu w aplikacji konsol / Pętle sterujące
                ///1. Otworz plik Program.cs z aplikacji Library.ConsoleApp
                ///2. Następnie za pomocą pętli zczytuj kolejne linie tekstu wprowadzone przez uzytkownika
                ///3. Pętla ma zakończyc swoje zadanie kiedy uzytkownik wpisze komende wyjdz
                ///4. Pętla ma czekac az uzytkownik wprowadzi komende
                ///5. Wewnątrz pętli sprawdzaj jaką komendę podał uzytkownik według ponizszej rozpiski:
                ///    dodaj->Powinna wypisac tekst: "proba dodania ksiazki"
                ///    usun->Powinna wypisac tekst: "proba usuniecia ksiazki"
                ///    wypisz->Powinna wypisac tekst: "proba wypisania wszystkich ksiazek"
                ///    zmien->Powinna wypisac tekst: "proba zmiany stanu magazynowego ksiazek"
                ///    dodaj zamowienie -> Powinna wypisac tekst: "proba dodania nowego zamowienia"
                ///    lista zamowien -> Powinna wypisac tekst: "proba wypisania wszystkich zamowien"
                ///6. Wykorzystaj komende Console.Clear() aby po wprowadzeniu komendy ekran konsoli wypisywal tylko menu aplikacji
                ///7. Wykorzystaj komendę Console.WriteLine aby wyswietlic uzytkownikowi mozliwe do wpisania komendy
                ///8. *W przypadku kiedy uzytkownik poda nie wspierana komende, aplikacja powinna wyswietlic informacje ze podana komenda nie jest wspierana
                ///9. *Po kazdej komendzie aplikacja powinna wyswietlic napis: Press AnyKey i wstrzymac wykonywanie programu do czasu wcisniecia klawisza

                ///#### Zadanie 4: Books Service
                ///3. Przejdz do pliku Program.cs w projekcie Library.ConsoleApp
                ///4. Przed pętlą utwórz obiekt klasy BooksService
                ///5. W srodku pętli podmien wyswietlanie tekstow na wywołanie odpowiedniej metody z obiektu klasy BooksService
                ///6. Uruchom aplikację i sprawdz czy wsyzstko działa poprawnie

                ///Zadanie 5: Dodanie repozytorium

                ///13. Przejdz do pliku Program.cs i przed utworzeniem obiektu BooksService utworz obiekt klasy BooksRepository
                ///14. Przekaz obiekt klasy BooksRepository do konstruktora klasy BooksService
                ///15. Przetestuj czy mozna dodac nową ksiązke do repozytorium

                ///Zadanie 6: Orders
                ///14. Przejdz do pliku Program.cs w projekcie Library.ConsoleApp
                ///15. Utwórz obiekt klasy OrdersRepository przed główną pętlą programu
                ///16. Utwórz obiekt klasy OrdersService, wykorzystując przy tym wczesniej utworzony obiekt klasy OrdersRepository
                ///17. Wykorzystaj obiekt klasy OrdersService aby podpiąc jego metody do zadan:
                ///     dodaj zamowienie
                ///     lista zamowien
                ///18. Uruchom aplikację Library.ConsoleApp w trybie debug-u
                ///19. Przetestuj czy dodawanie zamowien działa poprawnie
                ///20. *Zrób zabezpieczenie aby nie dało się dodac do zamówienia ksiazki, której nie ma na w repozytorium
                ///21. *Zrób zabezpieczenie aby do zamowienia nie dało się dodac więcej ksiązek, niz jest w repozytorium.


                BooksRepository booksRepository = new BooksRepository();

                BooksService booksService = new BooksService(booksRepository);

                OrdersRepository ordersRepository = new OrdersRepository();

                OrderService orderService = new OrderService(ordersRepository);

                Console.WriteLine("Press AnyKey");
                Console.ReadKey();
                
                string tekst = "";
                while (tekst!="wyjdz")
                {
                    //czyszczenie konsoli
                    Console.Clear();
                    //MENU
                    Console.WriteLine("MENU PROGRAMU");
                    Console.WriteLine("dodaj - dodanie ksiazki");
                    Console.WriteLine("usun - usuniecie ksiazki");
                    Console.WriteLine("wypisz - wypisanie wszystkich ksiazek");
                    Console.WriteLine("zmien - zmiana stanu magazynowego ksiazek");
                    Console.WriteLine("dodaj zamowienie - dodanie nowego zamowienia");
                    Console.WriteLine("lista zamowien - wypisanie wszystkich zamowien");
                    Console.WriteLine("wyjdz - wyjscie z programu");

                    //komenda użytkownika
                    tekst = Console.ReadLine();
                    switch (tekst)
                    {
                        case "dodaj":
                            //Console.WriteLine("proba dodania ksiazki");
                            booksService.AddBook();
                            break;
                        case "usun":
                            //Console.WriteLine("proba usuniecia ksiazki");
                            booksService.RemoveBook();
                            break;
                        case "wypisz":
                            //Console.WriteLine("proba wypisania wszystkich ksiazek");
                            booksService.ListBooks();
                            break;
                        case "zmien":
                            //Console.WriteLine("proba zmiany stanu magazynowego ksiazek");
                            booksService.ChangeState();
                            break;
                        case "dodaj zamowienie":
                            //Console.WriteLine("proba dodania nowego zamowienia");
                            orderService.PlaceOrder(booksService);
                            break;
                        case "lista zamowien":
                            //Console.WriteLine("proba wypisania wszystkich zamowien");
                            orderService.ListAll();
                            break;
                        case "wyjdz":
                            break;
                        default:
                            Console.WriteLine("komenda nie jest wspierana");
                            break;
                    }
                    Console.WriteLine("Press AnyKey");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Access Denied");
                Console.WriteLine("Press AnyKey");
                Console.ReadKey();
            }
        }
    }
}
