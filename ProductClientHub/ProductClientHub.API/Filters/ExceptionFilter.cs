using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Comunication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if(context.Exception is ProductClientHubException productsClientsHubException)
        {
            context.HttpContext.Response.StatusCode = (int)productsClientsHubException.GetHttpStatusCode()
;            
            context.Result = new ObjectResult(new ResponseErrorMessagesJson("ERRO DESCONHECIDO"));
        }
        else
        {
            ThrowUnknowError(context);
        }
    }

    private void ThrowUnknowError (ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new ResponseErrorMessagesJson("ERRO DESCONHECIDO"));
    }
}
