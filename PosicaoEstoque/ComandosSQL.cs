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

        private const string sPosicaoEstoque = "select POSICAOESTOQUE.CODIGO, POSICAOESTOQUE.DESCRICAO, POSICAOESTOQUE.UN, POSICAOESTOQUE.MATRIZ, POSICAOESTOQUE.VILAISA, POSICAOESTOQUE.CIMENTO, POSICAOESTOQUE.CEDIS, POSICAOESTOQUE.GERAL, POSICAOESTOQUE.PRECOCUSTO, POSICAOESTOQUE.VALORESTOQUE from POSICAOESTOQUE";

        internal static BindingSource bsProdutos()
        {
            // vincular com servidor e tabela
            daPosicaoEstoque = new FbDataAdapter(sPosicaoEstoque, new FbConnection(new Conexao.ConexaoFirebird().conexao));
            cbPosicaoEstoque = new FbCommandBuilder(daPosicaoEstoque);
            dtPosicaoEstoque = new DataTable();
            daPosicaoEstoque.Fill(dtPosicaoEstoque);
            bsPosicaoEstoque = new BindingSource();
            bsPosicaoEstoque.DataSource = dtPosicaoEstoque;
            return bsPosicaoEstoque;
        }
    }
}
