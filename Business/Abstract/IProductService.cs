using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategorId(int id);
        List<Product> GetAllUnitPrice( decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
    }
}
