using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Domain.Entities.Base.Identity;
using WebStor.Domain.Entities.Orders;
using WebStor.Services.Interfaces;
using WebStor.ViewModels;
using WebStore.DAL.Context;

namespace WebStor.Services.InSQL
{
    public class SqlOrderService : IOrderService
    {
        private WebStoreDB _db;
        private UserManager<User> _UserManager;

        public SqlOrderService(WebStoreDB db, UserManager<User> UserManager)
        {
            _db = db;
            _UserManager = UserManager;
        }

        public Task<Order> CreateOrder(string UserName, CartViewModel Cart, OrderViewModel OrderModel)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetUserOrders(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
