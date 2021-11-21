using JiPP5_Lab1_Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP5_Lab1_Library.Persistence
{
    public class OrdersRepository
    {

        ///Zadanie 6: Orders
        ///Przejdz do projektu Library.Persistence
        ///Utworz klasę OrdersRepository
        ///Wewnatrz klasy OrdersRepository utwórz prywatne pole database typu List, które od razu zainicjalizu pustą listą.
        ///Wewnatrz klasy OrdersRepository zaimplementuj dwie metody:
        ///    Insert(Order order): void -> wywołanie tej metody ma dodawac elementy do kolekcji
        ///    GetAll(): List<Order> -> wywołanie tej metody ma zwrócic wszystkie wczesniej dodane order-y

        private readonly List<Order> database  = new List<Order>();

        public List<Order> Database
        {
            get
            {
                return database;
            }
        }

        public void Insert(Order order)
        {
            Database.Add(order);
        }

        public List<Order> GetAll()
        {
            return Database;
        }
    }    
}
