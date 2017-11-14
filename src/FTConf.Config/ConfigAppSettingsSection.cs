using FTConf.Core;
using System;
using System.Configuration;

namespace FTConf.Config
{
    /// <summary>
    /// Секция настроек
    /// </summary>
    public class ConfigAppSettingsSection : IAppSettingsSection
    {
        /// <summary>
        /// конфигурация
        /// </summary>
        private readonly ConfigConfiguration _config;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="config">конфигурация</param>
        public ConfigAppSettingsSection(ConfigConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Конфигурация
        /// </summary>
        public ConfigConfiguration Config
            => _config;

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
        public string this[string key]
        {
            get => GetValue(key);
            set => SetValue(key, value);
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
        string IAppSettingsSection.this[string key]
        {
            get => this[key];
            set => this[key] = value;
        }

        /// <summary>
        /// Получить значение по ключу
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
        public string GetValue(string key)
        {
            var pair = GetPair(key);
            if (pair == null)
                return default(string);
            return pair.Value;
        }

        /// <summary>
        /// Получить значение по ключу
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
        string IAppSettingsSection.GetValue(string key)
            => GetValue(key);

        /// <summary>
        /// Установить значение
        /// </summary>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        public void SetValue(string key, string value)
        {
            var pair = GetPair(key);
            if (pair == null)
            {
                pair = new KeyValueConfigurationElement(key, value);
                Config.Config.AppSettings.Settings.Add(pair);
            }
            else
                pair.Value = value;
        }

        /// <summary>
        /// Установить значение
        /// </summary>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        void IAppSettingsSection.SetValue(string key, string value)
            => SetValue(key, value);

        /// <summary>
        /// Получить пару ключ-значение
        /// </summary>
        /// <param name="key">значение</param>
        /// <returns>пара</returns>
        private KeyValueConfigurationElement GetPair(string key)
        {
            var settings = Config.Config.AppSettings;
            if (settings == null) throw new NullReferenceException(nameof(settings));
            return settings.Settings[key];
        }
    }
}
