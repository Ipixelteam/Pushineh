//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pooshineh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    
        public virtual Table_Orders Table_Orders { get; set; }
    }
}