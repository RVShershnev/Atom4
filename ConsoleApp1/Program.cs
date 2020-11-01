using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
      
        readonly static System.Text.Encoding UTF8 = Encoding.UTF8;
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var WINDOWS1251 = Encoding.GetEncoding("windows-1251");
           

            var test = "Наука и жизнь";
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "python.exe",
                Arguments = "BookModel.py",
                RedirectStandardInput = true,
                RedirectStandardOutput = true
            };        
            process.StartInfo = processStartInfo;
            process.Start();

            StreamWriter myStreamWriter = process.StandardInput;       
            StreamReader myStreamReader = process.StandardOutput;
            //Console.OutputEncoding = UTF8;
            //Console.InputEncoding = UTF8;
            myStreamWriter.WriteLine(test);
            Thread.Sleep(100);

            var s = myStreamReader.ReadToEnd();
            var enc = myStreamReader.CurrentEncoding;
            var b = enc.GetBytes(s);
            // byte[] bb = Encoding.Convert(enc, WINDOWS1251, b);
            var ddsd = WINDOWS1251.GetString(b); 

            File.WriteAllText("1.txt", ddsd);

            
            myStreamWriter.Close();
        }
    }
}
