using Product_Management.DAL;
using Product_Management.Models;
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
    public class CLS_Purchases
    {
        public DataTable GetAllPurchases()
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetAllPurchases", null);
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

        public DataTable GetPurchasesById(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("id", SqlDbType.Int);
                param[0].Value = id;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurchasesById", param);
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

        public DataTable SearchPurchases(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("SearchPurchases", param);
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
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[13];

                param[0] = new SqlParameter("@SupplierId", SqlDbType.Int);
                param[0].Value = purchases.SupplierId;

                param[1] = new SqlParameter("@ProductId", SqlDbType.Int);
                param[1].Value = purchases.ProductId;

                param[2] = new SqlParameter("@DateOfPurchase", SqlDbType.Date);
                param[2].Value = purchases.DateOfPurchase;

                param[3] = new SqlParameter("@ExpirationDate", SqlDbType.Date);
                param[3].Value = purchases.ExpirationDate;

                param[4] = new SqlParameter("@QTY", SqlDbType.Int);
                param[4].Value = purchases.QTY;

                param[5] = new SqlParameter("@PurchasingPrice", SqlDbType.BigInt);
                param[5].Value = purchases.PurchasingPrice;

                param[6] = new SqlParameter("@SellingPrice", SqlDbType.BigInt);
                param[6].Value = purchases.SellingPrice;

                param[7] = new SqlParameter("@price", SqlDbType.BigInt);
                param[7].Value = purchases.price;

                param[8] = new SqlParameter("@PaidAmount", SqlDbType.BigInt);
                param[8].Value = purchases.PaidAmount;

                param[9] = new SqlParameter("@RemainingAmount", SqlDbType.BigInt);
                param[9].Value = purchases.RemainingAmount;

                param[10] = new SqlParameter("@PaymentMethodId", SqlDbType.Int);
                param[10].Value = purchases.PaymentMethodId;

                param[11] = new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar, 50);
                param[11].Value = purchases.InvoiceNumber;

                param[12] = new SqlParameter("@BatchNumber", SqlDbType.Int);
                param[12].Value = purchases.BatchNumber;

                dal.Open();
                dal.ExCommand("AddPurchases", param);
                dal.Close();

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

        public bool DeletePurchases(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("id", SqlDbType.Int);
                param[0].Value = id;

                dal.Open();
                dal.ExCommand("DeletePurchases", param);
                dal.Close();

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

        public bool UpdatePurchases(Purchases purchases)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[14];

                param[0] = new SqlParameter("@SupplierId", SqlDbType.Int);
                param[0].Value = purchases.SupplierId;

                param[1] = new SqlParameter("@ProductId", SqlDbType.Int);
                param[1].Value = purchases.ProductId;

                param[2] = new SqlParameter("@DateOfPurchase", SqlDbType.Date);
                param[2].Value = purchases.DateOfPurchase;

                param[3] = new SqlParameter("@ExpirationDate", SqlDbType.Date);
                param[3].Value = purchases.ExpirationDate;

                param[4] = new SqlParameter("@QTY", SqlDbType.Int);
                param[4].Value = purchases.QTY;

                param[5] = new SqlParameter("@PurchasingPrice", SqlDbType.BigInt);
                param[5].Value = purchases.PurchasingPrice;

                param[6] = new SqlParameter("@SellingPrice", SqlDbType.BigInt);
                param[6].Value = purchases.SellingPrice;

                param[7] = new SqlParameter("@price", SqlDbType.BigInt);
                param[7].Value = purchases.price;

                param[8] = new SqlParameter("@PaidAmount", SqlDbType.BigInt);
                param[8].Value = purchases.PaidAmount;

                param[9] = new SqlParameter("@RemainingAmount", SqlDbType.BigInt);
                param[9].Value = purchases.RemainingAmount;

                param[10] = new SqlParameter("@PaymentMethodId", SqlDbType.Int);
                param[10].Value = purchases.PaymentMethodId;

                param[11] = new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar, 50);
                param[11].Value = purchases.InvoiceNumber;

                param[12] = new SqlParameter("@BatchNumber", SqlDbType.Int);
                param[12].Value = purchases.BatchNumber;

                param[13] = new SqlParameter("@Id", SqlDbType.Int);
                param[13].Value = purchases.Id;

                dal.Open();
                dal.ExCommand("UpdatePurchases", param);
                dal.Close();

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
