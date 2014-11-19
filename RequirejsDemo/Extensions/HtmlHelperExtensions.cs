using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequirejsDemo.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString CacheBust(this HtmlHelper helper)
        {
            return new MvcHtmlString(CacheValue);
        }

        //increment product version of the assembly in 
        //assemblyinfo.cs
        //increment this during build process
        //I always set the product version with tfs build number, so we can trace back which build, which changeset.
        private static string CacheValue
        {
            get
            {
#if DEBUG
                return string.Empty;
#else
                return System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
#endif
            }
        }
    }
}