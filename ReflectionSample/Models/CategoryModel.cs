using ReflectionSample.CustomeAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample.Models
{
    [CustomAuthorize]
    class CategoryModel
    {
        public int CatrgoryId { get; set; }
        public string Title  { get; set; }
    }
}
