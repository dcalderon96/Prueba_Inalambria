//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleDetail
    {
        public int IdSaleDetail { get; set; }
        public int IdSale { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotalAmount { get; set; }
        public double TaxTotalAmount { get; set; }
        public double TotalAmount { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Sales Sales { get; set; }
    }
}
