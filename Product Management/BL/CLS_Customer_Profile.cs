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
        
        public DataTable GetCustomerReturnOrder(int customerId, string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                dal.Open();

                param[0] = new SqlParameter("@customerId", SqlDbType.Int);
                param[0].Value = customerId;
                
                param[1] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[1].Value = customerId;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetCustomerReturnOrder", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
       
        public DataTable GetOrderInstallment(int orderId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                dal.Open();

                param[0] = new SqlParameter("@orderId", SqlDbType.Int);
                param[0].Value = orderId;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetOrderInstallment", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetCustomerInvoices(int customerId, string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                dal.Open();

                param[0] = new SqlParameter("@customerId", SqlDbType.Int);
                param[0].Value = customerId;
                
                param[1] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[1].Value = search;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetCustomerInvoices", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetOrderReturnItems(int orderId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                dal.Open();

                param[0] = new SqlParameter("@orderId", SqlDbType.Int);
                param[0].Value = orderId;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetOrderReturnItems", param);
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
