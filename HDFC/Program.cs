using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFC
{
    class Program
    {
        static void Main(string[] args)
        {
            var Test1 = new CurrentAccount().OpenAccount(121231, "Test1");
            var Test2 = new CurrentAccount().OpenAccount(12, "Test2");
        }
    }
}
