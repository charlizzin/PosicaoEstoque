using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;

namespace PosicaoEstoque
{
    public class ComandosSQL
    {
        private static FbDataAdapter daPosicaoEstoque;
        private static FbCommandBuilder cbPosicaoEstoque;
        private static DataTable dtPosicaoEstoque;
        private static BindingSource bsPosicaoEstoque;

        //private const string sPosicaoEstoque = "select mvgeral.codprod, mvgeral.dt_movimento, TRUNC(mvgeral.quantidade,3) from mvgeral where mvgeral.dt_movimento = '01.01.2017'";
        private const string sPosicaoEstoque = "select A.CODIGO, A.DESCRICAO, A.UN, A.MATRIZ, A.VILAISA, A.CIMENTO, A.CEDIS, A.GERAL, A.PRECOCUSTO, A.VALORESTOQUE from POSICAOESTOQUE A ";
        #region TESTE
        //criei varios select para retornar a quantidade de produtos negativos mas a aplicacao ficou muito lenta porque ficou fazendo varias pesquisas no BD

        //private const string sNegMatriz = "SELECT COUNT(A.CODIGO) FROM POSICAOESTOQUE A WHERE A.MATRIZ <'0'";
        //private const string sNegVilaIsa = "SELECT COUNT(A.CODIGO) FROM POSICAOESTOQUE A WHERE A.VILAISA <'0'";
        //private const string sNegCimento = "SELECT COUNT(A.CODIGO) FROM POSICAOESTOQUE A WHERE A.CIMENTO <'0'";
        //private const string sNegCedis = "SELECT COUNT(A.CODIGO) FROM POSICAOESTOQUE A WHERE A.CEDIS <'0'";
        //private const string sNegGeral = "SELECT COUNT(A.CODIGO) FROM POSICAOESTOQUE A WHERE A.GERAL <'0'";

        //internal static string NegMatriz()
        //{
        //    FbCommand fbcmd = new FbCommand(sNegMatriz, Conexao.ConexaoFireBird.conexao);
        //    int contagemMatriz = (int)fbcmd.ExecuteScalar();
        //    return contagemMatriz.ToString();
        //}

        //internal static string NegVilaIsa()
        //{
        //    FbCommand fbcmd = new FbCommand(sNegVilaIsa, Conexao.ConexaoFireBird.conexao);
        //    int contagemVilaIsa = (int)fbcmd.ExecuteScalar();
        //    return contagemVilaIsa.ToString();
        //}

        //internal static string NegCimento()
        //{
        //    FbCommand fbcmd = new FbCommand(sNegCimento, Conexao.ConexaoFireBird.conexao);
        //    int contagemCimento = (int)fbcmd.ExecuteScalar();
        //    return contagemCimento.ToString();
        //}

        //internal static string NegCedis()
        //{
        //    FbCommand fbcmd = new FbCommand(sNegCedis, Conexao.ConexaoFireBird.conexao);
        //    int contagemCedis = (int)fbcmd.ExecuteScalar();
        //    return contagemCedis.ToString();
        //}

        //internal static string NegGeral()
        //{
        //    FbCommand fbcmd = new FbCommand(sNegGeral, Conexao.ConexaoFireBird.conexao);
        //    int contagemGeral = (int)fbcmd.ExecuteScalar();
        //    return contagemGeral.ToString();
        //}
        #endregion TESTE
        internal static BindingSource bsProdutos()
        {
            // vincular com servidor e tabela
            daPosicaoEstoque = new FbDataAdapter(sPosicaoEstoque, Conexao.ConexaoFireBird.conexao);
            cbPosicaoEstoque = new FbCommandBuilder(daPosicaoEstoque);
            dtPosicaoEstoque = new DataTable();
            daPosicaoEstoque.Fill(dtPosicaoEstoque);
            bsPosicaoEstoque = new BindingSource();
            bsPosicaoEstoque.DataSource = dtPosicaoEstoque;
            Conexao.ConexaoFireBird.FecharConexao();
            return bsPosicaoEstoque;
        }
    }
}
