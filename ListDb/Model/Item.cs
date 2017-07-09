using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDb.Model
{
    public class Item
    {
        public Item()
        {

        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int QtyPerUnit { get; set; }

        public IList<ItemList> ItemLists { get; set; }
    }
}
