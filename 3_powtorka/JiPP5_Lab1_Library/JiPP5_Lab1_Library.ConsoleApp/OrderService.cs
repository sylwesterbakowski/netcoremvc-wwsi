using JiPP5_Lab1_Library.Domain;
using JiPP5_Lab1_Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP5_Lab1_Library.ConsoleApp
{
    public class OrderService
    {

        ///Zadanie 6: Orders
        ///8. Przejdz do projektu Library.ConsoleApp
        ///9. Utwórz klasę OrderService
        ///10. W klasie OrderService utwórz konstruktor, który będzie przyjmował obiekt klasy OrdersRepository jako swój paramter
        ///11. W konstruktorze klasy OrderService przypisz obiekt klasy OrderRepository do prywatnego pola o nazwie _orderRepository
        ///12. W klasie OrderService zaimplementuj metodę PlaceOrder, która będzie odpowiedzialna za proces składania nowego zamówienia:
        ///     Utworzenie obiektu klasy Order,
        ///     Wypisanie menu w postaci:
        ///         add - dodaj pozycje do zamowienia
        ///         end - zamknij zamowienie
        ///     W momencie wpisania komendy add, program powinien zapytac uzytkownika o:
        ///         Id ksiązki
        ///         Ilosc
        ///     Następnie utworzyc obiekt klasy BookOrdered i dodac go do pola BooksOrderedList z obiektu order
        ///     Następnie powrócic do menu add / end aby bylo mozliwe dodanie wiecej niz tylko jednej pozycji w zamowieniu
        ///     W momencie wpisania komendy end program powinien dodac obiekt order do repozytorium
        ///13. W klasie OrderService zaimplementuj metodę ListAll, której zadaniem będzie wypisanie wszystkich zamowien pobranych z repozytorium





        private OrdersRepository _orderRepository;

        public OrderService(OrdersRepository ordersRepository)
        {
            _orderRepository = ordersRepository;
        }

        public void PlaceOrder(BooksService booksService)
        {
            Order order = new Order();
            

            string tekst = "";
            while (tekst != "end")
            {
                //czyszczenie konsoli
                Console.Clear();
                //MENU
                Console.WriteLine("MENU ZAMOWIENIA");
                Console.WriteLine("add - dodaj pozycje do zamowienia");
                Console.WriteLine("end - zamknij zamowienie");
                tekst = Console.ReadLine();
                switch (tekst)
                {
                    case "add":
                        //if (order.BooksOrderedList.Count < booksService.Repository.Database.Count)
                        //{
                            BookOrdered bookOrdered = new BookOrdered();
                            //Console.WriteLine("proba dodania zamowienia");
                            Console.WriteLine("Podaj Id ksiazki");
                            bookOrdered.BookId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Podaj ilosc");
                            bookOrdered.NumerOrdered = Convert.ToInt32(Console.ReadLine());
                            if (bookOrdered.BookId < booksService.Repository.Database.Count())
                            {
                                if (bookOrdered.NumerOrdered <= booksService.Repository.Database.ElementAt(bookOrdered.BookId).ProductsAvailable)
                                {
                                    order.BooksOrderedList.Add(bookOrdered);
                                }
                                else
                                {
                                    Console.WriteLine("Nie ma tylu tych ksiazek w repozytorium");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Nie ma takiej ksiazki w repozytorium");
                            }
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Nie ma wiecej ksiazek w repozytorium");
                        //}
                        break;
                    case "end":
                        if (order.BooksOrderedList.Count > 0)
                        {
                            _orderRepository.Insert(order);
                        } 
                        break;
                    default:
                        Console.WriteLine("komenda nie jest wspierana");
                        break;
                }
                Console.WriteLine("Press AnyKey");
                Console.ReadKey();
            }
            
        }

        public void ListAll()
        {
            foreach (Order item in _orderRepository.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
