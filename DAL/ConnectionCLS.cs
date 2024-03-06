using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionCLS
    {
        SqlConnection con;//created an object for sqlConnection; this object of class is used everywhere so to make it accessable to everything we write it inside class
        SqlCommand cmd;//created an object for SqlCommand
        //we declared them as 2 variables
        public ConnectionCLS()//we created constructor for class; now we can write connection string inside it
        {
            //advantage of adding connection string inside constrector is : when an object is created the connnection's object will automatically come
            con = new SqlConnection(@"server=MSI\SQLEXPRESS;database=adoDB;Integrated Security=true;");
        }


        //🚩CONNECTED MODE

        //for executing NonQuery👇
        public int Fn_Nonquery(string sqlquery)//insert,delete,update
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        //for executing scalar 👇
        public string Fn_Scalar(string sqlquery)//aggreate functions/scalar functions
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
        //for executing reader👇
        public SqlDataReader Fn_DataReader(string sqlquery)//select
        {
            if (con.State == ConnectionState.Open)//we are not closing connection here so we have to put this`if`in every function to stop more than 1 open connection error
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        //🚩DISCONNECTED MODE

        public DataSet Fn_DataAdapter(string sqlquery)//select
        {
            if (con.State == ConnectionState.Open)//we are not closing connection here so we have to put this`if`in every function to stop more than 1 open connection error
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
