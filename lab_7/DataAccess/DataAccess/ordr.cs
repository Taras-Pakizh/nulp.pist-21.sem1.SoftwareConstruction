//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class ordr
    {
        public int id_ordr { get; set; }
        public int client { get; set; }
        public Nullable<decimal> price { get; set; }
        public int employee { get; set; }
        public int delivery { get; set; }
    
        public virtual client client1 { get; set; }
    }
}
