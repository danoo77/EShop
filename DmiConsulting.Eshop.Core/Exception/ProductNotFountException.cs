namespace DmiConsulting.Eshop.Core.Exception
{
    public class ProductNotFountException : System.Exception
    {

        public int ProductId { get; }

        public ProductNotFountException(int productId)
            :base($"Product {productId} has not been found")
        {
            ProductId = productId;
        }

        public static ProductNotFountException CreateNew(int productId)
        {
            return new ProductNotFountException(productId);
        }
    }
}
