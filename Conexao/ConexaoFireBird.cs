using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace Conexao
{
    public class ConexaoFirebird
    {
        public readonly string conexao = ConfigurationManager.ConnectionStrings["strFirebirdPrincipal"].ConnectionString;
    }
}