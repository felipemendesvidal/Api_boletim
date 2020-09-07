using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace boletimApi.context
{
    public class boletemContext
    {
        //criando contexto
        SqlConnection con = new SqlConnection();

        //construtor
        public boletemContext()
        {
            con.ConnectionString = @"Data Source=LAPTOP-1VLFSC9P\SQLEXPRESS;Initial Catalog=boletim;Integrated Security=True";
        }//end constructor

        //conectar
        public SqlConnection conectar(){

            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }//end conectar

        //desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }// end desconectar
    }//end class principal
}//end clas confi
