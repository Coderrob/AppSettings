using System;
using System.Configuration;

namespace Utilities
{
    public static class AppSettings
    {
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static TValue Get<TValue>(string key)
        {
            var value = Get(key);

            if (string.IsNullOrEmpty(value))
            {
                return default(TValue);
            }

            return (TValue) Convert.ChangeType(value, typeof (TValue));
        }

        public static bool TryGet<TValue>(string key, out TValue value)
        {
            try
            {
                value = Get<TValue>(key);
                return true;
            }
            catch (Exception)
            {
                value = default(TValue);
                return false;
            }
        }
    }
}