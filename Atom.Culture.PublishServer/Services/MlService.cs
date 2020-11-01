using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Atom.Culture.PublishServer.Services
{
    public class MlService
    {
        public void Model1(string args)
        {
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "python.exe",
                Arguments = "{args}"
            };
            process.Start();
            StreamWriter myStreamWriter = process.StandardInput;
            myStreamWriter.Write(args);
            StreamReader sr = process.StandardOutput;
            var str = sr.ReadToEnd();


        }
    }
}
