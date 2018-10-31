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
    public class AudPedidoStageNegocio
    {

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public AudPedidoStageColecao ConsultarCNPJ(string entraCNPJ, int entraPendencia, string entraLogin)
        {
            try
            {
                AudPedidoStageColecao audColecao = new AudPedidoStageColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CNPJ", entraCNPJ);
                acessoDados.AdicionarParametros("@Pendencia", entraPendencia);
                acessoDados.AdicionarParametros("@Login", entraLogin);


                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "procAuditoriaStage");

                foreach (DataRow datarow in dataTable.Rows)
                {
                    AudPedidoStageClass1 audStage = new AudPedidoStageClass1();

                    
                    audStage.CPF_CNPJ = Convert.ToString(datarow["CPF_CNPJ"]);
                    audStage.DataEnvio = Convert.ToString(datarow["DataEnvio"]);
                    audStage.Pedido = Convert.ToString(datarow["Pedido"]);
                    audStage.UF = Convert.ToString(datarow["UF"]);
                    audStage.particao = Convert.ToString(datarow["particao"]);
                    audStage.Atividade = Convert.ToString(datarow["Atividade"]);
                    audStage.DataInclusão = Convert.ToString(datarow["DataInclusão"]);
                    audStage.LoginAnalise = Convert.ToString(datarow["LoginAnalise"]);
                    audStage.Aprovado = Convert.ToString(datarow["Aprovado"]);
                    audStage.TipoNegociacao = Convert.ToString(datarow["TipoNegociacao"]);
                    audStage.Origem = Convert.ToString(datarow["Origem"]);
                    audStage.Canal = Convert.ToString(datarow["Canal"]);
                    audStage.NotasDDR = Convert.ToString(datarow["NotasDDR"]);
                    audStage.DescAnalise = Convert.ToString(datarow["DescAnalise"]);
                    audStage.Empresa = Convert.ToString(datarow["Empresa"]);
                    audStage.Ramo = Convert.ToString(datarow["Ramo"]);
                    audStage.NomeTBP = Convert.ToString(datarow["NomeTBP"]);
                    audStage.QuantAcessos = Convert.ToString(datarow["QuantAcessos"]);
                    audStage.QuantAparelhos = Convert.ToString(datarow["QuantAparelhos"]);
                    audStage.Vendedor = Convert.ToString(datarow["Vendedor"]);
                    audStage.CodigoTBP = Convert.ToString(datarow["CodigoTBP"]);
                    audStage.FraudeTBP = Convert.ToString(datarow["FraudeTBP"]);
                    audStage.Reanalise = Convert.ToString(datarow["Reanalise"]);
                    audStage.C3S = Convert.ToString(datarow["C3S"]);
                    audStage.ByPass = Convert.ToString(datarow["ByPass"]);
                    audStage.Portabilidade = Convert.ToString(datarow["Portabilidade"]);
                    audStage.Dossie = Convert.ToString(datarow["Dossie"]);
                    audStage.SocioAdmNaoValido = Convert.ToString(datarow["SocioAdmNaoValido"]);
                    audStage.TelefoneNaoExiste = Convert.ToString(datarow["TelefoneNaoExiste"]);
                    audStage.ClientePendencias = Convert.ToString(datarow["ClientePendencias"]);
                    audStage.RecenteAlteContratual = Convert.ToString(datarow["RecenteAlteContratual"]);
                    audStage.AsceConsultas = Convert.ToString(datarow["AsceConsultas"]);
                    audStage.EmpresaRecente = Convert.ToString(datarow["EmpresaRecente"]);
                    audStage.AcessosNaoCondiz = Convert.ToString(datarow["AcessosNaoCondiz"]);
                    audStage.TentativaVariosProdutos = Convert.ToString(datarow["TentativaVariosProdutos"]);
                    audStage.InatividadeComer = Convert.ToString(datarow["InatividadeComer"]);
                    audStage.DocumentoFalso = Convert.ToString(datarow["DocumentoFalso"]);
                    audStage.MotivoNegativa = Convert.ToString(datarow["MotivoNegativa"]);
                    audStage.idPendencia = Convert.ToString(datarow["idPendencia"]);
                    audStage.descPendencia = Convert.ToString(datarow["descPendencia"]);
                    audStage.ID = Convert.ToString(datarow["ID"]);

                    audColecao.Add(audStage);
                }
                return audColecao;
            }
            catch (Exception erroOcorrido)
            {
                throw new Exception("Erro: " + erroOcorrido.Message);

            }
        }

    }
}
