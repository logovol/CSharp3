using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MailSender.lib.Service
{
    public class TextEncoder
    {
        public static string Encode(string str, int key = 1)
        {
            return new string(str.Select(c => (char)(c + key)).ToArray());
            
            // простой вариант
            //string password = "";
            //foreach (char a in p_sPassw)
            //{
            //    char ch = a;
            //    ch--;
            //    password += ch;
            //}

            //return password;
        }
        public static string Decode(string str, int key = 1)
        {
            return new string(str.Select(c => (char)(c + key)).ToArray());
        }
    }
}
