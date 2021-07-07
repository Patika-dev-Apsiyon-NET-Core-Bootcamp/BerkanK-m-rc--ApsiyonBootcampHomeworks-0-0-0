using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookInSessionCookie
{
    public static class Extension //static !!
    {
        public static void Set<T>(this ISession session, string key, T value)//static , this!!
        {
            session.SetString(key, JsonSerializer.Serialize(value));//veriyi json serialize ile set ediyoruz
        }
        public static T Get<T>(this ISession session, string key)//static , this!!
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);//deserialize ile tekrar istediğimiz değeri alıyoruz..
        }
    }
}
