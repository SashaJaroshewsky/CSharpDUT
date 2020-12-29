using System;
using System.Linq;
using System.Reflection.Metadata;

namespace HUUTSAN
{
    class Program
    {
        public static int reverseNum(int num)
        {
            string x = Convert.ToString(num);
            char[] charArray = x.ToCharArray();
            Array.Reverse( charArray );
            x = new string( charArray );

            int result = Convert.ToInt32(x);
            
            return result;

        }

        public static string reverseStr(string str)
        {
           
            char[] charArray = str.ToCharArray();
            Array.Reverse( charArray );
           
            
            return new string( charArray );;

        }

        
        
        public static string reverseNum(double num)
        {
            string x = Convert.ToString(num);
            char[] charArray = x.ToCharArray();

            int pointINDEX = 0;
            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '.')
                {
                    pointINDEX = i;
                }
            }

            
            char[] charArrayTwo = new char[pointINDEX];
            char[] charArrayThree = new char[charArray.Length - pointINDEX];
            for (int i = 0; i < pointINDEX; i++)
            {
                charArrayTwo[i] = charArray[i];
            }

            
            int j = 0;
            for (int i = pointINDEX+1; i < charArray.Length; i++)
            {
                charArrayThree[j] = charArray[i];
                j++;
            }
           
           Array.Reverse(charArrayTwo);
           Array.Reverse(charArrayThree);
           string final = new string(charArrayTwo)+"."+new string(charArrayThree);
           charArray = final.ToCharArray();
           

           
           
           
           
           Console.WriteLine(new string(charArray));
           
           return new string(charArray);
        }
        
        public static string MagicSymbRev(string str, char symbol)
        {
           
            char[] charArray = str.ToCharArray();

            int pointINDEX = 0;
            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == symbol)
                {
                    pointINDEX = i;
                }
            }

            
            char[] charArrayTwo = new char[pointINDEX];
            char[] charArrayThree = new char[charArray.Length - pointINDEX];
            for (int i = 0; i < pointINDEX; i++)
            {
                charArrayTwo[i] = charArray[i];
            }

            
            int j = 0;
            for (int i = pointINDEX+1; i < charArray.Length; i++)
            {
                charArrayThree[j] = charArray[i];
                j++;
            }
           
            Array.Reverse(charArrayTwo);
            Array.Reverse(charArrayThree);
            string final = new string(charArrayTwo)+"."+new string(charArrayThree);
            charArray = final.ToCharArray();
           

           
           
           
           
         
           
            return new string(charArray);
        }

        public static void CustomReversing(ref int[] arr)
        {
            
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            
        }
        
        static void Main(string[] args)
        {

           


        }
    }
}
