using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static cEs.Infra.Configuracoes.Geral;

namespace cEs.DataAccess.Seguranca
{
    public class PerfilRepository: IPerfilRepository
    {
        public DbConexao Conexao { get; set; }


        public PerfilRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        #region Implementation of IRepositoryBase<Perfil>

        public long? Insert(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public Perfil Find(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public List<Perfil> Search(Perfil obj)
        {
            List<Perfil> lista = new List<Perfil>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Perfil_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@per_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.PerfilId ?? (object)DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@per_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.PerfilId ?? (object)DBNull.Value
                    });

                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Perfil item = new Perfil
                            {
                                PerfilId = Convert.ToInt64(oDr["per_Id"]),
                                Nome = oDr["per_Nome"].ToString(),
                            };
                            lista.Add(item);
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

            return lista;
        }

        public bool Update(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Perfil obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
