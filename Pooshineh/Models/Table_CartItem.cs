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
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class Table_CartItem
    {
        public int CartItemID { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set; }
        [Display(Name = "تعداد")]
        public int Quantity { get; set; }
        [Display(Name = "قیمت")]
        public int Price { get; set; }

        public virtual Table_Products Table_Products { get; set; }
        public virtual Table_Cart Table_Cart { get; set; }
    }
}
