using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _01._Email_Validator
{
    class Program
    {
        //90/100 have to check! :)
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var command = Console.ReadLine();
            while (true)
            {
                var tokens = command.Split();
                if (tokens[0] == "Make")
                {
                    if (tokens[1] == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else if (tokens[1] == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (tokens[0] == "GetDomain")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var temp = string.Empty;
                    if (startIndex > 0 && startIndex < email.Length)
                    {
                        temp = email.Substring(email.Length - startIndex);

                    }
                    Console.WriteLine(temp);
                }
                else if (tokens[0] == "GetUsername")
                {
                    if (email.Contains('@'))
                    {
                        var index = email.IndexOf('@');
                        var temp = email.Substring(0, index);
                        Console.WriteLine(temp);
                        //var temp = string.Empty;
                        //for (int i = 0; i < email.Length; i++)
                        //{
                        //    if (email[i] == '@')
                        //    {
                        //        break;
                        //    }
                        //    temp += email[i];
                        //}
                        //Console.WriteLine(temp);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (tokens[0] == "Replace")
                {
                    char character = char.Parse(tokens[1]);
                    if (email.Contains(character))
                    {
                        email = email.Replace(character, '-');
                        Console.WriteLine(email);
                    }
                }
                else if (tokens[0] == "Encrypt")
                {

                    byte[] asciiList = Encoding.ASCII.GetBytes(email);

                    Console.WriteLine(string.Join(" ", asciiList));
                }
                else if (tokens[0] == "Complete")
                {
                    break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
