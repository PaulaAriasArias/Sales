using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDomain.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<SalesCommon.Models.Product> Products { get; set; }
    }
}
