using CoreApp.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}
