using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_
{
    public interface IObjectsActions
    {
        
        List<Category> GetCategoriesToList();
        List<Manufacturer> GetManufacturesToList();
        object GetProductsCount();
        List<Provider> GetProvidersToList();
        void RemoveProduct(Product selectedProduct);
        IQueryable<Product> SearchProduct(string searchText);
    }
}