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
        private Configuration _config;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="config">конфиг</param>
        public ConfigConfiguration(Configuration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }
    }
}
