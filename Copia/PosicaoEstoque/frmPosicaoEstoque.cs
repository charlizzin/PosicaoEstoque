using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosicaoEstoque
{
    public partial class frmPosicaoEstoque : Form
    {
        private BindingSource bsProdutos;
        public frmPosicaoEstoque(BindingSource bs)
        {
            InitializeComponent();
            bsProdutos = bs;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            tbCodProd.Clear();
            tbDesc.Clear();
            dGVPosicaoEstoque.DataSource = bsProdutos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPosicaoEstoque_Load(object sender, EventArgs e)
        {
            dGVPosicaoEstoque.DataSource = bsProdutos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                if (tbCodProd.Text != "" && tbDesc.Text == "")
                {
                    int a;
                    a = Convert.ToInt32(tbCodProd.Text);
                    tbCodProd.Text = a.ToString("000000");
                    bsProdutos.Filter = "CODIGO = '" + tbCodProd.Text + "'";
                }
                else //(tbDesc.Text != "" && tbCodProd.Text == "")
                {
                    bsProdutos.Filter = "DESCRICAO LIKE '%" + tbDesc.Text + "%'";
                }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbCodProd.Clear();
            tbDesc.Clear();            
        }

        private void tbCodProd_Click(object sender, EventArgs e)
        {
            tbDesc.Clear();
        }

        private void tbDesc_Click(object sender, EventArgs e)
        {
            tbCodProd.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out num);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Plan1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < dGVPosicaoEstoque.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dGVPosicaoEstoque.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dGVPosicaoEstoque.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dGVPosicaoEstoque.Columns.Count; j++)
                {
                    if (dGVPosicaoEstoque.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dGVPosicaoEstoque.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }
    }
}
