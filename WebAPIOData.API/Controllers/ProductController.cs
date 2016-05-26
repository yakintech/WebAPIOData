using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData.Query;
using WebAPIOData.API.Models.ORM;

namespace WebAPIOData.API.Controllers
{
    public class ProductController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();
        public ProductController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        //[Queryable(AllowedQueryOptions =AllowedQueryOptions.Top)]
        [Queryable]
        public IQueryable<Product> GetAllProducts()
        {
            IQueryable<Product> plist = db.Products.AsQueryable();
            return plist;

            //return db.Products;
        }
    }
}
