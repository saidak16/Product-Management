﻿using Product_Management.DAL;
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

        public DataTable GetReturnPurchases(int supplerId, string search)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@supplerId", SqlDbType.Int);
                param[0].Value = supplerId;
                
                param[1] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[1].Value = search;

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

        public DataTable GetSupplierInvoices(int supplierId, string search)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@supplierId", SqlDbType.Int);
                param[0].Value = supplierId;
                
                param[1] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[1].Value = search;

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

        public DataTable GetPurchasesInstallment(int orderId)
        {
            try
            {

                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@orderId", SqlDbType.Int);
                param[0].Value = orderId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPurchasesInstallment", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetTotalAmount(int supplerId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplerId", SqlDbType.Int);
                param[0].Value = supplerId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetTotalAmount", param);
                dal.Close();

                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        
        public int GetPaidAmount(int supplerId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplerId", SqlDbType.Int);
                param[0].Value = supplerId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetPaidAmount", param);
                dal.Close();

                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        
        public int GetRemainingAmount(int supplerId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplerId", SqlDbType.Int);
                param[0].Value = supplerId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetRemainingAmount", param);
                dal.Close();

                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        
        public int GetTotalInvoices(int supplerId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@supplerId", SqlDbType.Int);
                param[0].Value = supplerId;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetTotalInvoices", param);
                dal.Close();

                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
