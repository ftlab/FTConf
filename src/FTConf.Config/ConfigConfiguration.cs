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
        /// секция настроек
        /// </summary>
        private readonly Lazy<ConfigAppSettingsSection> _appSettings;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="config">конфиг</param>
        public ConfigConfiguration(Configuration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));

            _connectionStrings = new Lazy<ConfigConnectionStringsSection>(()
                => new ConfigConnectionStringsSection(this));

            _appSettings = new Lazy<ConfigAppSettingsSection>(()
                => new ConfigAppSettingsSection(this));
        }

        /// <summary>
        /// Конфигурация
        /// </summary>
        internal Configuration Config
            => _config;

        /// <summary>
        /// Секция строк соединений
        /// </summary>
        public ConfigConnectionStringsSection ConnectionStrings
            => _connectionStrings.Value;

        /// <summary>
        /// Секция настроек
        /// </summary>
        public ConfigAppSettingsSection AppSettings
            => _appSettings.Value;

        /// <summary>
        /// Секция строк соединений
        /// </summary>
        IConnectionStringsSection IConfiguration.ConnectionStrings => ConnectionStrings;

        /// <summary>
        /// Секция настроек
        /// </summary>
        IAppSettingsSection IConfiguration.AppSettings => AppSettings;
    }
}
