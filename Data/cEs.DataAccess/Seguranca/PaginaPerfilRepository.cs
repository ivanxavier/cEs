using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using static cEs.Infra.Configuracoes.Geral;

namespace cEs.DataAccess.Seguranca
{
    public class PaginaPerfilRepository: IPaginaPerfilRepository
    {
        public DbConexao Conexao { get; set; }


        public PaginaPerfilRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        #region Implementation of IRepositoryBase<PaginaPerfil>

        public long? Insert(PaginaPerfil obj)
        {
            throw new NotImplementedException();
        }

        public PaginaPerfil Find(PaginaPerfil obj)
        {
            throw new NotImplementedException();
        }

        public List<PaginaPerfil> Search(PaginaPerfil obj)
        {
            List<PaginaPerfil> lista = new List<PaginaPerfil>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Pagina_Perfil_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@pgp_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.PaginaPerfilId ?? (object)DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@mnu_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.MenuId ?? (object)DBNull.Value
                    });


                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@pag_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.PaginaId ?? (object)DBNull.Value
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
                            PaginaPerfil item = new PaginaPerfil
                            {
                                PaginaPerfilId = Convert.ToInt64(oDr["pgp_Id"]),
                                MenuId = Convert.ToInt64(oDr["mnu_Id"]),
                                PaginaId = Convert.ToInt64(oDr["pag_Id"]),
                                PerfilId = Convert.ToInt64(oDr["per_Id"]),
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

        public bool Update(PaginaPerfil obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PaginaPerfil obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<PaginaPerfilDisponivel> ListarDisponivel(PaginaPerfil obj)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
