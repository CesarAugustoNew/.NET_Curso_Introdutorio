using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : ProductClientHubException
{
    private readonly List<string> _errors;

    public ErrorOnValidationException(List<string> errorMessagens) : base(string.Empty)
    {
        _errors = errorMessagens;
    }

    public override List<string> GetErrors() => _errors;

    public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.BadRequest;

}
