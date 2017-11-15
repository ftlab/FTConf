using System.Configuration;
using FTConf.Core;
using System;

namespace FTConf.Config
{
    /// <summary>
    /// Секция строк соединений
    /// </summary>
    public class ConfigConnectionStringsSection : IConnectionStringsSection
    {
        private ConfigConfiguration _config;

        public ConfigConnectionStringsSection(ConfigConfiguration config)
        {
            _config = config;
        }

        public ConfigConfiguration Config
            => _config;

        IConnectionString IConnectionStringsSection.this[string name]
        {
            get => GetConnectionString(name);
            set => SetConnectionString(name, (ConfigConnectionString)value);
        }

        public ConfigConnectionString GetConnectionString(string name)
        {
            throw new NotImplementedException();
        }

        IConnectionString IConnectionStringsSection.GetConnectionString(string name)
            => GetConnectionString(name);

        public void SetConnectionString(string name, ConfigConnectionString connectionString)
        {
            throw new NotImplementedException();
        }

        void IConnectionStringsSection.SetConnectionString(string name, IConnectionString connectionString)
            => SetConnectionString(name, (ConfigConnectionString)connectionString);
    }
}
