using ReflectionSample.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample.Services
{
    [CustomAuthorize]
    public class ProductService
    { 
      public void GetProducts()
      {
       
      }

        public int GetMaxPrice() => 500;
       
    }
}
