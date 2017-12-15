using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleApp.Data_Access_Layer.DatModels;

namespace SampleApp.Data_Access_Layer.EPIServiceDAL
{
    public class EPIServices : DbContext
    {
        public EPIServices(DbContextOptions<EPIServices> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCards> CustomerCard { get; set; }
        public DbSet<DataModels.Merchant> Merchant { get; set; }
        public DbSet<DataModels.Profile> Profile { get; set; }
    }
}
