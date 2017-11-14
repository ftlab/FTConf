using System;
using System.ComponentModel;

namespace FTConf.Core
{
    /// <summary>
    /// Методы расширяющие IAppSettingsSection
    /// </summary>
    public static class AppSettingsSectionExtension
    {
        /// <summary>
        /// Попытатся получить значение
        /// </summary>
        /// <typeparam name="T">Тип значения</typeparam>
        /// <param name="section">секция</param>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        /// <returns>результат попытки</returns>
        public static bool TryGetValue<T>(this IAppSettingsSection section
            , string key
            , out T value)
        {
            try
            {
                value = GetValue<T>(section, key);
                return true;
            }
            catch
            {
                value = default(T);
                return false;
            }
        }

        /// <summary>
        /// Получить значение
        /// </summary>
        /// <typeparam name="T">Тип значения</typeparam>
        /// <param name="section">секция</param>
        /// <param name="key">ключ</param>
        /// <returns>значение</returns>
        public static T GetValue<T>(this IAppSettingsSection section
            , string key)
        {
            if (section == null) throw new ArgumentNullException(nameof(section));
            var svalue = section.GetValue(key);
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter == null) throw new NullReferenceException(nameof(converter));
            return (T)converter.ConvertFromString(svalue);
        }

        /// <summary>
        /// Установить значение
        /// </summary>
        /// <typeparam name="T">Тип значения</typeparam>
        /// <param name="section">секция</param>
        /// <param name="key">ключ</param>
        /// <param name="value">значение</param>
        public static void SetValue<T>(this IAppSettingsSection section
            , string key, T value)
        {
            if (section == null) throw new ArgumentNullException(nameof(section));
            var svalue = Convert.ToString(value);
            section.SetValue(key, value);
        }
    }
}
