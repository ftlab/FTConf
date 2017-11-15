using FTConf.Core;
using System;
using System.Configuration;

namespace FTConf.Config
{
    /// <summary>
    /// Настройки строки соединения
    /// </summary>
    public class ConfigConnectionString : IConnectionString
    {
        private readonly ConnectionStringSettings _settings;

        private readonly ConfigConfiguration _config;

        public ConfigConnectionString(ConfigConfiguration config
            , ConnectionStringSettings settings)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        public ConfigConfiguration Config => _config;

        public ConnectionStringSettings Settings => _settings;

        public string Name => Settings.Name;

        public string Provider => Settings.ProviderName;

        public string Value => Settings.ConnectionString;
    }
}
