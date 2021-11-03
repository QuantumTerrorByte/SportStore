using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SportStore.Models;

namespace SportStore.Infrastructure
{
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }

        public static Langs GetLang(this ISession session)
        {
            return session.GetString("Lang") switch
            {
                "US" => Langs.US,
                "UA" => Langs.UA,
                "RU" => Langs.RU,
                _ => Langs.RU,
            };
        }

        public static void SetLang(this ISession session, Langs lang)
        {
            session.SetString("Lang",lang.ToString());
        }
    }
}