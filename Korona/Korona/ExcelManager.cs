using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Korona
{    
    class ExcelManager
    {
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        Excel.Range xlRange;
        string _pathPlusFilename;

        public ExcelManager(string pathPlusFilename, string sheetName) 
        {
            _pathPlusFilename = pathPlusFilename;
            xlApp = new Excel.Application();

            if (xlApp == null)
            {
                throw new Exception("Kérjük telepítse az Excelt.");
            }
            xlWB = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            xlSheet = (Excel.Worksheet)xlWB.Worksheets[1];
            xlSheet.Name = sheetName;
            xlRange = xlSheet.UsedRange;
        }





    }
}
