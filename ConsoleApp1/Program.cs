using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
      
        readonly static System.Text.Encoding UTF8 = Encoding.UTF8;
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var WINDOWS1251 = Encoding.GetEncoding("windows-1251");
           

            var test = "Наука и жизнь\n";
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
            
            
            myStreamWriter.WriteLine(test);
            

            var s = myStreamReader.ReadToEnd();

            var ddsd = WINDOWS1251.GetString(UTF8.GetBytes(s)); 

            File.WriteAllText("1.txt", s, WINDOWS1251);

            // Create two different encodings.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            Encoding utf8 = Encoding.UTF8;
            // Convert the string into a byte array.
            byte[] unicodeBytes = utf8.GetBytes(s);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(utf8, ascii, unicodeBytes);
            var strr = ascii.GetString(asciiBytes);
            myStreamWriter.Close();
        }
    }
}
