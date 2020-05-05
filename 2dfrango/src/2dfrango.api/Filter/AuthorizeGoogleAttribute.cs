using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace _2dfrango.api.Filter
{
    public class AuthorizeGoogleAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var token = context.HttpContext.Request.Headers["authorization"];

            GoogleJsonWebSignature.ValidationSettings settings = new GoogleJsonWebSignature.ValidationSettings();
            settings.Audience = new List<string>() { "419273351615-a2kp1blvs5f3idt3mlr5vbkeqtqgjvr6.apps.googleusercontent.com" };
            GoogleJsonWebSignature.Payload payload = GoogleJsonWebSignature.ValidateAsync(token, settings).Result;

            context.ActionArguments["nome"] = payload.Name;
            context.ActionArguments["email"] = payload.Email;

            base.OnActionExecuting(context);
        }
    }
}
