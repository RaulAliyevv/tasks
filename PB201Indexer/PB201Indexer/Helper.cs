using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB201Indexer
{
    public class Helper
    {
        public static string CreateBookCode(string bookName, int number)
        {
            string code = bookName.Substring(0, 2).ToUpper();
            code += number.ToString("D2");
            return code;
        }
    }
}
