//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DNNAwesomeService.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DNNAwesome_Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual DNNAwesome_Customer DNNAwesome_Customer { get; set; }
    }
}
