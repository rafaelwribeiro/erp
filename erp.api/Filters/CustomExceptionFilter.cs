using erp.domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace erp.api.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is BusinessRuleException)
        {
            context.Result = new BadRequestObjectResult(new { Error = context.Exception?.Message ?? "Invalid operation", context.Exception?.StackTrace });
            context.ExceptionHandled = true;
        }
        else if (context.Exception is ArgumentNullException || context.Exception is KeyNotFoundException)
        {
            context.Result = new NotFoundObjectResult(new { Error = context.Exception?.Message ?? "Recurso não encontrado", context.Exception?.StackTrace });
            context.ExceptionHandled = true;
        }
        else if (context.Exception is HttpRequestException || context.Exception is InvalidOperationException)
        {
            context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            context.ExceptionHandled = true;
        }
    }
}
