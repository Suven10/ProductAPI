using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Helpers
{
    public static class ProductExtensions
    {
        public static string Environment {get;set;}
        public static string Domain { get; set; }
        public static string DB { get; set; }
        //
        // Summary:
        //     Shorthand for GetSection(Environment)[name].
        //
        // Parameters:
        //   configuration:
        //     The configuration.
        //
        //   name:
        //     The Environment keys.
        public static string GetDomain(this IConfiguration configuration, string name)
        {
           return configuration.GetSection(Environment)[name];
        }

        public static string GetDomaind(string d, string name)
        {
            return "";
        }
    }
}
