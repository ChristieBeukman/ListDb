using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ListDb.Model
{
    public class ListContext : DbContext
    {
        public ListContext() : base("ListDB")
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }
    }
}
