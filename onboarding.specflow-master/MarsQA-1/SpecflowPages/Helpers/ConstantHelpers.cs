using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {

        //Base Url
        public static string Url = "http://localhost:5000";

        //ApplicationPath
        public static string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = string.Concat(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")), @"TestReports\Screenshots\");

        //ExtentReportsPath
        public static string ReportsPath = string.Concat((Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")), @"TestReports\Screenshots\1\"),".html"); 

        //ReportXML Path
        public static string ReportXMLPath = string.Concat(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")), @"TestReports","ExtentRepot_Config.xml");


    }

}
