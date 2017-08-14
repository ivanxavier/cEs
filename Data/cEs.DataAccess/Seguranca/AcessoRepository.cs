using System;
using System.Collections.Generic;
using cEs.Domain.Entities.Seguranca;
using cEs.Domain.Entities.Administrativo;
using cEs.Domain.Interface.Repositories.Seguranca;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Options;
using static cEs.Infra.Configuracoes.Geral;

namespace cEs.DataAccess.Seguranca
{
    public class AcessoRepository : IAcessoRepository
    {
        public DbConexao Conexao { get; set; }

        public AcessoRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        //public bool Delete(Acesso obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public Acesso Find(Acesso obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public long? Insert(Acesso obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Acesso> Login(Acesso obj)
        //{
        //    List<Acesso> lstRet = new List<Acesso>();

        //    using (SqlConnection oConnection = new SqlConnection(ConnectionString))
        //    {
        //        oConnection.Open();

        //        using (SqlCommand oCommand = oConnection.CreateCommand())
        //        {
        //            oCommand.CommandText = Owner + "usp_Acesso_Login";
        //            oCommand.CommandType = CommandType.StoredProcedure;

        //            #region --- Parâmetros ---

        //            oCommand.Parameters.Clear();

        //            oCommand.Parameters.Add(new SqlParameter()
        //            {
        //                ParameterName = "@acs_Login",
        //                Direction = ParameterDirection.Input,
        //                IsNullable = true,
        //                Value = String.IsNullOrWhiteSpace(obj.Login) ? (object)DBNull.Value : obj.Login
        //            });

        //            oCommand.Parameters.Add(new SqlParameter()
        //            {
        //                ParameterName = "@acs_Senha",
        //                Direction = ParameterDirection.Input,
        //                IsNullable = true,
        //                Value = String.IsNullOrWhiteSpace(obj.Senha) ? (object)DBNull.Value : obj.Senha
        //            });

        //            #endregion

        //            try
        //            {
        //                SqlDataReader oDr = oCommand.ExecuteReader();

        //                while (oDr.Read())
        //                {
        //                    Acesso item = new Acesso
        //                    {
        //                        AcessoId = Convert.ToInt64(oDr["acs_Id"])
        //                    };

        //                    if (!oDr.IsDBNull(oDr.GetOrdinal("acs_Id"))) // tb_Acesso
        //                    {
        //                        item.Usuario = new List<Usuario>(){
        //                            new Usuario()
        //                            {
        //                                UsuarioId = Convert.ToInt64(oDr["usr_Id"]),
        //                                Nome = oDr["usr_Nome"].ToString(),
        //                                Email = oDr["usr_Email"].ToString(),
        //                                TelefoneNumero = oDr["usr_Celular_Numero"].ToString(),
        //                                TelefoneDDD = oDr["usr_Celular_DDD"].ToString()
        //                            }};


        //                        item.Empresa = new List<Empresa>(){
        //                            new Empresa()
        //                            {
        //                                EmpresaId = Convert.ToInt64(oDr["emp_Id"]),
        //                                Nome = oDr["emp_Nome"].ToString(),
        //                    }};
        //                    }
        //                    lstRet.Add(item);
        //                }
        //            }
        //            catch (SqlException se)
        //            {
        //                throw new cEsSqlServerException(GetType().FullName + "." + MethodBase.GetCurrentMethod().Name, se);
        //            }
        //            catch (Exception e)
        //            {
        //                throw new cEsException(GetType().FullName + "." + MethodBase.GetCurrentMethod().Name, e);
        //            }
        //        }

        //        oConnection.Close();
        //    }

        //    return lstRet;
        //}

        //public List<Acesso> Search(Acesso obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Update(Acesso obj)
        //{
        //    throw new NotImplementedException();
        //}
        public bool Delete(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Acesso Find(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public List<Acesso> Login(Acesso obj)
        {
            List<Acesso> lstRet = new List<Acesso>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Acesso_Login";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---

                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@anu_Id",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        Value = String.IsNullOrWhiteSpace(obj.AspNetUser) ? (object)DBNull.Value : obj.AspNetUser
                    });

                    #endregion
                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Acesso item = new Acesso
                            {
                                AcessoId = Convert.ToInt64(oDr["acs_Id"]),
                                Ativo = Convert.ToBoolean(oDr["acs_Ativo"]),
                                PerfilTipoId = Convert.ToInt64(oDr["ptp_Id"]),
                                UsuarioId = Convert.ToInt64(oDr["usr_Id"]),
                                EmpresaId = Convert.ToInt64(oDr["emp_Id"]),
                                Empresa = oDr["emp_Nome"].ToString(),
                                Email = oDr["usr_Email"].ToString(),
                                CelularDDD = oDr["usr_Celular_DDD"].ToString(),
                                CelularNumero = oDr["usr_Celular_Numero"].ToString(),
                                Nome = oDr["usr_Nome"].ToString(),
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

                    oConnection.Close();
                }
            }
            return lstRet;
        }

        public List<Acesso> Search(Acesso obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Acesso obj)
        {
            throw new NotImplementedException();
        }
    }
}