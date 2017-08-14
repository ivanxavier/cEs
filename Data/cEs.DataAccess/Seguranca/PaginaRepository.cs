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
    public class PaginaRepository: IPaginaRepository
    {
        public DbConexao Conexao { get; set; }


        public PaginaRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        #region Implementation of IRepositoryBase<Pagina>

        public long? Insert(Pagina obj)
        {
            throw new NotImplementedException();
        }

        public Pagina Find(Pagina obj)
        {
            throw new NotImplementedException();
        }

        public List<Pagina> Search(Pagina obj)
        {
            List<Pagina> lista = new List<Pagina>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Pagina_Menu_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    //oCommand.Parameters.Add(new SqlParameter()
                    //{
                    //    ParameterName = "@pag_Id",
                    //    Direction = ParameterDirection.Input,
                    //    IsNullable = true,
                    //    SqlValue = obj.PaginaId ?? (object)DBNull.Value
                    //});

                    //oCommand.Parameters.Add(new SqlParameter()
                    //{
                    //    ParameterName = "@pag_Nome",
                    //    Direction = ParameterDirection.Input,
                    //    IsNullable = true,
                    //    Value = String.IsNullOrWhiteSpace(obj.Nome) ? (object)DBNull.Value : obj.Nome
                    //});

                    //oCommand.Parameters.Add(new SqlParameter()
                    //{
                    //    ParameterName = "@pag_Icone",
                    //    Direction = ParameterDirection.Input,
                    //    IsNullable = true,
                    //    Value = String.IsNullOrWhiteSpace(obj.Icone) ? (object)DBNull.Value : obj.Icone
                    //});

                    //oCommand.Parameters.Add(new SqlParameter()
                    //{
                    //    ParameterName = "@pag_ordem",
                    //    Direction = ParameterDirection.Input,
                    //    IsNullable = true,
                    //    SqlValue = obj.Ordem ?? (object)DBNull.Value
                    //});


                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            //Pagina item = new Pagina
                            //{
                            //    PaginaId = Convert.ToInt64(oDr["pag_Id"]),
                            //    Nome = oDr["pag_Nome"].ToString(),
                            //    Icone = oDr["pag_Icone"].ToString(),
                            //    Ordem = Convert.ToInt32(oDr["pag_Ordem"]),
                            //};
                            //lista.Add(item);
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

        public bool Update(Pagina obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Pagina obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Pagina> UsuarioPagina(Acesso obj, Menu objMenu)
        {
            List<Pagina> lstPagina = new List<Pagina>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Usuario_Pagina";
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

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@pag_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        SqlValue = objMenu.MenuId ?? (object)DBNull.Value
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Pagina item = new Pagina
                            {
                                PaginaId = Convert.ToInt64(oDr["pag_Id"]),
                                Nome = oDr["pag_Nome"].ToString(),
                                Url = oDr["pag_Url"].ToString(),
                                Icone = oDr["pag_Icone"].ToString(),
                                //IconeMiniatura = oDr["pag_IconeMiniatura"].ToString(),
                                //Servico = Convert.ToBoolean(oDr["pag_Servico"])
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

    #endregion
}

