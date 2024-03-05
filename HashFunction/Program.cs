using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string hashCode=ComputeSHA256Hash(input);
            Console.WriteLine(input);
            Console.WriteLine(hashCode);
        }

        private static string ComputeSHA256Hash(string input)
        {
            using(SHA256 sha256 = SHA256.Create()) 
            {
                byte[] bytes=sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb=new StringBuilder();
                for(int i = 0; i < bytes.Length; i++) 
                {
                    sb.Append(bytes[i].ToString());
                }
                return sb.ToString();
            }
        }
    }
}
