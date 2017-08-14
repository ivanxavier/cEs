using cEs.Domain.Interface.Repositories.Comercial;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using static cEs.Infra.Configuracoes.Geral;
using cEs.Domain.Entities.Comercial;
using System.Data.SqlClient;
using System.Data;

namespace cEs.DataAccess.Comercial
{
    public class SolicitacaoStatusRepository: ISolicitacaoStatusRepository
    {
        public DbConexao Conexao { get; set; }


        public SolicitacaoStatusRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        public long? Insert(SolicitacaoStatus obj)
        {
            throw new NotImplementedException();
        }

        public SolicitacaoStatus Find(SolicitacaoStatus obj)
        {
            throw new NotImplementedException();
        }

        public List<SolicitacaoStatus> Search(SolicitacaoStatus obj)
        {
            List<SolicitacaoStatus> lstRet = new List<SolicitacaoStatus>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Solicitacao_Status_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sos_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoStatusId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sos_Nome",
                        Direction = ParameterDirection.Input,
                        Value = obj.Nome
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            SolicitacaoStatus item = new SolicitacaoStatus
                            {
                                SolicitacaoStatusId = oDr["sos_Id"].ToString(),
                                Nome = oDr["sos_Nome"].ToString(),
                            };

                            lstRet.Add(item);
                        }
                    }
                    catch (SqlException ex) when (ex.Server == ".\\SQLEXPRESS")
                    {
                        Console.WriteLine("SQL Provider Error: " + ex.Message);
                    }
                    catch (Exception ex) when (ex.InnerException.ToString() == "Parameter Error")
                    {
                        Console.WriteLine("SQL Provider Error: " + ex.Message);
                    }
                }

                oConnection.Close();
            }
            return lstRet;
        }

        public bool Update(SolicitacaoStatus obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SolicitacaoStatus obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
