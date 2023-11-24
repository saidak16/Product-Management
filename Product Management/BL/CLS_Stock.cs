using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Stock
    {
        public DataTable GetItems(string search)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            DataTable dt = new DataTable();
            
            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            dal.Open();
            dt = dal.SelectData("GetItems", param);
            dal.Close();
            return dt;
        }

        public DataTable GetStockStatuse()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("PRM_Stock_Statuse", null);
            dal.Close();
            return dt;
        }

        public int GetStockCount()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("GetStockCount", null);
            dal.Close();
            
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int GetTotalStockCount()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("GetTotalStockCount", null);
            dal.Close();

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int GetAvilableStockCount()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("GetAvilableStockCount", null);
            dal.Close();

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int GetEndStockCount()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("GetEndStockCount", null);
            dal.Close();

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public DataTable GetExpDateStore()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();

            dt = dal.SelectData("PRM_Stock_ExpDate", null);
            dal.Close();
            return dt;
        }
    }
}
