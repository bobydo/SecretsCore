using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Threading.Tasks;
using WiredBrain.CustomerPortal.Web.Data;
using WiredBrain.CustomerPortal.Web.Models;

namespace WiredBrain.CustomerPortal.Web.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerPortalDbContext _customerPortalDbContext;

        public CustomerRepository()
        {
            _customerPortalDbContext = new CustomerPortalDbContext();
            
            if (!_customerPortalDbContext.Customers.Any())
            {
                _customerPortalDbContext.Seed();
            }
        }

        public async Task<Customer> GetCustomerByLoyaltyNumber(int loyaltyNumber)
        {
            var customer = _customerPortalDbContext.Customers.SingleOrDefault(c => c.LoyaltyNumber == loyaltyNumber);
            return customer;
        }

        public async Task SetFavorite(EditFavoriteModel model)
        {
            var customer = _customerPortalDbContext.Customers.SingleOrDefault(c => c.LoyaltyNumber == model.LoyaltyNumber);

            customer.FavoriteDrink = model.Favorite;
            await _customerPortalDbContext.SaveChangesAsync();
        }
    }
}
