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

            if (string.IsNullOrEmpty(value)) return default;

            return (TValue) TypeDescriptor.GetConverter(typeof(TValue)).ConvertFromInvariantString(value);
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
                value = default;
                return false;
            }
        }
    }
}
