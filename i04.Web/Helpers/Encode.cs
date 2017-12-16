using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace i04.Web.Helpers
{
    public class Encode
    {
        public static string Base64Encode(string str)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(str);
            return System.Convert.ToBase64String(bytes);
        }

        public static string Base64Decode(string str)
        {
            var bytes = System.Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}