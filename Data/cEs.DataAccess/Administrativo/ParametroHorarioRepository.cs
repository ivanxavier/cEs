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
    public class ParametroHorarioRepository : IParametroHorarioRepository
    {
        public DbConexao Conexao { get; set; }


        public ParametroHorarioRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        public bool Delete(ParametroHorario obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ParametroHorario Find(ParametroHorario obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(ParametroHorario obj)
        {
            throw new NotImplementedException();
        }

        public List<ParametroHorario> Search(ParametroHorario obj)
        {
            List<ParametroHorario> lstRet = new List<ParametroHorario>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_ParametroHorario_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@pho_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.ParametroHorarioId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@pho_Horario",
                        Direction = ParameterDirection.Input,
                        Value = obj.Horario
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            ParametroHorario item = new ParametroHorario
                            {
                                ParametroHorarioId = Convert.ToInt64(oDr["pho_Id"]),
                                Horario = oDr["pho_Nome"].ToString(),
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

        public bool Update(ParametroHorario obj)
        {
            throw new NotImplementedException();
        }
    }
}
