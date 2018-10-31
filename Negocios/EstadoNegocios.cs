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
    public class EstadoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public EstadoColecao ConsultarEstado(string entraEstado)
        {
            try
            {
                EstadoColecao estadoColecao = new EstadoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@descUF", entraEstado);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "procUF");

                foreach (DataRow datarow in dataTable.Rows)
                {
                    Estado estado1 = new Estado();
                    estado1.UF = Convert.ToString(datarow["UF"]);
                    estado1.DescUF = Convert.ToString(datarow["descUF"]);
                    estado1.Particao = Convert.ToString(datarow["Particao"]);

                    estadoColecao.Add(estado1);
                }

                
                return estadoColecao;
            }
            catch(Exception erroOcorrido)
            {
                throw new Exception("Erro: " + erroOcorrido.Message);

            }
        }

    }
}
