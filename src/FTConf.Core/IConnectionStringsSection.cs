namespace FTConf.Core
{
    /// <summary>
    /// Секция строк соединений
    /// </summary>
    public interface IConnectionStringsSection : IConfigurationSection
    {
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="name">имя строки</param>
        /// <returns>строка соединения</returns>
        IConnectionString this[string name] { get; set; }

        /// <summary>
        /// Получить строку соединения
        /// </summary>
        /// <param name="name">имя строки</param>
        /// <returns>строка соединения</returns>
        IConnectionString GetConnectionString(string name);

        /// <summary>
        /// Установить строку соединения
        /// </summary>
        /// <param name="name">имя строки</param>
        /// <param name="connectionString">строка соединения</param>
        void SetConnectionString(string name, IConnectionString connectionString);
    }
}
