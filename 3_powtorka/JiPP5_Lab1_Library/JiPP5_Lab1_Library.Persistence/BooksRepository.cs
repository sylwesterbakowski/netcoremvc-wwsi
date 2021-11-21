using JiPP5_Lab1_Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP5_Lab1_Library.Persistence
{
    public class BooksRepository
    {



        ////Zadanie 5: Dodanie repozytorium
        ////1. Otwórz klasę BooksRepository znajdującą się w projekcie Library.Persistence
        ////2. Utwórz pole readonly List<Book> o nazwie _database
        ////3. Utwórz bezparametroy Konstruktor
        ////4. W konstruktorze dodaj kilka ksiązek, mozesz do tego uzyc ponizszych:
        ////    new Book("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m),
        ////    new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m),
        ////    new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m),
        ////    new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m),
        ////    new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m),
        ////    new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m),
        ////    new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m),
        ////    new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m),
        ////    new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m),
        ////    new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m),   
        ////5. Dodaj metodę Insert(Book book) : void, która będzie odpowiedzialna za dodawanie nowej ksiązki do listy
        ////6. Dodaj metodę GetAll(): List<Book>, która będzie zwracac wszystkie ksiązki, które znajdują się w repozytorium
        ////7. Dodaj metodę RemoveByTitle(string title): void, która będzie kasowac wybraną ksiązke z repozytorium.Aby szybciej namierzyc ksiązke mozesz uzyc ponizszego wyrazenia LINQ
        ////    .First(x => x.Title == title)
        ////8. Dodaj metode ChangeState(string title, in stateChange), która będzie uaktualniac stan w wybranym tytule.Wykorzystaj wyrazenie LINQ z poprzedniego cwiczenia.


        //private readonly List<Book> _database;
        private readonly List<Book> _database = new List<Book>();

        public List<Book> Database
        {
            get
            {
                return _database;
            }

        }

        public BooksRepository()
        {
            Book book = new Book("Stary człowiek i morze",
                                        "Ernest Hemingway",
                                        1986,
                                        "AAAA",
                                        10,
                                        19.99m);
            Database.Add(book);
            Database.Add(new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m));
            Database.Add(new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m));
            Database.Add(new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m));
            Database.Add(new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m));
            Database.Add(new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m));
            Database.Add(new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m));
            Database.Add(new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m));
            Database.Add(new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m));
            Database.Add(new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m));
        }

        public void Insert(Book book)
        {
            Database.Add(book);
        }

        public List<Book> GetAll()
        {
            return Database;
        }

        public void RemoveByTitle(string title)
        {
            Database.Remove(Database.First(x => x.Title == title));
        }

        public void ChangeState(string title, int stateChange)
        {
            Database.First(x => x.Title == title).ProductsAvailable += stateChange;

        }
    }

}
