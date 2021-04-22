using DataConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels;

namespace HermesWebService.Models
{
    public class SalesService
    {
        private HermesServiceEntities dbContext; 

        public object GetAllSales()
        {
            dbContext = new HermesServiceEntities();
            List<SalesVM> ventas = new List<SalesVM>();
            try
            {
                ventas = (from venta in dbContext.Sales.ToList()
                          join empresa in dbContext.Companies.ToList()
                          on venta.IdCompany equals empresa.IdCompany
                          join usuario in dbContext.Users.ToList()
                          on venta.IdUser equals usuario.IdUser
                          select new SalesVM
                          {
                              IdSale = venta.IdSale,
                              InvoiceNumber = venta.InvoiceNumber,
                              SaleDate = venta.SaleDate,
                              SubTotalAmount = venta.SubTotalAmount,
                              TaxTotalAmount = venta.TaxTotalAmount,
                              TotalAmount = venta.TotalAmount,
                              CompanyNIT = empresa.NIT,
                              CompanyName = empresa.Fullname,
                              ClientName = usuario.Name,
                              ClientEmail = usuario.Email
                          }).ToList();
                return ventas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object GetSalesByCompany(string nit)
        {
            dbContext = new HermesServiceEntities();
            List<SalesVM> ventas = new List<SalesVM>();
            try
            {
                ventas = (from venta in dbContext.Sales.ToList()
                          join empresa in dbContext.Companies.ToList()
                          on venta.IdCompany equals empresa.IdCompany
                          join usuario in dbContext.Users.ToList()
                          on venta.IdUser equals usuario.IdUser
                          where empresa.NIT.Equals(nit)
                          select new SalesVM
                          {
                              IdSale = venta.IdSale,
                              InvoiceNumber = venta.InvoiceNumber,
                              SaleDate = venta.SaleDate,
                              SubTotalAmount = venta.SubTotalAmount,
                              TaxTotalAmount = venta.TaxTotalAmount,
                              TotalAmount = venta.TotalAmount,
                              CompanyNIT = empresa.NIT,
                              CompanyName = empresa.Fullname,
                              ClientName = usuario.Name,
                              ClientEmail = usuario.Email
                          }).ToList();
                return ventas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object GetSalesByDates(DateTime fechaInicio, DateTime fechaFinal)
        {
            dbContext = new HermesServiceEntities();
            List<SalesVM> ventas = new List<SalesVM>();
            try
            {
                ventas = (from venta in dbContext.Sales.ToList()
                          join empresa in dbContext.Companies.ToList()
                          on venta.IdCompany equals empresa.IdCompany
                          join usuario in dbContext.Users.ToList()
                          on venta.IdUser equals usuario.IdUser
                          where (venta.SaleDate >= fechaInicio && venta.SaleDate <= fechaFinal)
                          select new SalesVM
                          {
                              IdSale = venta.IdSale,
                              InvoiceNumber = venta.InvoiceNumber,
                              SaleDate = venta.SaleDate,
                              SubTotalAmount = venta.SubTotalAmount,
                              TaxTotalAmount = venta.TaxTotalAmount,
                              TotalAmount = venta.TotalAmount,
                              CompanyNIT = empresa.NIT,
                              CompanyName = empresa.Fullname,
                              ClientName = usuario.Name,
                              ClientEmail = usuario.Email
                          }).ToList();
                return ventas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object GetSalesByClientEmail(string email)
        {
            dbContext = new HermesServiceEntities();
            List<SalesVM> ventas = new List<SalesVM>();
            try
            {
                ventas = (from venta in dbContext.Sales.ToList()
                          join empresa in dbContext.Companies.ToList()
                          on venta.IdCompany equals empresa.IdCompany
                          join usuario in dbContext.Users.ToList()
                          on venta.IdUser equals usuario.IdUser
                          where usuario.Email.Equals(email)
                          select new SalesVM
                          {
                              IdSale = venta.IdSale,
                              InvoiceNumber = venta.InvoiceNumber,
                              SaleDate = venta.SaleDate,
                              SubTotalAmount = venta.SubTotalAmount,
                              TaxTotalAmount = venta.TaxTotalAmount,
                              TotalAmount = venta.TotalAmount,
                              CompanyNIT = empresa.NIT,
                              CompanyName = empresa.Fullname,
                              ClientName = usuario.Name,
                              ClientEmail = usuario.Email
                          }).ToList();
                return ventas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object GetSalesByInvoiceNumber(string invoiceNumber)
        {
            dbContext = new HermesServiceEntities();
            List<SalesVM> ventas = new List<SalesVM>();
            try
            {
                ventas = (from venta in dbContext.Sales.ToList()
                          join empresa in dbContext.Companies.ToList()
                          on venta.IdCompany equals empresa.IdCompany
                          join usuario in dbContext.Users.ToList()
                          on venta.IdUser equals usuario.IdUser
                          where venta.InvoiceNumber.Equals(invoiceNumber)
                          select new SalesVM
                          {
                              IdSale = venta.IdSale,
                              InvoiceNumber = venta.InvoiceNumber,
                              SaleDate = venta.SaleDate,
                              SubTotalAmount = venta.SubTotalAmount,
                              TaxTotalAmount = venta.TaxTotalAmount,
                              TotalAmount = venta.TotalAmount,
                              CompanyNIT = empresa.NIT,
                              CompanyName = empresa.Fullname,
                              ClientName = usuario.Name,
                              ClientEmail = usuario.Email
                          }).ToList();
                return ventas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}