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
                var processCount = Convert.ToInt32(processCountStr);
                for (int i = 0; i < processCount; i++)
                {
                    ProcessHelper.Start(processFileName);
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
        public static void Start(string fileName)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.FileName = fileName;
            processStartInfo.Arguments = "2 8";
            var process = Process.Start(processStartInfo);
            if (process == null)
            {
                Console.WriteLine("Process start failed");
            }
            else
            {
                if (process.HasExited)
                {
                    Console.WriteLine($"process.HasExited = {process.HasExited}, process.ExitCode = {process.ExitCode}");
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
    }
}
