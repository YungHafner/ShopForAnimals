using ООО__Товары_для_животных_.Models;

namespace ООО__Товары_для_животных_
{
    public interface IEditProductEntry
    {
        void SaveEditProduct(Product original, Product editProduct);
    }
}