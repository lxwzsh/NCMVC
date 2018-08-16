﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NC.Common
{
    /// <summary>
    /// byte转换操作类，主要用于Session存储
    /// </summary>
    public class ByteConvertHelper
    {
        /// <summary>
        /// 将对象转换为byte数组
        /// </summary>
        /// <param name="obj">被转换对象</param>
        /// <returns>转换后byte数组</returns>
        public static byte[] Object2Bytes(object obj)
        {
            byte[] serializedResult = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(obj));
            return serializedResult;
        }

        /// <summary>
        /// 将byte数组转换成对象
        /// </summary>
        /// <param name="buff">被转换byte数组</param>
        /// <returns>转换完成后的对象</returns>
        public static object Bytes2Object(byte[] buff)
        {
            return JsonConvert.DeserializeObject<object>(Encoding.UTF8.GetString(buff));
        }

        /// <summary>
        /// 将byte数组转换成对象
        /// </summary>
        /// <param name="buff">被转换byte数组</param>
        /// <returns>转换完成后的对象</returns>
        public static T Bytes2Object<T>(byte[] buff)
        {
            return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(buff));
        }
    }
}
