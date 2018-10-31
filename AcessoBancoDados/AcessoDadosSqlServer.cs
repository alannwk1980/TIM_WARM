using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //criar conexão

        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //parametros que vao para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void  LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
          

        }

        // Persistencia de dados Iserir Alterar Excluir

        public object ExecutarManipulacao(CommandType commandType, string nomeProcedureOuTextoSql)
        {
            try
            {
                //criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abrir
                sqlConnection.Open();
                //Criar comando sql
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas debtro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 60; // segundos

                //Adicionar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }

                //Executar comando
                return sqlCommand.ExecuteScalar();
            }
            catch(Exception ex)
                {
                throw new Exception(ex.Message);
                }
        }

        // consulta registros do Banco de dados

        public DataTable ExecutarConsulta(CommandType commandType, string nomeProcedureOuTextoSql)
        {
            try
            { 
                //criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abrir
                sqlConnection.Open();
                //Criar comando sql
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas debtro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 60; // segundos

                //Adicionar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }

                // criar adaptador

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                // criar tabela vazia
                DataTable dataTable = new DataTable();
                // executar comando e preeencher dados
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }





    }
}
