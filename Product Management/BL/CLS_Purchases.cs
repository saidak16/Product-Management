using Product_Management.DAL;
using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Purchases
    {
        public DataTable GetAllPurchases()
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetAllSuppliers", null);
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

        public bool AddPurchases(Purchases purchases)
        {
            try
            {


                return true;
            }
            catch (Exception ex)
            {
                if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
                return false;
            }
        }
    }
}
