using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fake_framework
{
    public class LogMessage
    {
        public DateTime Time { set; get; }
        public string Message { get; set; }
    }

    public class LogParser
    {
        public static LogMessage[] Parse(string p_filePath)
        {
            List<LogMessage> result = new List<LogMessage>();
            StreamReader reader = new StreamReader(p_filePath);
            string[] messages = reader.ReadToEnd().Split('\n');
            foreach (var msg in messages)
            {
                result.Add(
                    new LogMessage()
                    {
                        Time = DateTime.Parse(msg.Remove(19)),
                        Message = msg.Substring(20)
                    });
            }
            return result.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
