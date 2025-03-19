using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(digiturnopro.StartUp))]
namespace digiturnopro
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                ExpireTimeSpan = TimeSpan.FromMinutes(60),
                LoginPath = new PathString("/Login"),
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,

            });
        }
    }
}