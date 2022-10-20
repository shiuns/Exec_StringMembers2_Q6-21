using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Exec_StringMembers2_Q6__21_謝孟勳
{
    //比對使用者輸入值是否為 "Allen", 區分大小寫
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Allen";
            if (Regex.IsMatch(name, "[A-Z]") && Regex.IsMatch(name, "[a-z]"))
            {
                Console.WriteLine("區分大小寫");
            }
            else
            {
                Console.WriteLine("沒有區分大小寫");
            }
        }
    }
}
