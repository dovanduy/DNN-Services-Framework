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
    
    public partial class DNNAwesome_Status
    {
        public DNNAwesome_Status()
        {
            this.DNNAwesome_Customer = new HashSet<DNNAwesome_Customer>();
        }
    
        public int StatusID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<DNNAwesome_Customer> DNNAwesome_Customer { get; set; }
    }
}
