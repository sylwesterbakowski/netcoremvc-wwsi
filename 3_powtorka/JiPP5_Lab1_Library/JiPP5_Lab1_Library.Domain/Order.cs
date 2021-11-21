using JiPP5_Lab1_Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP5_Lab1_Library.Domain
{
    public class Order
    {

        ///Zadanie 6: Orders
        ///1. Otwórz projek Library.Domain
        ///2. Stwórz klasę BookOrdered, która powinna zawierac:
        ///     Propertis BookId typu int
        ///     Propertis NumerOrdered typu int
        ///3. Stwórz klasę Order, która powinna zawierac:
        ///     Propertis Date typu DateTime
        ///     propertis BooksOrderedList typu List<BookOrdered>
        ///     Bezparametrowy konstruktor, w którego ciele zastaną wykonane następujące akcję:
        ///         Ustawienie propertisa Date na wartosc DateTime.Now
        ///         Zainicjalizowanie listy BooksOrderedList pustą listą
        ///     Metodę ToString (pamiętaj o uzyciu override), która wygeneruje ciąg znaków w postaci
        ///         Order: DataUtworzenia obiektu
        ///         Book: IdKsiazki Count: IloscZamowionych ksiazek
        ///     w tym celu mozesz uzyc interpolacji stringów
        ///         string str = "Test";
        ///         str += $"Test: {JakasZmienna} Test2: {JakasZmienna}";




        public DateTime Date { get; set; }

        public List<BookOrdered> BooksOrderedList { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }
        public override string ToString()
        {
            string tekst = $"Order: {Date} \n";
            foreach (BookOrdered item in BooksOrderedList)
            {
                tekst += $"Book: { item.BookId} Count: {item.NumerOrdered} \n";
            }     
            return tekst;
        }
    }
}
