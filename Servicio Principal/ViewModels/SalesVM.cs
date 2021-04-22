using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SalesVM
    {
        public int IdSale { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime SaleDate { get; set; }

        public double SubTotalAmount { get; set; }

        public double TaxTotalAmount { get; set; }

        public double TotalAmount { get; set; }

        public string CompanyNIT { get; set; }

        public string CompanyName { get; set; }

        public string ClientName { get; set; }

        public string ClientEmail { get; set; }
    }
}
