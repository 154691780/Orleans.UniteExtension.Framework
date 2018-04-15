using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonlyUsed.Toolkit
{
    /// <summary>
    /// 枚举类型扩展帮助
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 获取枚举类型说明属性内容
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="m_EnumValue"></param>
        /// <returns></returns>
        public static string GetEnumDescription(this Enum m_EnumValue)
        {
            if (m_EnumValue == null || !m_EnumValue.GetType().IsEnum)
            {
                throw new ArgumentException("当前对象为null,或非Eunm类型.", "GetEnumDescriptionException");
            }

            string m_Return = m_EnumValue.ToString();

            var m_TypeObj = m_EnumValue.GetType();

            var m_MemberInfo = m_TypeObj.GetMember(m_Return);
            if (m_MemberInfo != null && m_MemberInfo.Length > 0)
            {
                var m_Array = m_MemberInfo.First().GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

                if (m_Array != null && m_Array.Length > 0)
                {
                    m_Return = ((System.ComponentModel.DescriptionAttribute)m_Array.First()).Description;
                }
            }

            return m_Return;
        }

        /// <summary>
        /// 获取枚举类型说明属性内容
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="m_EnumValue"></param>
        /// <returns></returns>
        //public static string GetEnumDescription<T>(this T m_EnumValue) where T : IComparable, IFormattable, IConvertible
        //{
        //    if (m_EnumValue == null || !m_EnumValue.GetType().IsEnum)
        //    {
        //        throw new ArgumentException("当前对象为null,或非Eunm类型.", "GetEnumDescriptionException");
        //    }

        //    string m_Return = m_EnumValue.ToString();

        //    var m_TypeObj = m_EnumValue.GetType();

        //    var m_MemberInfo = m_TypeObj.GetMember(m_Return);
        //    if (m_MemberInfo != null && m_MemberInfo.Length > 0)
        //    {
        //        var m_Array = m_MemberInfo.First().GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

        //        if (m_Array != null && m_Array.Length > 0)
        //        {
        //            m_Return = ((System.ComponentModel.DescriptionAttribute)m_Array.First()).Description;
        //        }
        //    }

        //    return m_Return;
        //}
    }
}
