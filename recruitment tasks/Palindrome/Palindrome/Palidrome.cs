using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palidrome
    {
        public bool IsStringPalindrome(string userString)
        {
            string trimedString = TrimStringInside(userString);
            //List<string> myList = new List<string>();
            string result = string.Empty;

            for (int i = 0; i < trimedString.Length; i++)
            {
                
                
                result += trimedString[(trimedString.Length - 1) - i].ToString();
                
                //myList.Add(trimedString[trimedString.Length - i].ToString());
            }

            if (trimedString == result)
                return true;
            return false;
        }

        private string TrimStringInside(string userString)
        {
            List<string> myResult = new List<string>();
            string result ="";

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != ' ') result += userString[i].ToString();
            }

            return result.ToLower();
        }
    }
}
