using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.OnlineShoppingCart.Data.Entity;
namespace Brunner.OnlineShoppingCart.Data.Repository
{
    class ProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchBy(string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
