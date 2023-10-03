using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Product_Management.DAL;

namespace Product_Management.BL
{
    class CLS_Customers
    {
        public void Add_Customer(string F_Name, string L_Name, string Phone, string Email, byte[] image)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            dal.Open();

            param[0] = new SqlParameter("@F_Name", SqlDbType.NVarChar, 30);
            param[0].Value = F_Name;

            param[1] = new SqlParameter("@L_Name", SqlDbType.NVarChar, 50);
            param[1].Value = L_Name;

            param[2] = new SqlParameter("@Tel", SqlDbType.Int);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@E_mail", SqlDbType.NVarChar, 20);
            param[3].Value = Email;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = image;

            dal.ExCommand("Add_CUST", param);
            dal.Close();
        }

        public DataTable Select_Customers()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Sel_Cust", null);
            dal.Close();
            return dt;
        }

        public void Delete_Customer(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            dal.Open();

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExCommand("Del_CUST", param);
            dal.Close();
        }

        public void Update_Customer(int id ,string F_Name, string L_Name, string Phone, string Email, byte[] image)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            dal.Open();

            param[0] = new SqlParameter("@F_Name", SqlDbType.NVarChar, 30);
            param[0].Value = F_Name;

            param[1] = new SqlParameter("@L_Name", SqlDbType.NVarChar, 50);
            param[1].Value = L_Name;

            param[2] = new SqlParameter("@Tel", SqlDbType.Int);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@E_mail", SqlDbType.NVarChar, 20);
            param[3].Value = Email;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@id",SqlDbType.Int);
            param[5].Value = id;

            dal.ExCommand("Up_CUST", param);
            dal.Close();
        }

        public DataTable Search_Customers(string ser)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("ser", SqlDbType.NVarChar, 50);
            param[0].Value = ser;
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Serch", param);
            dal.Close();
            return dt;
        }

        public DataTable GetCustomersLiabilities(int Id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("Id", SqlDbType.Int);
            param[0].Value = Id;
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetCustomersLiabilities", param);
            dal.Close();
            return dt;
        }

        public DataTable SearchCustomersLiabilities(string ser)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@seach", SqlDbType.NVarChar, 50);
            param[0].Value = ser;
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("SearchCustomersLiabilities", param);
            dal.Close();
            return dt;
        }

        public DataTable GetCustomersLiabilities()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetCustomersLiabilities", null);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
