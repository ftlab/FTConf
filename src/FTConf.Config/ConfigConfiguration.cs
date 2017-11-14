using FTConf.Core;
using System;
using System.Configuration;

namespace FTConf.Config
{
    /// <summary>
    /// Конфигурация config
    /// </summary>
    public class ConfigConfiguration : IConfiguration
    {
        /// <summary>
        /// конфиг
        /// </summary>
        private readonly Configuration _config;

        /// <summary>
        /// секция строк соединения
        /// </summary>
        private readonly Lazy<ConfigConnectionStringsSection> _connectionStrings;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="config">конфиг</param>
        public ConfigConfiguration(Configuration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));

            _connectionStrings = new Lazy<ConfigConnectionStringsSection>(()
                => new ConfigConnectionStringsSection(Config));
        }

        /// <summary>
        /// Конфигурация
        /// </summary>
        public Configuration Config
            => _config;

        /// <summary>
        /// Секция строк соединений
        /// </summary>
        public ConfigConnectionStringsSection ConnectionStrings
            => _connectionStrings.Value;

        IConnectionStringsSection IConfiguration.ConnectionStrings => ConnectionStrings;

        IAppSettingsSection IConfiguration.AppSettings => throw new NotImplementedException();
    }
}
