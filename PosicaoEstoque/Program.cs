using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace PosicaoEstoque
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Conexao.ConexaoFireBird.conexao = new FbConnection(Conexao.ConexaoFireBird.sConexao()))
            {
                Conexao.ConexaoFireBird.conexao.Open();
                Application.Run(new frmPosicaoEstoque(ComandosSQL.bsProdutos()));
            }
        }
    }
}
