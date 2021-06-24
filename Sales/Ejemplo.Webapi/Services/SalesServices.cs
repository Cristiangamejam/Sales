using ejemplo.Abstractions;
using ejemplo.Entities;
using Ejemplo.Webapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.Webapi.Request;
using ejemplo.EApplication;

namespace ejemplo.webapi.Services
{
    public interface ISalesServices
    {
        void Add(SalesRequest salesRequest);
    }

    public class SalesServices : ISalesServices
    {
        IEApplication<Sale> _sale;
        IEApplication<SaleDetail> _saleDetails;
        public SalesServices(IEApplication<Sale> sale, IEApplication<SaleDetail> saleDetails)
        {
            _sale = sale;
            _saleDetails = saleDetails;
        }

        public void Add(SalesRequest salesRequest)
        {
            
            //using (RealSaleContext db = new RealSaleContext())
            //{
            //using (var transaction = db.Database.BeginTransaction())
            //{
                    try
                    {
                       
                        var s = new Entities.Sale();
                        s.Total = salesRequest.Total;
                        s.Fecha = DateTime.Now;
                        s.Total = salesRequest.Total;
                        _sale.Save(s);

                        foreach (var item in salesRequest.oSaleDetailRequests)
                        {
                            var oSaleDetail = new Entities.SaleDetail();
                            oSaleDetail.Total = item.Total;
                            oSaleDetail.Price = item.Price;
                            oSaleDetail.IdSale = s.Id;
                            oSaleDetail.IdProduct = item.IdProduct;
                             _saleDetails.Save(oSaleDetail);
                        }

                        //transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        //transaction.Rollback();
                        throw new Exception(ex.Message + " En SalesServices");
                    }
                //}
            //}
        }
    }
}
