using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDb.Model
{
    public class ItemList
    {
        public ItemList()
        {

        }

        public int ItemListId { get; set; }
        public DateTime EntryAdded { get; set; }
        public DateTime EntryDue{ get; set; }
        public int AmountItems { get; set; }
    }
}
