using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal class Student
    {

        public Student(int age,string fullname,string groupno)
        {
            Age      = age;
            Fullname = fullname;
            GroupNo  = groupno;  
                
        }
         public int Age { get; set; }
         string _fullName;
         string _groupNo;
         public string Fullname
         {
            get => _fullName;
            set
            {
                if (CheckFullName(value))
                {
                    _fullName = value;
                }
            }
         }
         public string GroupNo
         {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
         }

         public static bool CheckGroupNo(string groupNo)
         {
            if (!string.IsNullOrEmpty(groupNo))
            {
                if (char.IsUpper(groupNo[0])&&char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
                {
                    return true;
                }
            }
            return false;
         }


         public static bool CheckFullName(string fullname)
         {
            var words = fullname.Split();

            if (words.Length == 2 && char.IsUpper(words[0][0]) && char.IsUpper(words[1][0]))
            {
                return true;
            }

            return false;
         }
    }
}
