using System.Security.Cryptography;
using System.Text;

namespace Md5string
{
    public static class Md5string
    {
        public static string ToMd5(this string value){
            if(string.IsNullOrEmpty(value)){
                return string.Empty;
            }
            using var md5 = MD5.Create();
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
}
