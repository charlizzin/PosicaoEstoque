using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PosicaoEstoque
{
    public class exportarExcel
    {
        public static void exportarDadosExcel(DataGridView mDGVRelTransferencia)
        {
            //Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            //var ci = new CultureInfo("pt-BR");
            //XcelApp.UseSystemSeparators = false;
            //XcelApp.DecimalSeparator = ci.NumberFormat.NumberDecimalSeparator;
            //XcelApp.ThousandsSeparator = ci.NumberFormat.NumberGroupSeparator;
            //if (mDGVRelTransferencia.Rows.Count > 0)
            //{
            //    try
            //    {
            //        XcelApp.Application.Workbooks.Add(Type.Missing);
            //        for (int i = 1; i < mDGVRelTransferencia.Columns.Count + 1; i++)
            //        {
            //            XcelApp.Cells[1, i] = mDGVRelTransferencia.Columns[i - 1].HeaderText;
            //        }
            //        //
            //        for (int i = 0; i < mDGVRelTransferencia.Rows.Count - 1; i++)
            //        {
            //            for (int j = 0; j < mDGVRelTransferencia.Columns.Count; j++)
            //            {
            //                CultureInfo[] cultura = { new CultureInfo("pt-BR") };
            //                XcelApp.Cells[i + 2, j + 1] = mDGVRelTransferencia.Rows[i].Cells[j].Value;
            //                //Console.WriteLine("{0}: {1}", culture.Name, dateValue.ToString(culture));
            //            }
            //        }
            //        //
            //        XcelApp.Columns.AutoFit();
            //        //
            //        XcelApp.Visible = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Erro : " + ex.Message);
            //        XcelApp.Quit();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Não a dados para ser exportado!!", "", MessageBoxButtons.OK);
            //}

            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //app.Visible = true;
            //worksheet = workbook.Sheets["Plan1"];
            //worksheet = workbook.ActiveSheet;
            //for (int i = 1; i < mDGVRelTransferencia.Columns.Count + 1; i++)
            //{
            //   worksheet.Cells[1, i] = mDGVRelTransferencia.Columns[i - 1].HeaderText;
            //}
            //for (int i = 0; i < mDGVRelTransferencia.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < mDGVRelTransferencia.Columns.Count; j++)
            //    {
            //        if (mDGVRelTransferencia.Rows[i].Cells[j].Value != null)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = Convert.ToString(mDGVRelTransferencia.Rows[i].Cells[j].Value.ToString());
            //        }
            //        else
            //        {
            //            worksheet.Cells[i + 2, j + 1] = "";
            //        }
            //    }
            //}
        }
    }
}
