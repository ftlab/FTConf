namespace FTConf.Core
{
    /// <summary>
    /// Секция key-value настроек
    /// </summary>
    public interface IAppSettingsSection : IConfigurationSection
    {
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string this[string key] { get; set; }

        /// <summary>
        /// Получить значение
        /// </summary>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
        string GetValue(string key);

        /// <summary>
        /// Установить значение
        /// </summary>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        void SetValue(string key, string value);
    }
}
