using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;

namespace ECommerce.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
    }
}
