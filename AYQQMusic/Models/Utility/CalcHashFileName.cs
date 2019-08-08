﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AYQQMusic
{
   
    //public class CalcHash
    //{
    //    private static byte[] _emptyBuffer = new byte[0];

    //    public static string GetMemoryHash(Stream stream)
    //    {
    //        return System.Text.Encoding.Default.GetString(CalculateMD5(stream));
    //    }
    //    public static byte[] CalculateMD5(Stream stream)
    //    {
    //        return CalculateMD5(stream, 64 * 1024);
    //    }

    //    public static byte[] CalculateMD5(Stream stream, int bufferSize)
    //    {
    //        MD5 md5Hasher = MD5.Create();

    //        byte[] buffer = new byte[bufferSize];
    //        int readBytes;

    //        while ((readBytes = stream.Read(buffer, 0, bufferSize)) > 0)
    //        {
    //            md5Hasher.TransformBlock(buffer, 0, readBytes, buffer, 0);
    //        }

    //        md5Hasher.TransformFinalBlock(_emptyBuffer, 0, 0);

    //        return md5Hasher.Hash;
    //    }


    //}
}
//public class CalcHashFileName
//{
//    /// <summary>
//    /// 计算文件的 MD5 值
//    /// </summary>
//    /// <param name="fileName">要计算 MD5 值的文件名和路径</param>
//    /// <returns>MD5 值16进制字符串</returns>
//    public string MD5File(string fileName)
//    {
//        return HashFile(fileName, "md5");
//    }

//    /// <summary>
//    /// 计算文件的 sha1 值
//    /// </summary>
//    /// <param name="fileName">要计算 sha1 值的文件名和路径</param>
//    /// <returns>sha1 值16进制字符串</returns>
//    public string SHA1File(string fileName)
//    {
//        return HashFile(fileName, "sha1");
//    }


//    /// <summary>
//    /// 计算文件的哈希值
//    /// </summary>
//    /// <param name="fileName">要计算哈希值的文件名和路径</param>
//    /// <param name="algName">算法:sha1,md5</param>
//    /// <returns>哈希值16进制字符串</returns>
//    private string HashFile(string fileName, string algName)
//    {
//        if (!System.IO.File.Exists(fileName))
//            return string.Empty;

//        System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
//        byte[] hashBytes = HashData(fs, algName);
//        fs.Close();
//        return ByteArrayToHexString(hashBytes);
//    }

//    /// <summary>
//    /// 计算哈希值
//    /// </summary>
//    /// <param name="stream">要计算哈希值的 Stream</param>
//    /// <param name="algName">算法:sha1,md5</param>
//    /// <returns>哈希值字节数组</returns>
//    private byte[] HashData(System.IO.Stream stream, string algName)
//    {
//        System.Security.Cryptography.HashAlgorithm algorithm;
//        if (algName == null)
//        {
//            throw new ArgumentNullException("algName 不能为 null");
//        }
//        if (string.Compare(algName, "sha1", true) == 0)
//        {
//            algorithm = System.Security.Cryptography.SHA1.Create();
//        }
//        else
//        {
//            if (string.Compare(algName, "md5", true) != 0)
//            {
//                throw new Exception("algName 只能使用 sha1 或 md5");
//            }
//            algorithm = System.Security.Cryptography.MD5.Create();
//        }
//        return algorithm.ComputeHash(stream);
//    }

//    /// <summary>
//    /// 字节数组转换为16进制表示的字符串
//    /// </summary>
//    private string ByteArrayToHexString(byte[] buf)
//    {
//        return BitConverter.ToString(buf).Replace("-", "");
//    }
//}

//}
