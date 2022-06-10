using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Stock
    {
        public DataTable GetStockStatuse()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("PRM_Stock_Statuse", null);
            dal.Close();
            return dt;
        }
    }
}
