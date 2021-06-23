using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loger_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Loger loger = new Loger();
            loger.WriteLog("this is error", 4);
        }
    }
}
