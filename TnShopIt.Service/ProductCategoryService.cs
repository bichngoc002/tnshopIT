using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TnShopIt.Data.Infrastructure;
using TnShopIt.Data.Repositories;
using TnShopIt.Model.Models;

namespace TnShopIt.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);

        void Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow);

        ProductCategory GetById(int id);

        IEnumerable<ProductCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        IProductCategoryRepository _productCategory;
        UnitOfWork _uniOfWork;

        public ProductCategoryService(IProductCategoryRepository proCategoryRepository, UnitOfWork uniOfWork)
        {
            _productCategory = proCategoryRepository;
            _uniOfWork = uniOfWork;
        }

        public void Add(ProductCategory productCategory)
        {
            _productCategory.Add(productCategory);
        }

        public void Delete(int id)
        {
            _productCategory.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _productCategory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productCategory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public ProductCategory GetById(int id)
        {
            return _productCategory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _uniOfWork.Commit();
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategory.Update(productCategory);
        }
    }
}
