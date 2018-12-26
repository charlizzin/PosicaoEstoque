using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private const string sPosicaoEstoque = "select mvgeral.codprod, mvgeral.dt_movimento, TRUNC(mvgeral.quantidade,3) AS QUANTIDADE from mvgeral where mvgeral.dt_movimento = '01.01.2017'";
        /*private const string sPosicaoEstoque = "select A.CODIGO, A.DESCRICAO, " +
                 "(A.ENTRADA00 - A.SAIDA00) as MATRIZ, " +
                     "(A.ENTRADA01 - A.SAIDA01) as VILAISA, "+
                         "(A.ENTRADA03 - A.SAIDA03) as CIMENTO, " +
                             "(A.ENTRADA04 - A.SAIDA04) as CEDIS, "+
                             "((A.ENTRADA00 + A.ENTRADA01 + A.ENTRADA03 + A.ENTRADA04) "+
                         " - "+
                     "(A.SAIDA00 + A.SAIDA01 + A.SAIDA03 + A.SAIDA04)) as DIFERENCA "+
                 "from JUNCAO A "+
             "ORDER BY A.DESCRICAO ";
             */
             

        internal static BindingSource bsProdutos()
        {
            // vincular com servidor e tabela
            daPosicaoEstoque = new FbDataAdapter(sPosicaoEstoque, Conexao.ConexaoFireBird.conexao);
            cbPosicaoEstoque = new FbCommandBuilder(daPosicaoEstoque);
            dtPosicaoEstoque = new DataTable();
            daPosicaoEstoque.Fill(dtPosicaoEstoque);
            bsPosicaoEstoque = new BindingSource();
            bsPosicaoEstoque.DataSource = dtPosicaoEstoque;
            return bsPosicaoEstoque;
        }
    }
}
