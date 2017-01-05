using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Data.Entity;
using Brunner.OnlineShoppingCart.Data.Repository;
namespace Brunner.OnlineShoppingCart.Service
{
    public interface ICustomerService
    {
         void Add(Customer entity);

        Customer FindById(int Id);
       
    }
}
