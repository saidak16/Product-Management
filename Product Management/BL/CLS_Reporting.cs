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
                if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
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
                if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
                return null;
            }
        }
    }
}
