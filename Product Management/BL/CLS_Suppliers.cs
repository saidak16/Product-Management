using Product_Management.DAL;
using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Suppliers
    {
        public DataTable GetAllSuppliers()
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
                throw ex;
            }
        }

        public DataTable GetSupplier(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("id", SqlDbType.NVarChar, 50);
                param[0].Value = id;
                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("Serch", param);
                dal.Close();
                
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddSupplier(Supplier supplier)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("Name", SqlDbType.NVarChar, int.MaxValue);
                param[0].Value = supplier.Name;
                
                param[1] = new SqlParameter("Phone", SqlDbType.NVarChar, int.MaxValue);
                param[1].Value = supplier.Phone;
                
                param[2] = new SqlParameter("Email", SqlDbType.NVarChar, int.MaxValue);
                param[2].Value = supplier.Email;
                
                param[3] = new SqlParameter("CompanyName", SqlDbType.NVarChar, int.MaxValue);
                param[3].Value = supplier.CompanyName;

                dal.Open();
                dal.ExCommand("AddSupplier", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("Name", SqlDbType.NVarChar, int.MaxValue);
                param[0].Value = supplier.Name;

                param[1] = new SqlParameter("Phone", SqlDbType.NVarChar, int.MaxValue);
                param[1].Value = supplier.Phone;

                param[2] = new SqlParameter("Email", SqlDbType.NVarChar, int.MaxValue);
                param[2].Value = supplier.Email;

                param[3] = new SqlParameter("CompanyName", SqlDbType.NVarChar, int.MaxValue);
                param[3].Value = supplier.CompanyName;
                
                param[4] = new SqlParameter("id", SqlDbType.NVarChar, int.MaxValue);
                param[4].Value = supplier.Id;

                dal.Open();
                dal.ExCommand("UpdateSupplier", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteSupplier(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("id", SqlDbType.Int);
                param[0].Value = id;
                
                dal.Open();
                dal.ExCommand("DeleteSupplier", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
