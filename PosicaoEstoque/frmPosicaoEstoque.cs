using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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

        private void frmPosicaoEstoque_Load(object sender, EventArgs e)
        {
            dGVPosicaoEstoque.DataSource = bsProdutos;
            //tbNegMatriz.Text = ComandosSQL.NegMatriz();
            //tbNegVilaIsa.Text = ComandosSQL.NegVilaIsa();
            //tbNegCimento.Text = ComandosSQL.NegCimento();
            //tbNegCedis.Text = ComandosSQL.NegCedis();
            //tbNegGeral.Text = ComandosSQL.NegGeral();
            contador();

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
            contador();
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //exportarExcel.exportarDadosExcel(dGVPosicaoEstoque);
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //app.Visible = true;
            //worksheet = workbook.Sheets["Plan1"];
            //worksheet = workbook.ActiveSheet;
            //CultureInfo cultura = new CultureInfo("pt-BR");
            //for (int i = 1; i < dGVPosicaoEstoque.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dGVPosicaoEstoque.Columns[i - 1].HeaderText;
            //}
            //for (int i = 0; i < dGVPosicaoEstoque.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dGVPosicaoEstoque.Columns.Count; j++)
            //    {
            //        if (dGVPosicaoEstoque.Rows[i].Cells[j].Value != null)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = Convert.ToString(dGVPosicaoEstoque.Rows[i].Cells[j].Value.ToString());
            //        }
            //        else
            //        {
            //            worksheet.Cells[i + 2, j + 1] = "";
            //        }
            //    }
            //}
        }

        private void contador()
        {
            int contadorMatriz = 0;
            foreach (DataGridViewRow col in dGVPosicaoEstoque.Rows)
            {
                if (Convert.ToInt32(col.Cells[3].Value) < 0)
                {
                    contadorMatriz = contadorMatriz + 1;
                }
                //valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }
            tbNegMatriz.Text = Convert.ToString(contadorMatriz);

            int contadorVilaIsa = 0;
            foreach (DataGridViewRow col in dGVPosicaoEstoque.Rows)
            {
                if (Convert.ToInt32(col.Cells[4].Value) < 0)
                {
                    contadorVilaIsa = contadorVilaIsa + 1;
                }
                //valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }
            tbNegVilaIsa.Text = Convert.ToString(contadorVilaIsa);

            int contadorCimento = 0;
            foreach (DataGridViewRow col in dGVPosicaoEstoque.Rows)
            {
                if (Convert.ToInt32(col.Cells[5].Value) < 0)
                {
                    contadorCimento = contadorCimento + 1;
                }
                //valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }
            tbNegCimento.Text = Convert.ToString(contadorCimento);

            int contadorCedis = 0;
            foreach (DataGridViewRow col in dGVPosicaoEstoque.Rows)
            {
                if (Convert.ToInt32(col.Cells[6].Value) < 0)
                {
                    contadorCedis = contadorCedis + 1;
                }
                //valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }
            tbNegCedis.Text = Convert.ToString(contadorCedis);

            int contadorGeral = 0;
            foreach (DataGridViewRow col in dGVPosicaoEstoque.Rows)
            {
                if (Convert.ToInt32(col.Cells[7].Value) < 0)
                {
                    contadorGeral = contadorGeral + 1;
                }
                //valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }
            tbNegGeral.Text = Convert.ToString(contadorGeral);

            double contadorValorEstoque = 0;
            foreach (DataGridViewRow col in dGVPosicaoEstoque.Rows)
            {
                if (Convert.ToInt32(col.Cells[9].Value) > 0)
                {
                    double a = Convert.ToDouble(col.Cells[9].Value);
                    contadorValorEstoque = contadorValorEstoque + a;
                }
                //valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }
            tbValorEstoque.Text = Convert.ToString(contadorValorEstoque.ToString("C3"));
        }

    }
}

