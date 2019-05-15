using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConfirmMeWSQuartz
{
    public class LoggerBgServ
    {
        public void LogError(string Exception_String)
        {
            StringBuilder sb = new StringBuilder();
            string filePath = "C:\\AppLogs\\ErrorLogs\\WinService\\";
            sb.AppendLine(DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt"));
            sb.AppendLine(Exception_String);
            sb.AppendLine(Environment.NewLine);
            sb.AppendLine(Environment.NewLine);
            FileInfo file = new FileInfo(filePath);
            file.Directory.Create(); // If the directory already exists, this method does nothing.
            File.AppendAllText(filePath + DateTime.Now.ToString("dd-MMM-yyyy") + ".txt", sb.ToString());
        }
    }
}
