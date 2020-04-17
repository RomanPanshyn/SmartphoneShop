using System.Collections.Generic;
using SmartphoneShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SmartphoneShop.Data
{
    public interface ISmartphoneRepository
    {
        IEnumerable<Product> GetAllProducts();
        //IEnumerable<Product> GetProductsByCategory(string category);

        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderById(string username, int id);
        void AddOrder(Order newOrder);

        bool SaveAll();
        void AddEntity(object model);
    }
}