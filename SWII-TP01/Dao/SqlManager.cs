using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SWII_TP01.Dao {

    
    class SqlManager {
        private SqlConnection con;
        private String query;

        public SqlManager() {
            String connectionString = @"Data Source=DESKTOP-NI88ARN;Initial Catalog=sw2tp01;Integrated Security=True";
            this.con = new SqlConnection(connectionString);
            con.Open();
        }

        public void closeCon() {
            con.Close();
        }

        public void insert(Model.Book book) {
            String query = "INSERT INTO author(name, email, gender) VALUES(@name, @email, @gender)";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.Add(new SqlParameter("@name","teste"));
            comando.Parameters.Add(new SqlParameter("@email", "teste1"));
            comando.Parameters.Add(new SqlParameter("@gender", "m"));
            comando.ExecuteNonQuery();
        }
        public void update(Model.Book book) {
            String query = "UPDATE author(name, email, gender) VALUES(@name, @email, @gender)";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.Add(new SqlParameter("@name", "teste"));
            comando.Parameters.Add(new SqlParameter("@email", "teste1"));
            comando.Parameters.Add(new SqlParameter("@gender", "m"));
            comando.ExecuteNonQuery();
        }
        public void delete() {
            String query = "DELETE FROM sw2tp01 WHERE id = @id;";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.Add(new SqlParameter("@id", "id"));
            comando.ExecuteNonQuery();
        }
        public void getByName() {
            String query = "SELECT FROM sw2tp01 WHERE id = @id;";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.Add(new SqlParameter("@id", "id"));
            comando.ExecuteReader();
        }

    }
}
