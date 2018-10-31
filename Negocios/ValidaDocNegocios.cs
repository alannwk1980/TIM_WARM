using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Negocios
{
    public class ValidaDocNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public ValidaDocColecao ValidarDoc(string entraDoc)
        {
            try
            {
                ValidaDocColecao validaDocColecao = new ValidaDocColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@doc", entraDoc);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "procValidaDoc");

                foreach (DataRow datarow in dataTable.Rows)
                {
                    ValidaDocClass validadoc1 = new ValidaDocClass();
                    validadoc1.RG_CNPJ = Convert.ToString(datarow["CPF_RG"]);
                    validadoc1.Nome = Convert.ToString(datarow["nome"]);
                    validadoc1.Login = Convert.ToString(datarow["login"]);

                    validaDocColecao.Add(validadoc1);

                }

                return validaDocColecao;
            }

            catch (Exception erroOcorrido)
            {
                throw new Exception("Erro: " + erroOcorrido.Message);

            }



        }

    }
}
