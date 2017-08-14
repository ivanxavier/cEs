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
    public class MenuRepository : IMenuRepository
    {

        public DbConexao Conexao { get; set; }


        public MenuRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        public bool Delete(Menu obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Menu Find(Menu obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(Menu obj)
        {
            throw new NotImplementedException();
        }

        public List<Menu> Search(Menu obj)
        {
            List<Menu> lista = new List<Menu>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Menu_Search";
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
                        ParameterName = "@mnu_Nome",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        Value = String.IsNullOrWhiteSpace(obj.Nome) ? (object)DBNull.Value : obj.Nome
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@mnu_Icone",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        Value = String.IsNullOrWhiteSpace(obj.Icone) ? (object)DBNull.Value : obj.Icone
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@mnu_ordem",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = obj.Ordem ?? (object)DBNull.Value
                    });


                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Menu item = new Menu
                            {
                                MenuId = Convert.ToInt64(oDr["mnu_Id"]),
                                Nome = oDr["mnu_Nome"].ToString(),
                                Icone = oDr["mnu_Icone"].ToString(),
                                Ordem = Convert.ToInt32(oDr["mnu_Ordem"]),
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

        public bool Update(Menu obj)
        {
            throw new NotImplementedException();
        }

        public List<Menu> UsuarioMenu(Acesso obj)
        {
            List<Menu> lstPagina = new List<Menu>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Usuario_Menu";
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
                            Menu item = new Menu
                            {
                                MenuId = Convert.ToInt64(oDr["mnu_Id"]),
                                Nome = oDr["mnu_Nome"].ToString(),
                                Icone = oDr["mnu_Icone"].ToString(),
                            };
                            lstPagina.Add(item);
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

            return lstPagina;
        }

    }
}
