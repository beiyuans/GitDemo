using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace login.Filters
{
    public class loginFilterAttribute:AuthorizeAttribute,IAuthorizationFilter
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            if (filterContext.HttpContext.Session["uid"] == null)
            {
                filterContext.Result = new RedirectResult("~/user/login");
            }
        }
    }
}