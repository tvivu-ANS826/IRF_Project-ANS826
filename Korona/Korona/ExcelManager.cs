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

        public void HalalozasKiirasExcel(string[] headers, List<Main_table> halalozasiLista) 
        {
            for (int i = 0; i < headers.Length; i++)
            {
                CellaKitolt(1, i + 1, headers[i]);
            }
            object[,] valuesOfHalalozasok = new object[halalozasiLista.Count, headers.Length];
            int counter = 0;
            foreach (Main_table halalozas in halalozasiLista)
            {
                valuesOfHalalozasok[counter, 0] = halalozas.Id;
                valuesOfHalalozasok[counter, 1] = halalozas.Beteg_neve;
                valuesOfHalalozasok[counter, 2] = halalozas.Alapbetegseg;
                valuesOfHalalozasok[counter, 3] = halalozas.Death_date;
                counter++;
            }
            xlSheet.get_Range(GetCell(2, 1), GetCell(1 + valuesOfHalalozasok.GetLength(0), valuesOfHalalozasok.GetLength(1))).Value2 = valuesOfHalalozasok;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        public void CellaKitolt(int sor, int oszlop, string ertek) 
        {
            xlSheet.Cells[sor, oszlop] = ertek;
        }

        public void Mentes() 
        {
            xlWB.SaveAs(_pathPlusFilename);
            xlWB.Close();
        }

    }
}
