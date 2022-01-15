using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace warehouseIT.ClassReference
{
    public class EncodeMD5
    {
        public string EncodeString(string str)
        {
            string resul = "";
            //encode Base
            string s = "iloveit";
            byte[] b = UnicodeEncoding.Unicode.GetBytes(str + s);
            string str1 = Convert.ToBase64String(b);
            byte[] mang = UTF8Encoding.Unicode.GetBytes(str1);
            MD5CryptoServiceProvider my = new MD5CryptoServiceProvider();
            mang = my.ComputeHash(mang);
            foreach (byte a in mang)
            {
                resul += a.ToString();
            }
            return resul;

        }
        public bool CheckData(string str)
        {
            bool kt = false;
            string s = "/^ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+$/";
            int vt;
            string kytu;
            for (int i = 0; i < str.Length; i++)
            {
                kytu = str[i].ToString();
                vt = s.IndexOf(kytu);
                if (vt != -1)
                    return false;
                else
                    kt = true;
            }
            return kt;
        }
    }
}
