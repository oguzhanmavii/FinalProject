using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş kodları ...
            // Bir iş Sınıfı başka sınıfları new yapmaz unutma önemli !
            //yetkisi var mı ?

            return _productDal.GetAll();
        }
    }
}
