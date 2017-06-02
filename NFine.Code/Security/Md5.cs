/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using System.Text;
using System.Security.Cryptography;
using System;
using System.Web.Security;

namespace NFine.Code
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class Md5
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密字符</param>
        /// <param name="code">加密位数16/32</param>
        /// <returns></returns>
        public static string md5(string str, int code)
        {
            
            MD5CryptoServiceProvider MD5CSP = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(str.ToCharArray());
            bytes = MD5CSP.ComputeHash(bytes);
            string strEncrypt = string.Empty;
            string[] Res = BitConverter.ToString(bytes).Split('-');
            string rtn = string.Concat(Res);
            if (code == 16)
            {
                strEncrypt = rtn.Substring(8, 16);
            }
            if (code == 32)
            {
                strEncrypt = rtn;
            }
            return strEncrypt;
        }

        
    }
}
