using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosicaoEstoque
{
    public class exportarExcel
    {
        public static void exportarDadosExcel(DataGridView mDGVRelTransferencia)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            if (mDGVRelTransferencia.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < mDGVRelTransferencia.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = mDGVRelTransferencia.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < mDGVRelTransferencia.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < mDGVRelTransferencia.Columns.Count; j++)
                        {
                            
                            XcelApp.Cells[i + 2, j + 1] = Convert.ToString(mDGVRelTransferencia.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Não a dados para ser exportado!!", "", MessageBoxButtons.OK);
            }
        }
    }
}
