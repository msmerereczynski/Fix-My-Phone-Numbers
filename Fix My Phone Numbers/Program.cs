using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_My_Phone_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the phone number: ");
            string input = Console.ReadLine();
            List<char> listOfNum = new List<char>();
            char[] arrayOfChar = input.ToCharArray();
            for(int i = 0; i < arrayOfChar.Length; i++)
            {
                if (int.TryParse(Convert.ToString(arrayOfChar[i]), out _)){
                    listOfNum.Add(arrayOfChar[i]);
                }
            }
            if (listOfNum.Count > 0)
            {
                if (listOfNum[0] == '0')
                {
                    if (listOfNum.Count == 11)
                    {
                        Console.WriteLine(new string(listOfNum.ToArray()));
                    }
                    else
                    {
                        Console.WriteLine("Not a phone number");
                    }
                }
                else
                {
                    Console.WriteLine("Not a phone number");
                }
            }
            else
            {
                Console.WriteLine("Not a phone number");

            }
            Console.ReadLine();
        }
    }
}
