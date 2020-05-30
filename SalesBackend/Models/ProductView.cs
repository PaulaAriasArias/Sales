using SalesCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesBackend.Models
{
    public class ProductView : Product
    {
        public HttpPostedFileBase ImageFile { get; set; }
    }
}