//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Lab_PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionDetail
    {
        public int TransactionID { get; set; }
        public int SupplementID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual MsSupplement MsSupplement { get; set; }
        public virtual TransaactionHeader TransaactionHeader { get; set; }
    }
}
