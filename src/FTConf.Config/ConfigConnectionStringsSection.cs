using System.Configuration;
using FTConf.Core;

namespace FTConf.Config
{
    /// <summary>
    /// Секция строк соединений
    /// </summary>
    public class ConfigConnectionStringsSection : IConnectionStringsSection
    {
        private Configuration _config;

        public ConfigConnectionStringsSection(Configuration config)
        {
            _config = config;
        }

        IConnectionString IConnectionStringsSection.this[string name] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        IConnectionString IConnectionStringsSection.GetConnectionString(string name)
        {
            throw new System.NotImplementedException();
        }

        void IConnectionStringsSection.SetConnectionString(string name, IConnectionString connectionString)
        {
            throw new System.NotImplementedException();
        }
    }
}
