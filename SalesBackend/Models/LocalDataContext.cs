

namespace SalesBackend.Models
{
    using SalesDomain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<SalesCommon.Models.Product> Products { get; set; }
    }
}