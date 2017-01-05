using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Data.Entity;
namespace Brunner.OnlineShoppingCart.Service.Model
{
    public class ShoppingCart
    {
        public Customer Customer { get; set; }
        public List<CartItems> Items { get; set; }
        public decimal Total { get; set; }
    }
}
