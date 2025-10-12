namespace ProductClientHub.Exceptions.ExceptionsBase

{
    public abstract class ProductsClientsHubExceptions : SystemException
    {
        public ProductsClientsHubExceptions(string errorMessage) : base(errorMessage)
        {
        }

        public abstract List<string> GetErrors();
    }
}
