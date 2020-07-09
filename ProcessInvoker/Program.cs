using System;
using System.Configuration;
using System.Diagnostics;

namespace ProcessInvoker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var processFileName= ConfigurationManager.AppSettings[AppSettingKeys.ProcessFileName];
                var processCountStr = ConfigurationManager.AppSettings[AppSettingKeys.ProcessCount];
                var arguments = ConfigurationManager.AppSettings[AppSettingKeys.Arguments];
                var processCount = Convert.ToInt32(processCountStr);
                for (int i = 0; i < processCount; i++)
                {
                    ProcessHelper.Start(processFileName, arguments);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }

    class ProcessHelper
    {
        public static void Start(string fileName, string arguments)
        {
            var processStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false, 
                FileName = fileName,
                Arguments = arguments//The default is an empty string ("").
            };
            var process = Process.Start(processStartInfo);
            if (process == null)
            {
                Console.WriteLine("Process start failed");
            }
            else
            {
                if (process.HasExited)
                {
                    Console.WriteLine(
                        $"process.HasExited = {process.HasExited}, process.ExitCode = {process.ExitCode}");
                }
                else
                {
                    Console.WriteLine($"process.HasExited = {process.HasExited}");
                }
            }
        }
    }

    class AppSettingKeys
    {
        public const string ProcessFileName = "ProcessFileName";

        public const string ProcessCount = "ProcessCount";

        public const string Arguments = "Arguments";
    }
}
