//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListDb.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemList
    {
        public int ItemListId { get; set; }
        public System.DateTime EntryAdded { get; set; }
        public System.DateTime EntryDue { get; set; }
        public int AmountItems { get; set; }
        public Nullable<int> ItemCategory_ItemCategoryId { get; set; }
        public Nullable<int> Item_ItemId { get; set; }
        public Nullable<int> Supplier_SupplierId { get; set; }
    
        public virtual ItemCategory ItemCategory { get; set; }
        public virtual Item Item { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
