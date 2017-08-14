using System;
using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Options;
using static cEs.Infra.Configuracoes.Geral;

namespace cEs.DataAccess.Seguranca
{
    public class PerfilTipoRepository: IPerfilTipoRepository
    {
        public DbConexao Conexao { get; set; }

        public PerfilTipoRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        #region Implementation of IRepositoryBase<PerfilTipo>

        public long? Insert(PerfilTipo obj)
        {
            throw new NotImplementedException();
        }

        public PerfilTipo Find(PerfilTipo obj)
        {
            throw new NotImplementedException();
        }

        public List<PerfilTipo> Search(PerfilTipo obj)
        {
            List<PerfilTipo> lista = new List<PerfilTipo>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Perfil_Tipo_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ptp_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.PerfilTipoId ?? (object)DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@per_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.PerfilId ?? (object)DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@utp_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.UsuarioTipoId ?? (object)DBNull.Value
                    });


                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            PerfilTipo item = new PerfilTipo
                            {
                                PerfilTipoId = Convert.ToInt64(oDr["ptp_Id"]),
                                PerfilId = Convert.ToInt64(oDr["per_Id"]),
                                UsuarioTipoId = Convert.ToInt64(oDr["utp_Id"]),
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

        public bool Update(PerfilTipo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PerfilTipo obj)
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
