using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace loger_app
{
    class Loger
    {
        private string _path = "log.txt";
        private bool _date = true;
        private bool _username = true;
        public string Path {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        public Loger(string path)
        {
            _path = path;
        }
        public Loger()
        { }

        public void WriteLog(string message, int level)
        {

            FileStream stream = null;

            /* level 1 = Debug; 
             * level 2 = Info;
             * level 3 = Warn;
             * level 4 = Error;
             * level 5 = Fatal;
             */

            try
            {
                stream = new FileStream(
                    _path,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None
                );
                
                StreamWriter writelog = new StreamWriter(stream, Encoding.UTF8);

                if (level == 1)
                {
                    writelog.Write("Debug: ");
                }
                else if (level == 2)
                {
                    writelog.Write("Info: ");
                }
                else if (level == 3)
                {
                    writelog.Write("Warn: ");
                }
                else if (level == 4)
                {
                    writelog.Write("Error: ");
                }
                else if (level == 5)
                {
                    writelog.Write("Fatal: ");
                }
                else
                {
                    throw new ArgumentException();
                }

                writelog.WriteLine(message);

                writelog.Flush();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: Level of message is incorrect!");
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }
    }
}
