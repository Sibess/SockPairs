using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace SockPairs
{
   public class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine(SockPairs("CABBACCC"));
        }

        public static int SockPairs(string socks)
        {
            char[] charArray = socks.ToCharArray();

            Dictionary<char, int> charDisctionary = new Dictionary<char, int>();

            foreach (char ch in charArray)
            {
                if (charDisctionary.ContainsKey(ch))
                {
                    charDisctionary[ch] = charDisctionary[ch] + 1;
                }
                else
                {
                     charDisctionary.Add(ch, 1);
                }

            }

              int result = 0;

               foreach ( int count in charDisctionary.Values)
               {
                if (count > 1)
                {
                    result += count / 2;
                }
               }
               return result;
        }
    }
    }

