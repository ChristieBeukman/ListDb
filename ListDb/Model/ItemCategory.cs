using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDb.Model
{
    public class ItemCategory
    {

        public ItemCategory()
        {

        }

        public int ItemCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public IList<Item> Items { get; set; }
        public IList<ItemList> ItemLists { get; set; }
    }
}
