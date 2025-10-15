using ProductClientHub.API.Entities;
using ProductClientHub.API.Infraestructure;
using ProductClientHub.Exceptions.ExceptionsBase;
using ResponseShortsClientJson = ProductClientHub.Comunication.Requests.ResponseShortsClientJson;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
    public ResponseShortsClientJson Execute(ResponseShortsClientJson resquest)
    {
        Validate(resquest);

        var dbContext = new ProductClientHubDbContext();

        var entity = new Client
        {
            Name = resquest.Name,
            Email = resquest.Email,
            Id = Guid.NewGuid()
        };

        dbContext.Clients.Add(entity);

        dbContext.SaveChanges();

        return new ResponseShortsClientJson()
        {
            Id = entity.Id,
            Name = entity.Name,
        };
    }

    private void Validate(ResponseShortsClientJson resquest)
    {
        var validator = new RegisterClientValidator();

        var result = validator.Validate(resquest);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errors);
        }
    }
}
