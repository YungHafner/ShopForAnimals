using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_
{
    public class ObjectsActionsClass : IObjectsActions
    {
        public void RemoveProduct(Product selectedProduct)
        {
            DB.Instance.Products.Remove(selectedProduct);
            DB.Instance.SaveChanges();
        }

        public IQueryable<Product> SearchProduct(string searchText)
        {
            return DB.Instance.Products
                                  .Include(p => p.ProductManufacturer)
                                  .Include(p => p.ProductProvider)
                                  .Include(p => p.OrderProducts)
                                  .Include(p => p.ProductCategory)
                                  .Where(s => s.ProductArticleNumber.Contains(searchText) ||
                                              s.ProductCategory.Title.Contains(searchText) ||
                                              s.ProductDescription.Contains(searchText) ||
                                              s.ProductManufacturer.Title.Contains(searchText) ||
                                              s.ProductTitle.Contains(searchText) ||
                                              s.ProductProvider.Title.Contains(searchText));
        }

        

        List<Category> IObjectsActions.GetCategoriesToList()
        {
            return DB.Instance.Categories.ToList(); 
        }

        List<Manufacturer> IObjectsActions.GetManufacturesToList()
        {
            return DB.Instance.Manufacturers.ToList();
        }

        object IObjectsActions.GetProductsCount()
        {
            return DB.Instance.Products.Count();
        }

        List<Provider> IObjectsActions.GetProvidersToList()
        {
            return DB.Instance.Providers.ToList(); 
        }
    }
}