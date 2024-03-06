using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InsertCLS
    {
        ConnectionCLS objdal = new ConnectionCLS();
        public int insertFn(string na, int ag, string addr, string ph, string una, string pw)
        {
            string str = "insert into Threelayer values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pw + "')";
            int h = objdal.Fn_Nonquery(str);
            return h;
        }
    }
}
