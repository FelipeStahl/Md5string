using System.Security.Cryptography;
using System.Text;

namespace Md5string
{
    public static class Md5string
    {
        public static string ToMD5(this string value){
            if(string.IsNullOrEmpty(value)){
                return string.Empty;
            }
            using (MD5 md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(value);
                var hashBytes = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder();
                foreach (var item in hashBytes)
                {
                    sb.Append(item.ToString("X2"));
                }
                return sb.ToString();
            }          
        }

        public static bool CompareMD5(this string value, string md5)
        {
            var md5Convert = ToMD5(value);
            if (comparar(md5Convert, md5))
                return true;
            else
                return false;
        }

        private static bool comparar(string md5Convert, string compare)
        {
            System.StringComparer compara = System.StringComparer.OrdinalIgnoreCase;

            if (0 == compara.Compare(md5Convert, compare))
                return true;
            else
                return false;
        }
    }
}
