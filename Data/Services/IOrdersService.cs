using sanjay_cp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sanjay_cp.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrder(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRole(string userId, string userRole);

    }                                                       //Vid. 73 & 94Implement Identity
}
