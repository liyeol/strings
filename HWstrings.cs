using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Input the string 2: ");
            string str2 = Console.ReadLine();
            //string str1 = "Tom is a man";
            //string str2 = "Tom is a man";

            Compare(str1, str2);
            Analyze(str1);
            Sort(str1);
            Duplicate(str1);
            Console.ReadKey();
        }
        public static void Compare(string str1, string str2)
        {
            if (str1 == str2)
            {
                Console.Write("True, strings are equal\n");
            }
            else
            {
                Console.Write("False, strings aren't equal\n");
            }

        }
        public static void Analyze(string str1)
        {
            int alp, dig, spch, i, l;
            alp = dig = spch = i = 0;


            l = str1.Length;


            while (i < l)
            {
                if ((str1[i] >= 'a' && str1[i] <= 'z') || (str1[i] >= 'A' && str1[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str1[i] >= '0' && str1[i] <= '9')
                {
                    dig++;
                }
                else
                {
                    spch++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alp);
            Console.Write("Number of Digits in the string is : {0}\n", dig);
            Console.Write("Number of Special characters in the string is : {0}\n\n", spch);
        }
        public static void Sort(string str1)
        {
            char temp;
            string str = str1.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Alphabet sort: ");
            Console.WriteLine(charstr);

        }
        public static void Duplicate(string str1)
        {
            Dictionary<char,
               int> count = new Dictionary<char,
                                           int>();

            for (int i = 0; i < str1.Length; i++)
            {
                if (count.ContainsKey(str1[i]))
                    count[str1[i]]++;
                else
                    count[str1[i]] = 1;
            }

            foreach (var it in count.OrderBy(key => key.Value))
            {
                if (it.Value > 1)
                    Console.WriteLine(it.Key + ", count of duplicates = " +
                                      it.Value);
            }

            
        }
    }
    
}
