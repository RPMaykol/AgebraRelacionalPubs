//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADONetEF2
{
    using System;
    using System.Collections.Generic;
    
    public partial class titles
    {
        public titles()
        {
            this.sales = new HashSet<sales>();
            this.titleauthor = new HashSet<titleauthor>();
        }
    
        public string title_id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string pub_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> advance { get; set; }
        public Nullable<int> royalty { get; set; }
        public Nullable<int> ytd_sales { get; set; }
        public string notes { get; set; }
        public System.DateTime pubdate { get; set; }
    
        public virtual publishers publishers { get; set; }
        public virtual ICollection<sales> sales { get; set; }
        public virtual ICollection<titleauthor> titleauthor { get; set; }
        public virtual roysched roysched { get; set; }
    }
}
