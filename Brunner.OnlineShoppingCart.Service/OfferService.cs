using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Service.Model;
using Brunner.OnlineShopping.EnumsCollection;
namespace Brunner.OnlineShoppingCart.Service
{
    public class OfferService
    {
        public void ApplyOffer(ShoppingCart cart)
        {
            var totalApples = cart.Items.Where(z => z.Product == ProductLookUp.Apple).Select(z => z.Qty).FirstOrDefault();
            if (totalApples > 0)
            {
                decimal appleCost = cart.Items.Where(z => z.Product == ProductLookUp.Apple).FirstOrDefault().Price;
                cart.Total += TotalBillableItems(totalApples, 1, 1) * appleCost;
            }
            var totalOranges = cart.Items.Where(z => z.Product == ProductLookUp.Orange).Select(z => z.Qty).FirstOrDefault();
            if (totalOranges > 0)
            {
                decimal orangeCost = cart.Items.Where(z => z.Product == ProductLookUp.Orange).FirstOrDefault().Price;
                cart.Total += TotalBillableItems(totalOranges, 2, 1) * orangeCost;
            }
        }

        private int TotalBillableItems(int totalItems, int paidItems, int freeItems)
        {

            int totalFreeItems = totalItems / (paidItems + freeItems);
            int totalpayableitems = totalItems - totalFreeItems;
            return totalpayableitems;
        }


    }
}
