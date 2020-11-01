using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Atom.Culture.PublishServer.Services
{
    public class MlService
    {
       public MlService()
       {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
       }
     
        public IEnumerable<string> ServicesModel(string args)
        {
            var WINDOWS1251 = Encoding.GetEncoding("windows-1251");
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "python.exe",
                Arguments = "ServicesModel.py",
                RedirectStandardInput = true,
                RedirectStandardOutput = true
            };
            process.StartInfo = processStartInfo;
            process.Start();

            StreamWriter myStreamWriter = process.StandardInput;
            StreamReader myStreamReader = process.StandardOutput;
            //Console.OutputEncoding = UTF8;
            //Console.InputEncoding = UTF8;
            myStreamWriter.WriteLine(args);
            Thread.Sleep(100);
            var s = myStreamReader.ReadToEnd();
            var enc = myStreamReader.CurrentEncoding;
            var b = enc.GetBytes(s);
            // byte[] bb = Encoding.Convert(enc, WINDOWS1251, b);
            var ddsd = WINDOWS1251.GetString(b);
            var result = ddsd.Split('\n');
            myStreamWriter.Close();
            myStreamReader.Close();
            return result;
        }
        public IEnumerable<string> BookModel(string args)
        {           
            var WINDOWS1251 = Encoding.GetEncoding("windows-1251");         
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
            myStreamWriter.WriteLine(args);
            Thread.Sleep(100);
            var s = myStreamReader.ReadToEnd();
            var enc = myStreamReader.CurrentEncoding;
            var b = enc.GetBytes(s);
            // byte[] bb = Encoding.Convert(enc, WINDOWS1251, b);
            var ddsd = WINDOWS1251.GetString(b);
            var result = ddsd.Split('\n');      
            myStreamWriter.Close();
            myStreamReader.Close();
            return result;
        }

    }
    public class ScriptSetting
    {
        public string FileName = "python.exe";
        public string Script { get; set; }

    }
        

}
