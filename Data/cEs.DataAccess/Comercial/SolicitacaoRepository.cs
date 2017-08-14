using cEs.Domain.Interface.Repositories.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using System.Data.SqlClient;
using static cEs.Infra.Configuracoes.Geral;
using Microsoft.Extensions.Options;
using System.Data;
using System.Linq;

namespace cEs.DataAccess.Comercial
{
    public class SolicitacaoRepository : ISolicitacaoRepository
    {
        public DbConexao Conexao { get; set; }


        public SolicitacaoRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }

        public bool Delete(Solicitacao obj)
        {
            Boolean retId = false;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Solicitacao_Delete";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Solicitacao Find(Solicitacao obj)
        {
            List<Solicitacao> lstMenu =
                Search(new Solicitacao() { SolicitacaoId = obj.SolicitacaoId}).ToList();

            return lstMenu.FirstOrDefault();
        }

        public long? Insert(Solicitacao obj)
        {
            Int64? retId = 0;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Solicitacao_Insert";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Nome",
                        Direction = ParameterDirection.Input,
                        Value = obj.Nome
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Endereco",
                        Direction = ParameterDirection.Input,
                        Value = obj.Endereco
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Numero",
                        Direction = ParameterDirection.Input,
                        Value = obj.Numero
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Complemento",
                        Direction = ParameterDirection.Input,
                        Value = obj.Complemento
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Bairro",
                        Direction = ParameterDirection.Input,
                        Value = obj.Bairro
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Municipio",
                        Direction = ParameterDirection.Input,
                        Value = obj.Municipio
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_UF",
                        Direction = ParameterDirection.Input,
                        Value = obj.UF
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Cep",
                        Direction = ParameterDirection.Input,
                        Value = obj.Cep
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Contato",
                        Direction = ParameterDirection.Input,
                        Value = obj.Contato
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Celular",
                        Direction = ParameterDirection.Input,
                        Value = obj.Celular
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Telefone",
                        Direction = ParameterDirection.Input,
                        Value = obj.Telefone
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Email",
                        Direction = ParameterDirection.Input,
                        Value = obj.Email
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Assunto",
                        Direction = ParameterDirection.Input,
                        Value = obj.Assunto
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Procurar",
                        Direction = ParameterDirection.Input,
                        Value = obj.Procurar
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sos_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoStatusId
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

        public List<Solicitacao> Search(Solicitacao obj)
        {
            List<Solicitacao> lstRet = new List<Solicitacao>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Solicitacao_Search";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Nome",
                        Direction = ParameterDirection.Input,
                        Value = obj.Nome
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Endereco",
                        Direction = ParameterDirection.Input,
                        Value = obj.Endereco
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Numero",
                        Direction = ParameterDirection.Input,
                        Value = obj.Numero
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Complemento",
                        Direction = ParameterDirection.Input,
                        Value = obj.Complemento
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Bairro",
                        Direction = ParameterDirection.Input,
                        Value = obj.Bairro
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Municipio",
                        Direction = ParameterDirection.Input,
                        Value = obj.Municipio
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_UF",
                        Direction = ParameterDirection.Input,
                        Value = obj.UF
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Cep",
                        Direction = ParameterDirection.Input,
                        Value = obj.Cep
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Contato",
                        Direction = ParameterDirection.Input,
                        Value = obj.Contato
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Celular",
                        Direction = ParameterDirection.Input,
                        Value = obj.Celular
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Telefone",
                        Direction = ParameterDirection.Input,
                        Value = obj.Telefone
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Email",
                        Direction = ParameterDirection.Input,
                        Value = obj.Email
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Assunto",
                        Direction = ParameterDirection.Input,
                        Value = obj.Assunto
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Procurar",
                        Direction = ParameterDirection.Input,
                        Value = obj.Procurar
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sos_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoStatusId
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Solicitacao item = new Solicitacao
                            {
                                SolicitacaoId = Convert.ToInt64(oDr["sol_Id"]),
                                Nome = oDr["sol_Nome"].ToString(),
                                Endereco = oDr["sol_Endereco"].ToString(),
                                Numero = Convert.ToInt32(oDr["sol_Numero"]),
                                Complemento = oDr["sol_Complemento"].ToString(),
                                Bairro = oDr["sol_Bairro"].ToString(),
                                Municipio = oDr["sol_Municipio"].ToString(),
                                UF = oDr["sol_UF"].ToString(),
                                Cep = oDr["sol_Cep"].ToString(),
                                Contato = oDr["sol_Contato"].ToString(),
                                Celular = oDr["sol_Celular"].ToString(),
                                Telefone = oDr["sol_Telefone"].ToString(),
                                Email = oDr["sol_Email"].ToString(),
                                Assunto = oDr["sol_Assunto"].ToString(),
                                Procurar = oDr["sol_Procurar"].ToString(),
                                SolicitacaoStatusId = oDr["sos_Id"].ToString(),
                                Data = Convert.ToDateTime(oDr["sol_Data"])
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


        public List<Solicitacao>Lista(Solicitacao obj)
        {
            List<Solicitacao> lstRet = new List<Solicitacao>();

            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Solicitacao_Lista";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoId ?? (object)DBNull.Value
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Nome",
                        Direction = ParameterDirection.Input,
                        Value = String.IsNullOrWhiteSpace(obj.Nome) ? (object)DBNull.Value : obj.Nome
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sos_Id",
                        Direction = ParameterDirection.Input,
                        Value = String.IsNullOrWhiteSpace(obj.SolicitacaoStatusId) ? (object)DBNull.Value : obj.SolicitacaoStatusId
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Data",
                        Direction = ParameterDirection.Input,
                        IsNullable = true,
                        Value = obj.Data ?? (object)DBNull.Value
                    });
                    #endregion

                    try
                    {
                        SqlDataReader oDr = oCommand.ExecuteReader();

                        while (oDr.Read())
                        {
                            Solicitacao item = new Solicitacao
                            {
                                SolicitacaoId = Convert.ToInt64(oDr["sol_Id"]),
                                Nome = oDr["sol_Nome"].ToString(),
                                Status = oDr["sos_Nome"].ToString(),
                                Data = Convert.ToDateTime(oDr["sol_Data"])
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



        public bool Update(Solicitacao obj)
        {
            Boolean retId = false;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Solicitacao_Update";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoId
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Nome",
                        Direction = ParameterDirection.Input,
                        Value = obj.Nome
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Endereco",
                        Direction = ParameterDirection.Input,
                        Value = obj.Endereco
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Numero",
                        Direction = ParameterDirection.Input,
                        Value = obj.Numero
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Complemento",
                        Direction = ParameterDirection.Input,
                        Value = obj.Complemento
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Bairro",
                        Direction = ParameterDirection.Input,
                        Value = obj.Bairro
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Municipio",
                        Direction = ParameterDirection.Input,
                        Value = obj.Municipio
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_UF",
                        Direction = ParameterDirection.Input,
                        Value = obj.UF
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Cep",
                        Direction = ParameterDirection.Input,
                        Value = obj.Cep
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Contato",
                        Direction = ParameterDirection.Input,
                        Value = obj.Contato
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Celular",
                        Direction = ParameterDirection.Input,
                        Value = obj.Celular
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Telefone",
                        Direction = ParameterDirection.Input,
                        Value = obj.Telefone
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Email",
                        Direction = ParameterDirection.Input,
                        Value = obj.Email
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Assunto",
                        Direction = ParameterDirection.Input,
                        Value = obj.Assunto
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sol_Procurar",
                        Direction = ParameterDirection.Input,
                        Value = obj.Procurar
                    });
                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@sos_Id",
                        Direction = ParameterDirection.Input,
                        Value = obj.SolicitacaoStatusId
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
