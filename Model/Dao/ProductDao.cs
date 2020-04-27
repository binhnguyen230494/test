﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductDao
    {
        OnlineShopDbContext db = null;
        public ProductDao()
        {
            db = new OnlineShopDbContext();
            

        }
        public List<Product> ListNewProduct( int top)
        {
            return db.Products.OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }
        /// <summary>
        /// list feature product
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public List<Product> ListFeatureProduct(int top)
        {
            return db.Products.Where(x => x.Tophot != null && x.Tophot>DateTime.Now).OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }
        /// <summary>
        /// list related product
        /// </summary>
        /// <param name="producId"></param>
        /// <returns></returns>
        public List<Product> ListRelatedProduct(long producId)
        {
            var product = db.Products.Find(producId);
            return db.Products.Where(x => x.ID != producId && x.CategoryID == product.CategoryID).ToList();
        }
        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }
        /// <summary>
        /// Get list product by category
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public List<Product> ListByCategoryID(long categoryID, ref int totalRecord, int page = 1, int pageSize = 1)
        {
            totalRecord = db.Products.Where(x => x.CategoryID == categoryID).Count();
            var model = db.Products.Where(x => x.CategoryID == categoryID).OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return model;
            
        }
    }
}
