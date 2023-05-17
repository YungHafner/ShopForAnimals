using ООО__Товары_для_животных_.Database;
using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_
{
    public class EditProductEntry : IEditProductEntry
    {
        public void SaveEditProduct(Product original, Product editProduct)
        {
            DB.Instance.Entry(original).CurrentValues.SetValues(editProduct);
            DB.Instance.SaveChanges();
        }
    }
}