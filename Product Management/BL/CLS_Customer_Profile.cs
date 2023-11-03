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
    public class CLS_Customer_Profile
    {
        public DataTable GetCustomerInfo(int customerId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                dal.Open();

                param[0] = new SqlParameter("@customerId", SqlDbType.Int);
                param[0].Value = customerId;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetCustomerInfo", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
