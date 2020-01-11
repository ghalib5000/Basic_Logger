using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogger
{
    public class Logger
    {
        //static string date = DateTime.Now.ToString("yyyy_MM_dd");
        private readonly string logloc = "";// @"C:\Windows\Temp\Log_" + date + ".log";
        /// <summary>
        /// <para>start log</para>
        /// initalizes the lodder with a new logfile
        /// </summary>
        /// <param name="location">location must include the file location along with filename.extension</param>
        /// <param name="date">date format can be anything</param>
        public Logger(string location, string date)
        {
            string t = "Logging started at " + date + Environment.NewLine;// DateTime.Now + Environment.NewLine;
            logloc = location;
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.WriteLine(t);
            File.AppendAllText(logloc, t);

        }
        /// <summary>
        /// logs imformation into the file
        /// </summary>
        /// <param name="info"></param>
        public void Information(string info)
        {
            string data = "IMFORMATION: Work " + info + " Done at " + DateTime.Now + Environment.NewLine;
            //  Console.ForegroundColor = ConsoleColor.White;
            // Console.WriteLine(data);
            File.AppendAllText(logloc, data);
        }
        /// <summary>
        /// logs imformation into the file along with current date
        /// </summary>
        /// <param name="info"></param>
        /// <param name="current_date"></param>
        public void Information(string info, string current_date)
        {
            string data = "IMFORMATION: Work " + info + " Done at " + current_date + Environment.NewLine;
            //   Console.ForegroundColor = ConsoleColor.White;
            //  Console.WriteLine(data);
            File.AppendAllText(logloc, data);
            }
        /// <summary>
        /// logs Error into the file
        /// </summary>
        /// <param name="error"></param>
        public void Error(Exception error)
        {
            string data = "ERROR: Error " + error.ToString() + " found  at " + DateTime.Now + Environment.NewLine;
            // Console.ForegroundColor = ConsoleColor.DarkRed;
            // Console.WriteLine(data);
            File.AppendAllText(logloc, data);
            throw (error);
        }
        /// <summary>
        /// logs Error into the file along with current date
        /// </summary>
        /// <param name="error"></param>
        /// <param name="current_date"></param>
        public void Error(Exception error, string current_date)
        {
            string data = "ERROR: Error " + error.ToString() + " found  at " + current_date + Environment.NewLine;
            // Console.ForegroundColor = ConsoleColor.DarkRed;
            //  Console.WriteLine(data);
            File.AppendAllText(logloc, data);
            throw (error);
        }
        /// <summary>
        /// checks if the file exists or not
        /// </summary>
        /// <returns></returns>
        public bool Exists()
        {
            return File.Exists(logloc);
        }

    }
}
