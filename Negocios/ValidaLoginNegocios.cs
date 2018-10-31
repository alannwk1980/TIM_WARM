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
    public class ValidaLoginNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public ValidaDocColecao ValidarLogin(string entraLogin)
        
        {
            try
            {
                ValidaDocColecao validaDocColecao = new ValidaDocColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@login", entraLogin);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "procValidaLogin");

                foreach (DataRow datarow in dataTable.Rows)
                {
                    ValidaDocClass validalogin1 = new ValidaDocClass();
                    validalogin1.RG_CNPJ = Convert.ToString(datarow["CPF_RG"]);
                    validalogin1.Nome = Convert.ToString(datarow["nome"]);
                    validalogin1.Login = Convert.ToString(datarow["login"]);

                    validaDocColecao.Add(validalogin1);

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
