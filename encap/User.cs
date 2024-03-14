using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    internal class User
    {
               
            int _age;
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("age menfi ola bilmez");
                        return;

                    }
                    _age = value;
                }
            }
            string _username;
            public string Username
            {
                get
                {
                    return _username;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("username bos ola bilmez");
                        return;
                    }
                    _username = value;
                }
            }
            public User()
            {

            }
            public User(string username, string password)
            {
                Username = username;
                Password = password;
            }

            string _password;
            public string Password
            {
                get
                {
                    return _password;
                }
                set
                {
                    if (string.IsNullOrEmpty(value) || value.Length < 8)
                    {
                        Console.WriteLine("xahis olunur 8 karakterden cox olsun ve bos olmasin");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(CorrectPassword(value));


                    }

                }
            }
            private string CorrectPassword(string pass)
            {
                int herifcount = 0;
                int reqemcount = 0;
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i]))
                    {
                        herifcount++;
                    }
                    else if (char.IsDigit(pass[i]))
                    {
                        reqemcount++;
                    }
                }
                if (herifcount > 0 && reqemcount > 0)
                {
                    return pass;
                }
                else
                {
                    return "sertlerden biri odenmir, parolu yeniden cehd edin zehmt olmasa";
                }
            }
        
    }
}
