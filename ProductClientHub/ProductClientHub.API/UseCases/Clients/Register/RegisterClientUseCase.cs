using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;
using System.ComponentModel.DataAnnotations;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
    public ResponseClientJson Execute(ResquestClientJson resquest)
    {

        var validator= new RegisterClientValidator();

        var result = validator.Validate(resquest);  

        if (result.IsValid == false)
        {
            throw new ArgumentException("ERRO NOS DADOS RECEBIDOS");
        }

        return new ResponseClientJson();
    }

}
