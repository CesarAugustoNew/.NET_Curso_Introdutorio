using FluentValidation;
using ResponseShortsClientJson = ProductClientHub.Comunication.Requests.ResponseShortsClientJson;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<ResponseShortsClientJson>
{
    public RegisterClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio");
        RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não é valiodo.");
     
    }
}

    


