using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Palindrome
{
   public abstract class Palindrome
    {
        public static void Palin(string s)
        {

            string falseflag = "Not a palindrome";
            string trueflag = "Is a palindrome";
            int length = s.Length;
            string reverse;
            

            s = s.Replace(" ", string.Empty);
            s = s.Replace(",", string.Empty);
            s = s.Replace(".", string.Empty);
            char[] str = s.ToCharArray();
            Array.Reverse(str);
            reverse = new string(str);

            bool IsPali = s.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            if (IsPali == true)
            { Console.WriteLine(trueflag); }
            if (IsPali == false)
            { Console.WriteLine(falseflag); }
            Console.Read();

            
        }

        
        

        
    }
}
