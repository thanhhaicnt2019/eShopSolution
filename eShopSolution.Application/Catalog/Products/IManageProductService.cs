using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> create(ProductCreateRequest request);

        Task<int> update(ProductEditRequest request);

        Task<int> delete(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PageViewModel<ProductViewModel>> GetAllPaging(string keywork, int pageIndex, int pageSize);
    }
}
