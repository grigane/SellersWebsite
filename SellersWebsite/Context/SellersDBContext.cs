using Microsoft.EntityFrameworkCore;
using SellersWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellersWebsite.Context
{
    public class SellersDBContext : DbContext
    {
        //public DbSet<ProductModel> Products { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-SUH77G6\SQLEXPRESS; Database=SellingDB; Trusted_Connection=True;");

        public SellersDBContext(DbContextOptions<SellersDBContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
