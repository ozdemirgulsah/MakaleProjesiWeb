using Makale_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Makale_Web.Filters
{
    public class AuthAdmin : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            Kullanici kullanici = (Kullanici)filterContext.HttpContext.Session["login"];
            if (kullanici!=null && kullanici.Admin==false)
            {

            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
           
          filterContext.Result=new RedirectResult("/Home/Index");
        }
    }
}