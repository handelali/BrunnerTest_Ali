using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Service.Model;
namespace Brunner.OnlineShoppingCart.Service
{
    public interface ICartItemService
    {
        void AddItem(CartItems item);
        void DeleteItem(CartItems item);
        List<CartItems> GetCartItems();
    }
}
