using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LogCLS
    {
        ConnectionCLS objdal = new ConnectionCLS();

        public string GetCountId(string una, string pwd)
        {
            string str = "select count(Id) from Threelayer where Username ='" + una + "' and Password = '" + pwd + "'";
            string cid = objdal.Fn_Scalar(str);
            return cid;
        }

        public string GetId(string una, string pwd)
        {
            string str = "select ID from Threelayer where Username ='" + una + "' and Password = '" + pwd + "'";
            string cid = objdal.Fn_Scalar(str);
            return cid;
        }
    }
}
