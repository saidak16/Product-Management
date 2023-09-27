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

        public void Add_Product(string Pro_Name,byte[] image, int ID_Cat)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            dal.Open();

            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@Pro_Name", SqlDbType.NVarChar,50);
            param[1].Value = Pro_Name;

            param[2] = new SqlParameter("@Img", SqlDbType.Image);
            param[2].Value = image;

            dal.ExCommand("Add_Pro", param);
            dal.Close();
        }

        public void Update_Product(int ID_Pro, string Pro_Name, byte[] image, int ID_Cat)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            dal.Open();

            param[0] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@ID_Pro", SqlDbType.NVarChar, 30);
            param[1].Value = ID_Pro;

            param[2] = new SqlParameter("@Pro_Name", SqlDbType.NVarChar, 50);
            param[2].Value = Pro_Name;

            param[3] = new SqlParameter("@Img", SqlDbType.Image);
            param[3].Value = image;

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
        
        public DataTable GetProductsList()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetProductsList", null);
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

         public DataTable Search_Product(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Search_Product", param);
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
