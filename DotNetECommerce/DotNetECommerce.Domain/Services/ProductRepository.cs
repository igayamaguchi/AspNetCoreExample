﻿using DotNetECommerce.Domain.Models;
using DotNetECommerce.Domain.Products;
using DotNetECommerce.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetECommerce.Domain.Services
{
    public class ProductRepository : IProductRepository
    {
        public Product FindBy(int id)
        {
            return null;
        }

        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
