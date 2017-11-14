namespace FTConf.Core
{
    /// <summary>
    /// Строка соединения
    /// </summary>
    public interface IConnectionString
    {
        /// <summary>
        /// Имя строки
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Провайдер
        /// </summary>
        string Provider { get; }

        /// <summary>
        /// Значение строки соединения
        /// </summary>
        string Value { get; }
    }
}
