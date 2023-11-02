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
    public class CLS_Supplier_Profile
    {
        public DataTable GetSupplierById(int Id)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = Id;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetSupplierById", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public DataTable GetSupplierProducts(int supplierId)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplierId", SqlDbType.Int);
                param[0].Value = supplierId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetSupplierProducts", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetReturnPurchases(int supplerId)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplerId", SqlDbType.Int);
                param[0].Value = supplerId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetReturnPurchases", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetSupplierInvoices(int supplierId)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplierId", SqlDbType.Int);
                param[0].Value = supplierId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetSupplierInvoices", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetReturnPurchaseDetails(int orderId)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@orderId", SqlDbType.Int);
                param[0].Value = orderId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetReturnPurchaseDetails", param);
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
