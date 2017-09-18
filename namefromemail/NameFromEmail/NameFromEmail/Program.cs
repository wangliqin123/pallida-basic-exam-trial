﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type your email address in the following format: firstName.lastName@exam.com");
            string address = Console.ReadLine();

            //NameFromEmail(address);
            //Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            string firstname = NameFromEmail(address);
            Console.WriteLine(firstname);
            Console.ReadLine();
        }
        public static string NameFromEmail(string address)
        {

            string link = address;
            var firstpart = link.Split('@');
            string user = firstpart[0];
            string domain = firstpart[1];

            string[] names = user.Split('.');
            string firstname = names[0];
            string lastname = names[1];

            return firstname;
    
        }

    }
}
 