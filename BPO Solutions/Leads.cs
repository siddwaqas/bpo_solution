//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPO_Solutions
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leads
    {
        public int ID { get; set; }
        public Nullable<int> Emp_ID { get; set; }
        public Nullable<int> No_Of_Leads { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
