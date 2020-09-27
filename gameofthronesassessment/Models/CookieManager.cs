using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameofthronesassessment.Models
{
    public class CookieManager
    {
        const string COOKIE_NAME = "cookie_got";

        public static string ReadCookie (HttpContext context, string name)
        {
            return context.Request.Cookies[name];
        }

        public static void WriteCookie(HttpContext context, string name, string value)
        {
            context.Response.Cookies.Append(name, value);
        }

        public static bool CheckCookie(HttpContext context, string name)
        {
            return context.Request.Cookies.ContainsKey(name);
        }
        
        public static string Session(HttpContext context)
        {
            if(CheckCookie(context, COOKIE_NAME))
            {
                return ReadCookie(context, COOKIE_NAME);
            }
            else
            {
                Guid g = Guid.NewGuid();
                string newcookie = Convert.ToBase64String(g.ToByteArray());

                WriteCookie(context, COOKIE_NAME, newcookie);
                return newcookie;
            }
        }
    }
}
