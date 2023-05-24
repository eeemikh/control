using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString mystr = new MyString("tevirp");
            Console.WriteLine(mystr.ReverseString());
        }
        public class MyString
        {
            public string _string = "abc";
            public MyString(string str)
            {
                _string = str;
            }
            public string ReverseString()
            {
                char[] _char = _string.ToCharArray();
                Array.Reverse(_char);
                return new string(_char);
            }

        }
    }
}
