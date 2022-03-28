using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    static class Extention
    {

        public static bool IsOdd(this int num)
        {
            if(num%2==0)
            {
                return false;

            }
            return true;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;

            }
            return false;
        }

        public static bool CheckHasDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true ;
                }
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
            
        }

        public static int [] GetValueIndexes(this string str, char elements)
        {
            int[] AddItem = new int[0];

            foreach (var item in str)
            {
                if (item==elements)
                {
                    Array.Resize(ref AddItem, AddItem.Length + 1);
                    AddItem[AddItem.Length - 1] = item;
                }
            }
            return AddItem;
        }


    }
}
