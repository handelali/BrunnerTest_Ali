using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Service.Model;
using Brunner.OnlineShoppingCart.Data.Entity;

namespace Brunner.OnlineShoppingCart.Service
{
    public class CheckOutService
    {
        public void CheckOut(ShoppingCart cart, bool isOfferAvailable)
        {



            if (isOfferAvailable)
            {
                OfferService offerService = new OfferService();
                offerService.ApplyOffer(cart);
            }
            else
            {
                cart.Total = cart.Items.Select(x => x.Price * x.Qty).Sum();
            }
        }
    }
}
