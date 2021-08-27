using CoreApp.Application.ViewModels.Products;
using CoreApp.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
        ProductViewModel GetById(int id);
        ProductViewModel Add(ProductViewModel product);
        void Update(ProductViewModel product);
        void Delete(int id);
        void Save();
    }
}
