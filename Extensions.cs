using Sealkeen.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaStreamer.Logging
{
    public static class Extensions
    {
        private static SimpleLogger LoggerInstance { get;set; }
        /// <summary>
        /// Log statically using singleton logger instance
        /// </summary>
        /// <param name="message"></param>
        public static void LogStatically(this string message)
        {
            if (LoggerInstance == null)
                LoggerInstance = new SimpleLogger();
            
            LoggerInstance.LogInfo(message);
        }

        public static void LogInConsoleAndDebug(string message)
        {
            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine(message);
        }
        
        public static Action<string> GetLogInfoOrReturnNull(this ILogger logger)
        {
            if (logger == null)
            {
                return null;
            }
            else
                return logger.LogInfo;
        }

        public static Action<string> GetLogErorrOrReturnNull(this ILogger logger)
        {
            if (logger == null)
            {
                return null;
            }
            else
                return logger.LogError;
        }
    }
}
