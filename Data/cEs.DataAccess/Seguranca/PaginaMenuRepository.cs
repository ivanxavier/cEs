using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Interface.Repositories.Seguranca;
using cEs.Infra.Configuracoes.Data;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static cEs.Infra.Configuracoes.Geral;

namespace cEs.DataAccess.Seguranca
{
    public class PaginaMenuRepository : IPaginaMenuRepository
    {

        public DbConexao Conexao { get; set; }


        public PaginaMenuRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        public bool Delete(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public PaginaMenu Find(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public List<PaginaMenuDisponivel> ListarDisponivel(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }

        public List<PaginaMenu> Pesquisa(PaginaMenu obj)
        {
            List<PaginaMenu> lista = new List<PaginaMenu>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Pagina_Menu_Pesquisa";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();


                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@acs_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.AcessoId ?? (object)DBNull.Value
                    });

                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            PaginaMenu item = new PaginaMenu
                            {
                                MenuId = Convert.ToInt64(oDr["mnu_Id"]),
                                PaginaIdPai = oDr.IsDBNull(oDr.GetOrdinal("pag_IdPai")) ? null : (Int64?)Convert.ToInt64(oDr["pag_IdPai"]),
                                PaginaId = Convert.ToInt64(oDr["pag_Id"]),
                                Pagina = oDr["pag_Nome"].ToString(),
                                PaginaPai = oDr["pag_NomePai"].ToString(),
                                Menu = oDr["mnu_Nome"].ToString(),
                                AcessoId = oDr.IsDBNull(oDr.GetOrdinal("acs_Id")) ? null : (Int64?)Convert.ToInt64(oDr["acs_Id"]),
                                Action = oDr["pag_Action"].ToString(),
                                Controller = oDr["pag_Controller"].ToString(),
                                Tipo = oDr["mnu_Tipo"].ToString(),
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

        public List<PaginaMenu> Search(PaginaMenu obj)
        {
            List<PaginaMenu> lista = new List<PaginaMenu>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Pagina_Menu_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();


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
                        SqlValue = obj.MenuId ?? (object)DBNull.Value
                    });

                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            PaginaMenu item = new PaginaMenu
                            {
                                MenuId = Convert.ToInt64(oDr["mnu_Id"]),
                                PaginaId = Convert.ToInt64(oDr["pag_Id"]),
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

        public bool Update(PaginaMenu obj)
        {
            throw new NotImplementedException();
        }
    }
}
