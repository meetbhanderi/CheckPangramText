﻿using System;

namespace CheckPangramText
{
   class Program
    {
        static void Main(string[] args)
        {
            ComeHere:
            Console.Write("\nEnter Text for Checking Pangram : ");
            string data = Console.ReadLine();

            if (!string.IsNullOrEmpty(data))
            {
                Console.WriteLine(CheckPangram(data));
                goto ComeHere;
            }
            else
            {
                Console.WriteLine(" \nEnter Text First");
                goto ComeHere;
            }

        }

        public static string CheckPangram(string text)
        {
            try
            {
                string pengram = "not pangram";
                string p = new string(text.Distinct().ToArray());
                int t = 0;
                List<string> a = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(",").ToList();

                foreach (var item in p)
                {
                    a.Remove(item.ToString());
                }

                if (a.Count == 0)
                {
                    pengram = "pangram";
                }
                return pengram;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
