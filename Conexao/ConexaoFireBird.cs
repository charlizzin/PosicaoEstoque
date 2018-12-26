using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace Conexao
{
    public class ConexaoFireBird
    {
        public static string sConexao()
        {
            FbConnectionStringBuilder criaGerenciaStringConexao = new FbConnectionStringBuilder();
            criaGerenciaStringConexao.UserID = "SYSDBA";
            criaGerenciaStringConexao.Password = "masterkey";
            criaGerenciaStringConexao.DataSource = "192.168.254.251";
            criaGerenciaStringConexao.Database = "E:\\RESWINCS\\Banco\\RESULTH.FB";
            criaGerenciaStringConexao.Port = 3050;
            criaGerenciaStringConexao.Dialect = 3;
            criaGerenciaStringConexao.Charset = "NONE";
            criaGerenciaStringConexao.Role = "";
            criaGerenciaStringConexao.ConnectionLifeTime = 0;
            criaGerenciaStringConexao.ConnectionTimeout = 7;
            criaGerenciaStringConexao.Pooling = true;
            criaGerenciaStringConexao.PacketSize = 8192;
            criaGerenciaStringConexao.ServerType = 0;
            return criaGerenciaStringConexao.ConnectionString;
        }
        public static FbConnection conexao;
        public static void FecharConexao()
        {
            ConexaoFireBird.conexao.Close();
        }
    }
}
