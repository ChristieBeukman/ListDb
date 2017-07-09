using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDb.Model
{
    [Table("Item")]
    public class Item
    {
        public Item()
        {

        }

        [Key]
        public int ItemId { get; set; }

        [Column("ItemName", TypeName ="ntext")]
        public string ItemName { get; set; }

        [Column("ItemDescription", TypeName = "ntext")]
        public string ItemDescription { get; set; }

        [NotMapped]
        public int QtyPerUnit { get; set; }

        [ForeignKey("ItemId")]
        public IList<ItemList> ItemLists { get; set; }
    }
}
