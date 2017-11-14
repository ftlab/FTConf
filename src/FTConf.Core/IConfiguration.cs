namespace FTConf.Core
{
    /// <summary>
    /// Конфигурации
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Секция строк соединений
        /// </summary>
        IConnectionStringsSection ConnectionStrings { get; }

        /// <summary>
        /// Секция настроек
        /// </summary>
        IAppSettingsSection AppSettings { get; }
    }
}
