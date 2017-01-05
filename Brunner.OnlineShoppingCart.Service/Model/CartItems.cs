using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Data.Entity;
using Brunner.OnlineShopping.EnumsCollection;
namespace Brunner.OnlineShoppingCart.Service.Model
{
    public class CartItems
    {
        public int Id { get; set; }
        public ProductLookUp Product { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
