using Product_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Reporting
    {
        public DataTable GetPriceList()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPriceList", null);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

         public string GetStockValue()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetStockValue", null);
                dal.Close();

                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetStockStatusRpt()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetStockStatusRpt", null);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public DataTable GetStockStatus(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                DataTable dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                dt = dal.SelectData("GetStockStatus", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public DataTable SearchPriceList(string search)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("SearchPriceList", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                //if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                //    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                //string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                //File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
                return null;
            }
        }

        public DataTable GetMovementOfItemsDetails(int productId)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@productId", SqlDbType.Int);
                param[0].Value = productId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetMovementOfItemsDetails", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                //if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                //    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                //string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                //File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
                return null;
            }
        }

        public DataTable GetMovementOfItems(string search)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@seaarch", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetMovementOfItems", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                //if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                //    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                //string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                //File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
                return null;
            }
        }
    }
}
