using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Management.BL
{
    class CLS_Products
    {
        public DataTable Get_Cat()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Select_Cat", null);
            dal.Close();
            return dt;
        }

        public void Add_Product(int qte, string Pro_Name,string price, byte[] image, int ID_Cat, int supplierId, DateTime expDate)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            dal.Open();

            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@SupplierId", SqlDbType.Int);
            param[1].Value = supplierId;

            param[2] = new SqlParameter("@Pro_Name", SqlDbType.NVarChar,50);
            param[2].Value = Pro_Name;

            param[3] = new SqlParameter("@qet", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@Price", SqlDbType.NVarChar,20);
            param[4].Value = price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = image;
            
            param[6] = new SqlParameter("@expDate", SqlDbType.Date);
            param[6].Value = expDate;

            dal.ExCommand("Add_Pro", param);
            dal.Close();
        }

        public void Update_Product(int ID_Pro, int qte, string Pro_Name, string price, byte[] image, int ID_Cat, int supplierId, DateTime expDate)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            dal.Open();

            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@ID_Pro", SqlDbType.NVarChar, 30);
            param[1].Value = ID_Pro;

            param[2] = new SqlParameter("@Pro_Name", SqlDbType.NVarChar, 50);
            param[2].Value = Pro_Name;

            param[3] = new SqlParameter("@qet", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@Price", SqlDbType.NVarChar, 20);
            param[4].Value = price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = image;
            
            param[6] = new SqlParameter("@expDate", SqlDbType.Date);
            param[6].Value = expDate;
            
            param[7] = new SqlParameter("@SupplierId", SqlDbType.Int);
            param[7].Value = supplierId;

            dal.ExCommand("Update_Product", param);
            dal.Close();
        }

        public DataTable Verify(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 30);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.SelectData("Verify_Product", param);
            dal.Close();
            return dt;
        }

        public DataTable Get_Pro()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Select_Pro", null);
            dal.Close();
            return dt;
        }

        public DataTable Search_Pro(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Search_Prod", param);
            dal.Close();
            return dt;
        }

        public DataTable ImagePro(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ImagePro", param);
            dal.Close();
            return dt;
        }

        public void Delete_Product(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            dal.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            param[0].Value = ID;

            dal.ExCommand("DeletePro", param);
            dal.Close();
        }

    }
}
