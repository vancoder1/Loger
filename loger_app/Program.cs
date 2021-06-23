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
            loger.UserNameAdd = false;
            loger.WriteLog("this is error only with time", 4);
            Loger loger1 = new Loger();
            loger1.DateAdd = false;
            loger.WriteLog("this is warning only with username", 3);
            Loger loger2 = new Loger();
            loger2.WriteLog("this is fatal error with both of them", 5);
        }
    }
}
