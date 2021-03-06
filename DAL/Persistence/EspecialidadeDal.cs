﻿using System;
using MySql.Data.MySqlClient;
using BLL.Model;
using System.Collections.Generic;
namespace DAL.Persistence
{
    public class EspecialidadeDal : Conexao
    {


        public void Salvar(Especialidade especialidade)
        {
            try
            {
                
                var sql = "INSERT INTO especialidade(descricao, dtCadastro)" +
                          "VALUES(@descricao, CURRENT_TIMESTAMP())";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@descricao", especialidade.Descricao);

                command.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }
            finally
            {
                
            }
        }

        public List<Especialidade> Listar()
        {
            try
            {
                
                var sql = "SELECT * FROM especialidade";
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                List<Especialidade> listaespecialidade = new List<Especialidade>();

                while (dataReader.Read())
                {
                    Especialidade especialidade = new Especialidade();

                    especialidade.Id = Convert.ToInt32(dataReader["id"]);
                    especialidade.Descricao = dataReader["descricao"].ToString();


                    listaespecialidade.Add(especialidade);
                }

                //listaespecialidade.Sort();

                return listaespecialidade;

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }
            finally
            {
                
            }
        }


        public EspecialidadeDal()
        {
        }
    }
}
