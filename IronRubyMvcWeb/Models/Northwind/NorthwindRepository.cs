﻿using System;
using System.Linq;
using System.Data.Linq;
using IronRubyMvcWeb.Models.Northwind;

namespace IronRubyMvcWeb.Models
{
    public class NorthwindRepository
    {
        NorthwindDataContext dataContext = null;

        public NorthwindRepository() : this(new NorthwindDataContext())
        { 
        }

        public NorthwindRepository(NorthwindDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public virtual IQueryable<Category> Categories
        { 
            get
            {
                return this.dataContext.Categories;
            }
        }

        public virtual IQueryable<Product> Products
        {
            get
            {
                return this.dataContext.Products;
            }
        }

        public virtual IQueryable<Supplier> Suppliers
        {
            get 
            {
                return this.dataContext.Suppliers;    
            }
        }

        public virtual void SubmitChanges()
        {
            this.dataContext.SubmitChanges();
        }

        public virtual void InsertProductOnSubmit(Product p)
        {
            this.dataContext.Products.InsertOnSubmit(p);
        }
    }
}