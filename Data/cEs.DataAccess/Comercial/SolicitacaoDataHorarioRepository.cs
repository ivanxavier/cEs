using cEs.Domain.Interface.Repositories.Comercial;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using static cEs.Infra.Configuracoes.Geral;
using cEs.Domain.Entities.Comercial;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace cEs.DataAccess.Comercial
{
    public class SolicitacaoDataHorarioRepository: ISolicitacaoDataHorarioRepository
    {
        public DbConexao Conexao { get; set; }


        public SolicitacaoDataHorarioRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        public long? Insert(SolicitacaoDataHorario obj)
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
                        ParameterName = "@soh_Inicio",
                        Direction = ParameterDirection.Input,
                        Value = obj.Inicio
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Termino",
                        Direction = ParameterDirection.Input,
                        Value = obj.Termino
                    });
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

        public SolicitacaoDataHorario Find(SolicitacaoDataHorario obj)
        {
            List<SolicitacaoDataHorario> lstMenu =
                Search(new SolicitacaoDataHorario() { SolicitacaoDataHorarioId = obj.SolicitacaoDataHorarioId }).ToList();

            return lstMenu.FirstOrDefault();
        }

        public List<SolicitacaoDataHorario> Search(SolicitacaoDataHorario obj)
        {
            List<SolicitacaoDataHorario> lstRet = new List<SolicitacaoDataHorario>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoDataHorario_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataHorarioId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Inicio",
                        Direction = ParameterDirection.Input,
                        Value = obj.Inicio
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Termino",
                        Direction = ParameterDirection.Input,
                        Value = obj.Termino
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sod_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataId
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            SolicitacaoDataHorario item = new SolicitacaoDataHorario
                            {
                                SolicitacaoDataHorarioId = Convert.ToInt64(oDr["soh_Id"]),
                                Inicio = oDr["soh_Inicio"].ToString(),
                                Termino = oDr["soh_Termino"].ToString(),
                                SolicitacaoDataId = Convert.ToInt64(oDr["sod_Id"]),
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

        public bool Update(SolicitacaoDataHorario obj)
        {
            Boolean retId = false;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoDataHorario_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataHorarioId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Inicio",
                        Direction = ParameterDirection.Input,
                        Value = obj.Inicio
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Termino",
                        Direction = ParameterDirection.Input,
                        Value = obj.Termino
                    });
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

        public bool Delete(SolicitacaoDataHorario obj)
        {
            Boolean retId = false;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_SolicitacaoDataHorario_Delete";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@soh_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoDataHorarioId
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
    }
}
