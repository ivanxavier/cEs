using cEs.Domain.Interface.Repositories.Administrativo;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Administrativo;
using static cEs.Infra.Configuracoes.Geral;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;

namespace cEs.DataAccess.Administrativo
{
    public class UfRepository : IUfRepository
    {
        public DbConexao Conexao { get; set; }


        public UfRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        public bool Delete(Uf obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Uf Find(Uf obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(Uf obj)
        {
            throw new NotImplementedException();
        }

        public List<Uf> Search(Uf obj)
        {
            List<Uf> lstRet = new List<Uf>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Uf_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@unf_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.UfId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@unf_Nome",
                        Direction = ParameterDirection.Input,
                        Value = obj.Nome
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Uf item = new Uf
                            {
                                UfId = oDr["unf_Id"].ToString(),
                                Nome = oDr["unf_Nome"].ToString(),

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

        public bool Update(Uf obj)
        {
            throw new NotImplementedException();
        }
    }
}
