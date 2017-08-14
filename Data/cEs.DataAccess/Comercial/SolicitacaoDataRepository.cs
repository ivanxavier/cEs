using cEs.Domain.Interface.Repositories.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using static cEs.Infra.Configuracoes.Geral;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace cEs.DataAccess.Comercial
{
    public class SolicitacaoDataRepository : ISolicitacaoDataRepository
    {
        public DbConexao Conexao { get; set; }


        public SolicitacaoDataRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        public bool Delete(SolicitacaoData obj)
        {
            Boolean retId = false;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoData_Delete";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@return",
                        Direction = ParameterDirection.ReturnValue
                    });

                    #endregion

                    try
                    {
                        oCommand.ExecuteNonQuery();

                        retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
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


            return retId;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SolicitacaoData Find(SolicitacaoData obj)
        {
            List<SolicitacaoData> lstMenu =
                Search(new SolicitacaoData() { SolicitacaoDataId = obj.SolicitacaoDataId }).ToList();

            return lstMenu.FirstOrDefault();
        }

        public long? Insert(SolicitacaoData obj)
        {
            Int64? retId = 0;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoDataHorario_Insert";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Data",
                        Direction = ParameterDirection.Input,
                        Value = obj.Data
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@return",
                        Direction = ParameterDirection.ReturnValue
                    });

                    #endregion

                    try
                    {
                        oCommand.ExecuteNonQuery();

                        retId = Convert.ToInt64(oCommand.Parameters["@return"].Value);
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


            return retId;
        }

        public List<SolicitacaoData> Search(SolicitacaoData obj)
        {
            List<SolicitacaoData> lstRet = new List<SolicitacaoData>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoData_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Data",
                        Direction = ParameterDirection.Input,
                        Value = obj.Data
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoId
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            SolicitacaoData item = new SolicitacaoData
                            {
                                SolicitacaoDataId = Convert.ToInt64(oDr["sod_Id"]),
                                Data = Convert.ToDateTime(oDr["sod_Data"]),
                                SolicitacaoId = Convert.ToInt64(oDr["sol_Id"]),
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

        public bool Update(SolicitacaoData obj)
        {
            Boolean retId = false;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoData_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Data",
                        Direction = ParameterDirection.Input,
                        Value = obj.Data
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@return",
                        Direction = ParameterDirection.ReturnValue
                    });

                    #endregion

                    try
                    {
                        oCommand.ExecuteNonQuery();

                        retId = Convert.ToBoolean(oCommand.Parameters["@return"].Value);
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


            return retId;
        }
    }
}
