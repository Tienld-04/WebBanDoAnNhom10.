﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace BTL.Models.Authentication
{
    public class Authentication:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("Username")==null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"Controller", "Access"},
                    {"Action", "Login"},
                });
            }    
        }
    }
}
