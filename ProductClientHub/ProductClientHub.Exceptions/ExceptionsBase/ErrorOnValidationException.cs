namespace ProductClientHub.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : ProductsClientsHubExceptions
{
    private readonly List<string> _errors;

    public ErrorOnValidationException(List<string> errorMessagens) : base(string.Empty)
    {
        _errors = errorMessagens;
    }

    public override List<string> GetErrors() => _errors;
    
}
