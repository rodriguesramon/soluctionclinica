﻿using System;
using MySql.Data.MySqlClient;
using BLL.Model;
using System.Collections.Generic;

namespace DAL.Persistence
{
    public class EstadoDal : Conexao
    {
        public void Salvar(Estado estado){
            try{
               
                var sql = "INSERT INTO estado(nome, sigla, dtCadastro)"+
                          "VALUES(@nome, @sigla, CURRENT_TIMESTAMP())";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nome", estado.Nome );
                command.Parameters.AddWithValue("@sigla",estado.Sigla);
                command.ExecuteNonQuery();
            }
            catch(Exception erro){
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }finally{

            }
        }

        public List<Estado> ListarPorNome(string nome)
        {
            try
            {
                var sql = "SELECT * FROM estado WHERE nome LIKE  '%" + nome + "%'  ";
                command = new MySqlCommand(sql, connection);

                dataReader = command.ExecuteReader();

                List<Estado> listaEstado = new List<Estado>();

                while (dataReader.Read())
                {
                    Estado estado = new Estado();

                    estado.Id = Convert.ToInt32(dataReader["id"]);
                    estado.Nome = dataReader["nome"].ToString();
                    estado.Sigla = dataReader["sigla"].ToString();

                    listaEstado.Add(estado);
                }

                //listaEstado.Sort();

                return listaEstado;

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }
            finally
            {

            }
        }

        public List<Estado> Listar(){
            try{

                var sql = "SELECT * FROM estado";
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                List<Estado> listaEstado = new List<Estado>();

                while(dataReader.Read()){
                    Estado estado = new Estado();

                    estado.Id    =  Convert.ToInt32(dataReader["id"]);
                    estado.Nome  =  dataReader["nome"].ToString();
                    estado.Sigla =  dataReader["sigla"].ToString();

                    listaEstado.Add(estado);
                }

                //listaEstado.Sort();

                return listaEstado;

            }catch (Exception erro){
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }finally{

            }
        }


        public Estado PesquisarPorId(int id)
        {
            try
            {
                var sql = "SELECT * FROM estado WHERE id = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                dataReader = command.ExecuteReader();

                Estado estado = new Estado();

                if (dataReader.Read())
                {
                    estado.Id = Convert.ToInt32(dataReader["id"]);
                    estado.Nome = dataReader["nome"].ToString();
                    estado.Sigla = dataReader["sigla"].ToString();
                }
                return estado;
            }catch (Exception erro){
                throw new Exception("Erro ao consultar dado " + erro.ToString());
            }finally{
            }
        }



        public EstadoDal()
        {

        }
      
    }
}
