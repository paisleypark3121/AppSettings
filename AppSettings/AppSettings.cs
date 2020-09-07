using System;
using System.Configuration;

namespace AppSettings
{
    public class AppSettings : IAppSettings
    {
        public string this[string key] => ConfigurationManager.AppSettings[key];
    }
}
