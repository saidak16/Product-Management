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
    public class CLS_Sales_Representative
    {
        public DataTable GetAll()
        {
            DataAccessLayer dal = new DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetSalesRepresentative", null);
            dal.Close();
            return dt;
        }
        
        public DataTable Search(string search)
        {
            DataAccessLayer dal = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ser", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("SearchSalesRepresentative", param);
            dal.Close();
            return dt;
        }

        public bool Delete(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = id;

                dal.Open();
                dal.ExCommand("DeleteSalesRepresentative", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Add(SalesRepresentative sales)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[4];


                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
                param[0].Value = sales.Name;

                param[1] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                param[1].Value = sales.Phone;

                param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 250);
                param[2].Value = sales.Address;
                
                param[3] = new SqlParameter("@PercentageOfSales", SqlDbType.Int);
                param[3].Value = sales.PercentageOfSales;


                dal.Open();
                dal.ExCommand("AddSalesRepresentative", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(SalesRepresentative sales)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[5];


                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
                param[0].Value = sales.Name;

                param[1] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                param[1].Value = sales.Phone;

                param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 250);
                param[2].Value = sales.Address;
                
                param[3] = new SqlParameter("@ID", SqlDbType.Int);
                param[3].Value = sales.Id;
                
                param[4] = new SqlParameter("@PercentageOfSales", SqlDbType.Int);
                param[4].Value = sales.PercentageOfSales;


                dal.Open();
                dal.ExCommand("UpdateSalesRepresentative", param);
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
