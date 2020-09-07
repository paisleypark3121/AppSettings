using System;
using System.Configuration;

namespace AppSettings
{
    public class EnvironmentAppSettings : IAppSettings
    {
        public string this[string key] => Environment.GetEnvironmentVariable(key);
    }
}
