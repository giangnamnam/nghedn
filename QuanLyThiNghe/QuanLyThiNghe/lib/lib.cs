using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThiNghe
{
    public class XuLyChuoi
    {
        public enum KieuMaHoa{MD5,SHA1,HungVQ};
        public static string MaHoa(string ChuoiCanMaHoa, KieuMaHoa MaHoa)
        {
            string kq = "";
            if (MaHoa == KieuMaHoa.MD5)
            {
                kq= Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
            }
            else if (MaHoa == KieuMaHoa.SHA1)
            {
                kq = Convert.ToBase64String(new System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
            }
            else
            {
                kq = Convert.ToBase64String(new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(ChuoiCanMaHoa)));
                kq = Convert.ToBase64String(new System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(kq)));
            }
            return kq;
        }

    }
}
