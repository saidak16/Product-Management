using Product_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Setting
    {
        public DataTable GetSystemAlerts()
        {
            DataAccessLayer dal = new DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetSystemAlerts", null);
            dal.Close();
            return dt;
        }

        public bool UpdateSystemAlerts(int Qty, int ExpDays)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];
                dal.Open();

                param[0] = new SqlParameter("Qty", SqlDbType.Int);
                param[0].Value = Qty;

                param[1] = new SqlParameter("ExpDays", SqlDbType.Int);
                param[1].Value = ExpDays * -1;

                dal.ExCommand("UpdateSystemAlerts", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
