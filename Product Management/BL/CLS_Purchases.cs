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
               
                return null;
            }
        }

        public DataTable GetItemData(int ItemId)
        {
            try
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
                param[0].Value = ItemId;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetItemData", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetSuppliersDate()
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetSuppliersDate", null);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }

        public DataTable GetAllReturnPurchases(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetAllReturnPurchases", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {

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
         
        public DataTable GetPurchaseOrderById(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = id;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurchaseOrderById", param);
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
        
        public DataTable GetPurchaseDetails(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = id;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurchaseDetails", param);
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

        public string GetBatchNo(int productId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("productId", SqlDbType.Int);
                param[0].Value = productId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetBatchNo", param);
                dal.Close();

                return dt.Rows[0][0].ToString();
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

        public string GetPurchasesId()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                
                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurchaseId", null);
                dal.Close();

                return dt.Rows[0][0].ToString();
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
        
        public string GetPurOrderId()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                
                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurOrderId", null);
                dal.Close();

                return dt.Rows[0][0].ToString();
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

        public DataTable GetProductPrice(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetProductPrice", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public string GetProductPriceData(int productId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@productId", SqlDbType.Int);
                param[0].Value = productId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetGetProductPriceData", param);
                dal.Close();

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public DataTable GetPurchaseInvoiceRpt(int invoiceId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@invoiceId", SqlDbType.Int);
                param[0].Value = invoiceId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurchaseInvoiceRpt", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetProductPriceById(int orderDetId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@orderDetId", SqlDbType.Int);
                param[0].Value = orderDetId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetProductPriceById", param);
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

        public bool UpdateProductPrice(int orderDetId, int SellingPrice)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@orderDetId", SqlDbType.Int);
                param[0].Value = orderDetId;
                
                param[1] = new SqlParameter("@SellingPrice", SqlDbType.Int);
                param[1].Value = SellingPrice;

                dal.Open();
                dal.ExCommand("UpdateProductPrice", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddPurchases(Purchases purchases)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@SupplierId", SqlDbType.Int);
                param[0].Value = purchases.SupplierId;

                param[1] = new SqlParameter("@DateOfPurchase", SqlDbType.Date);
                param[1].Value = purchases.DateOfPurchase;

                param[2] = new SqlParameter("@price", SqlDbType.BigInt);
                param[2].Value = purchases.price;

                param[3] = new SqlParameter("@PaidAmount", SqlDbType.BigInt);
                param[3].Value = purchases.PaidAmount;

                param[4] = new SqlParameter("@RemainingAmount", SqlDbType.BigInt);
                param[4].Value = purchases.RemainingAmount;

                param[5] = new SqlParameter("@PaymentMethodId", SqlDbType.Int);
                param[5].Value = purchases.PaymentMethodId;

                param[6] = new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar, 50);
                param[6].Value = purchases.InvoiceNumber;

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

        public bool AddPurchaseDetails(PurchaseDetails details)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[8];

                param[0] = new SqlParameter("@PurchaseId", SqlDbType.Int);
                param[0].Value = details.PurchaseId;
                
                param[1] = new SqlParameter("@BatchNumber", SqlDbType.Int);
                param[1].Value = details.BatchNumber;
                
                param[2] = new SqlParameter("@ExpDate", SqlDbType.Date);
                param[2].Value = details.ExpDate;
                
                param[3] = new SqlParameter("@QTY", SqlDbType.Int);
                param[3].Value = details.QTY;
                
                param[4] = new SqlParameter("@PurchasePrice", SqlDbType.Int);
                param[4].Value = details.PurchasePrice;
                
                param[5] = new SqlParameter("@SellingPrice", SqlDbType.Int);
                param[5].Value = details.SellingPrice;
                
                param[6] = new SqlParameter("@TotalPrice", SqlDbType.Int);
                param[6].Value = details.TotalPrice;
                
                param[7] = new SqlParameter("@ProductId", SqlDbType.Int);
                param[7].Value = details.productId;

                dal.Open();
                dal.ExCommand("AddPurchaseDetails", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
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
                //if (!Directory.Exists(@"C:\BMS\BMS_Errors.txt"))
                //    Directory.CreateDirectory(@"C:\BMS\BMS_Errors.txt");

                //string errorMessage = DateTime.Now.ToString() + Environment.NewLine + ex.Message + Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                //File.WriteAllText(@"C:\BMS\BMS_Errors.txt", errorMessage);
                return false;
            }
        }

        public bool DeletePurchasDetails(int id, int productId, int PurchaseId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = id;
                
                param[1] = new SqlParameter("@productId", SqlDbType.Int);
                param[1].Value = productId;
                
                param[2] = new SqlParameter("@PurchaseId", SqlDbType.Int);
                param[2].Value = PurchaseId;

                dal.Open();
                dal.ExCommand("DeletePurchasDetails", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdatePurchases(Purchases purchases)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[8];

                param[0] = new SqlParameter("@SupplierId", SqlDbType.Int);
                param[0].Value = purchases.SupplierId;

                param[1] = new SqlParameter("@DateOfPurchase", SqlDbType.Date);
                param[1].Value = purchases.DateOfPurchase;

                param[2] = new SqlParameter("@price", SqlDbType.BigInt);
                param[2].Value = purchases.price;

                param[3] = new SqlParameter("@PaidAmount", SqlDbType.BigInt);
                param[3].Value = purchases.PaidAmount;

                param[4] = new SqlParameter("@RemainingAmount", SqlDbType.BigInt);
                param[4].Value = purchases.RemainingAmount;

                param[5] = new SqlParameter("@PaymentMethodId", SqlDbType.Int);
                param[5].Value = purchases.PaymentMethodId;

                param[6] = new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar, 50);
                param[6].Value = purchases.InvoiceNumber;

                param[7] = new SqlParameter("@Id", SqlDbType.Int);
                param[7].Value = purchases.Id;

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

        public bool UpdateSupplierReceivables(int Id, int ReceivedAmount)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = Id;
                
                param[1] = new SqlParameter("@ReceivedAmount", SqlDbType.BigInt);
                param[1].Value = ReceivedAmount;


                dal.Open();
                dal.ExCommand("UpdateSupplierReceivables", param);
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
