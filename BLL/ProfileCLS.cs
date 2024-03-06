using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class ProfileCLS
    {
        ConnectionCLS objdal = new ConnectionCLS();
        public SqlDataReader fun_GetData(int id)
        {
            string strsel = "select name, age, address, photo from Threelayer where id=" + id + "";
            SqlDataReader dr = objdal.Fn_DataReader(strsel);
            return dr;
        }

        public DataSet fun_GetData_Dataset(int id)
        {
            string strsel = "select name, age, address, photo from Threelayer where id=" + id + "";
            DataSet ds = objdal.Fn_DataAdapter(strsel);
            return ds;
        }
    }
}
