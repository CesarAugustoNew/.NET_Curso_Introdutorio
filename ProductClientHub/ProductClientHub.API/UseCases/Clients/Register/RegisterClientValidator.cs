using FluentValidation;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<ResquestClientJson>
{
    public RegisterClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio");
        RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não é valiodo.");
     
    }
}

    


