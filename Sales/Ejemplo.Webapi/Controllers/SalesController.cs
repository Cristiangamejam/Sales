using ejemplo.EApplication;
using ejemplo.Entities;
using ejemplo.Services;
using ejemplo.webapi.Services;
using Ejemplo.Webapi.Dtos;
using Ejemplo.Webapi.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        IEApplication<Sale> _sale;
        IEApplication<SaleDetail> _saleDetail;

        private ISalesServices _salesServices;
        public SalesController(IEApplication<Sale> sale, IEApplication<SaleDetail> saleDetail)
        {
            _saleDetail = saleDetail;
        }

        [HttpPost]
        public IActionResult Add(SalesRequest salesRequest)
        {
            //Response response = new Response();
            try
            {
                _salesServices.Add(salesRequest);
                //response.Exito = 1;
            }
            catch (Exception ex)
            {
                //response.Message = ex.Message;
            }

            return Ok();
            //return Ok(response);
        }
    }
}
