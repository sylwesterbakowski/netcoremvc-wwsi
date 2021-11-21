using JiPP5_Lab1_Library.Domain;
using JiPP5_Lab1_Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP5_Lab1_Library.ConsoleApp
{
    public class BooksService
    {

        ///#### Zadanie 4: Books Service

        ///1. W projekcie Library.ConsoleApp stwórz klasę BooksService
        ///2. W klasie BooksService zaimplementuj takie metody jak:
        ///     AddBook() :void -> Powinno pobrac od uzytkownika wszystkie dane potrzebne do stworzenia instancji klasy Book
        ///     RemoveBook() :void -> Powinno pobrac od uzytkownika tytul ksiazki do usuniecia
        ///     ListBooks():void -> Ta metoda powinna wyswietlic napis Tutaj pojawi sie lista ksiazek
        ///     ChangeState() :void -> Ta metoda powinna pobrac od uzytkownikow tytul ksiazki, której stan ma się zmienic oraz samą zmianę stanu np. -1 
        ///     Do konwersji string-a na int-a uzyj klasy Convert
        ///     Convert.ToInt32(Console.ReadLine());

        ///Zadanie 5: Dodanie repozytorium
        ///9. Przejdz do pliku BooksService w projekcie Library.ConsoleApp
        ///10. Utwórz konstruktor, w którym jedynym parametrem będzie obiekt klasy BooksRepository
        ///11. Przypisz obiekt klasy BooksRepository do pola w klasie o nazwie _repository
        ///12. Wykorzystaj obiekt _repository w wywołaniach metod klasy BooksService
        


        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int publicationYear;

        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }

        private string isbn;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        private int productsAvailable;

        public int ProductsAvailable
        {
            get { return productsAvailable; }
            set { productsAvailable = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int changeQuantity;

        public int ChangeQuantity
        {
            get { return changeQuantity; }
            set { changeQuantity = value; }
        }

        public BooksRepository Repository { get => _repository; set => _repository = value; }

        private BooksRepository _repository;
        public BooksService(BooksRepository booksRepository)
        {
            Repository = booksRepository;
        }

        public void AddBook()
        {
            Console.WriteLine("Podaj tytul");
            Title = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            Author = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania");
            PublicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ISBN");
            ISBN = Console.ReadLine();
            Console.WriteLine("Podaj ilosc ksiazek");
            ProductsAvailable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cene");
            Price = Convert.ToDecimal(Console.ReadLine());
            Repository.Insert(new Book(Title, Author, PublicationYear, ISBN, ProductsAvailable, Price));
        }
        public void RemoveBook()
        {
            Console.WriteLine("Podaj tytul");
            Title = Console.ReadLine();
            Repository.RemoveByTitle(Title);
        }
        public void ListBooks()
        {
            //Console.WriteLine("Tutaj pojawi sie lista ksiazek");
            foreach (Book item in Repository.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void ChangeState()
        {
            Console.WriteLine("Podaj tytul");
            Title = Console.ReadLine();
            Console.WriteLine("Podaj o ile zmienic ilosc ksiazek");
            ChangeQuantity = Convert.ToInt32(Console.ReadLine());
            Repository.ChangeState(Title, ChangeQuantity);
        }

    }
}
