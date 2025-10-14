using ProductClientHub.API.Entities;
using ProductClientHub.API.Infraestructure;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
    public ResponseClientJson Execute(ResquestClientJson resquest)
    {
        Validate(resquest);

        var dbContext = new ProductsClientsHubDbContext();

        var entity = new Client
        {
            Name = resquest.Name,
            Email = resquest.Email,
            Id = Guid.NewGuid()
        };

        dbContext.Clients.Add(entity);

        dbContext.SaveChanges();

        return new ResponseClientJson()
        {
            Id = entity.Id,
            Name = entity.Name,
        };
    }

    private void Validate(ResquestClientJson resquest)
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
