//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myWcfService
{
    using System;
    using System.Collections.Generic;
    
    public partial class InOrder
    {
        public int ID_InOrder { get; set; }
        public Nullable<int> ID_Order { get; set; }
        public Nullable<int> ID_Book { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<double> Price { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}