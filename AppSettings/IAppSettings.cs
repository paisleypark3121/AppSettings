using System;

namespace AppSettings
{
    public interface IAppSettings
    {
        string this[string key] { get; }
    }
}
