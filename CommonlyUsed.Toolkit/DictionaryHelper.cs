using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlyUsed.Toolkit
{
    /// <summary>
    /// 数据字典(IDictionary)扩展帮助
    /// </summary>
    public static class DictionaryHelper
    {
        /// <summary>
        /// 尝试将键和值添加到字典中
        /// <para>不存在: 添加,返回true;</para>
        /// <para>存在: 不添加,返回false;</para>
        /// <para>不抛导常</para>
        /// </summary>
        public static bool ExtendedTryAdd<TKey, TValue>(this IDictionary<TKey, TValue> m_Dicy, TKey m_Key, TValue m_Value)
        {
            if (m_Dicy.ContainsKey(m_Key) == false)
            {
                m_Dicy.Add(m_Key, m_Value);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 尝试将键和值添加到字典中：如果不存在，才添加；存在，不添加也不抛导常
        /// </summary>
        public static IDictionary<TKey, TValue> ExtendedTryAdd2<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.ContainsKey(key) == false) dict.Add(key, value);
            return dict;
        }

        /// <summary>
        /// 将键和值添加或替换到字典中：如果不存在，则添加；存在，则替换
        /// </summary>
        public static IDictionary<TKey, TValue> AddOrReplace<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            dict[key] = value;
            return dict;
        }

        /// <summary>
        /// 获取与指定的键相关联的值，如果没有则返回输入的默认值
        /// </summary>
        public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default(TValue))
        {
            return dict.ContainsKey(key) ? dict[key] : defaultValue;
        }

        /// <summary>
        /// 向字典中批量添加键值对
        /// </summary>
        /// <param name="replaceExisted">如果已存在，是否替换</param>
        public static IDictionary<TKey, TValue> AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dict, IEnumerable<KeyValuePair<TKey, TValue>> values, bool replaceExisted)
        {
            foreach (var item in values)
            {
                if (dict.ContainsKey(item.Key) == false || replaceExisted)
                    dict[item.Key] = item.Value;
            }
            return dict;
        }
    }
}
