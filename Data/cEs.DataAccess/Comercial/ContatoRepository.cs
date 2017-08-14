using cEs.Domain.Interface.Repositories.Comercial;
using System;
using System.Collections.Generic;
using System.Text;
using cEs.Domain.Entities.Comercial;
using System.Data.SqlClient;
using System.Data;
using static cEs.Infra.Configuracoes.Geral;
using Microsoft.Extensions.Options;

namespace cEs.DataAccess.Comercial
{
    public class ContatoRepository : IContatoRepository
    {
        public DbConexao Conexao { get; set; }


        public ContatoRepository(IOptions<DbConexao> conexao)
        {
            this.Conexao = conexao.Value;
        }
        public bool Delete(Contato obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Contato Find(Contato obj)
        {
            throw new NotImplementedException();
        }

        public long? Insert(Contato obj)
        {
            Int64? retId = 0;
            using (SqlConnection oConnection = new SqlConnection(Conexao.DefaultConnection))
            {
                oConnection.Open();

                using (SqlCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = Conexao.Owner + "usp_Contato_Insert";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    #region --- Parâmetros ---
                    oCommand.Parameters.Clear();

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@con_Nome",
                        Direction = ParameterDirection.Input,
                        Value = obj.Nome
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@con_Celular",
                        Direction = ParameterDirection.Input,
                        Value = obj.Celular
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@con_Telefone",
                        Direction = ParameterDirection.Input,
                        Value = obj.Telefone
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@con_Email",
                        Direction = ParameterDirection.Input,
                        Value = obj.Email
                    });

                    oCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@con_Mensagem",
                        Direction = ParameterDirection.Input,
                        Value = obj.Mensagem
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

        public List<Contato> Search(Contato obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contato obj)
        {
            throw new NotImplementedException();
        }

    }
}
