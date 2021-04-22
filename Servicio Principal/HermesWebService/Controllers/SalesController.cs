using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataConnection;
using HermesWebService.Models;
using Entities;
using System.Text.RegularExpressions;

namespace HermesWebService.Controllers
{
    public class SalesController : ApiController
    {
        // Instancia el contexto de la base de datos
        private SalesService service = new SalesService();

        [HttpGet]
        [Route("api/sales/getallsales")]
        public IHttpActionResult GetAllSales()
        {
            object data = service.GetAllSales();
            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest("Se ha presentado un error al consultar la información. Por favor contacte al administrador");
            }
        }

        [HttpGet]
        [Route("api/sales/getsalesbycompany")]
        public IHttpActionResult GetSalesByCompany([FromBody] RequestByCompany request)
        {
            if(Regex.IsMatch(request.CompanyNIT, "\\d") == true)
            {
                object data = service.GetSalesByCompany(request.CompanyNIT);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return BadRequest("Se ha presentado un error al consultar la información. Por favor contacte al administrador");
                }
            }
            else
            {
                return BadRequest("El Nit de la compañia no tiene un formato valido");
            }           
        }


        [HttpGet]
        [Route("api/sales/getsalesbydate")]
        public IHttpActionResult GetSalesByDate([FromBody] RequestByDates request)
        {
            bool fechaInicio = DateTime.TryParseExact(request.FechaInicio, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime paramFI);
            bool fechaFinal = DateTime.TryParseExact(request.FechaFinal, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime paramFF);
            if (fechaInicio == true || fechaFinal == true)
            {
                if(paramFF < paramFI)
                {
                    return BadRequest("La fecha final debe ser mayor a la fecha de inicio!");
                }
                else
                {
                    object data = service.GetSalesByDates(paramFI, paramFF);
                    if (data != null)
                    {
                        return Ok(data);
                    }
                    else
                    {
                        return BadRequest("Se ha presentado un error al consultar la información. Por favor contacte al administrador");
                    }
                }
                
            }
            else
            {
                return BadRequest("Verifique el formato de las fechas (dd/MM/yyyy)");
            }
        }


        [HttpGet]
        [Route("api/sales/getsalesbyclientemail")]
        public IHttpActionResult GetSalesByClientEmail([FromBody] RequestByClientEmail request)
        {
            if (Regex.IsMatch(request.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == true)
            {
                object data = service.GetSalesByClientEmail(request.Email);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return BadRequest("Se ha presentado un error al consultar la información. Por favor contacte al administrador");
                }
            }
            else
            {
                return BadRequest("El formato del email no es valido!");
            }
        }


        [HttpGet]
        [Route("api/sales/getsalesbyinvoicenumber")]
        public IHttpActionResult GetSalesByInvoiceNumber([FromBody] RequestByInvoiceNumber request)
        {
            object data = service.GetSalesByInvoiceNumber(request.InvoiceNumber);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest("Se ha presentado un error al consultar la información. Por favor contacte al administrador");
            }
        }
    }
}
