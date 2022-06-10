using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Product_Management.BL
{
    class CLS_USERS
    {
        public void ADD_User(string ID, string fullname, string pwd, string role)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            dal.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar , 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@Role", SqlDbType.NVarChar, 50);
            param[2].Value = role;

            param[3] = new SqlParameter("@FullName", SqlDbType.NVarChar, 50);
            param[3].Value = fullname;

            dal.ExCommand("ADD_User", param);
            dal.Close();
        }

        public void EditUser(string ID, string fullname, string pwd, string role)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            dal.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@Role", SqlDbType.NVarChar, 50);
            param[2].Value = role;

            param[3] = new SqlParameter("@FullName", SqlDbType.NVarChar, 50);
            param[3].Value = fullname;

            dal.ExCommand("EditUser", param);
            dal.Close();
        }

        public DataTable Select_Users(string Cir)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            dal.Open();

            param[0] = new SqlParameter("@Cir", SqlDbType.NVarChar, 50);
            param[0].Value = Cir;

            DataTable dt = new DataTable();
            dt = dal.SelectData("Select_Users", param);
            dal.Close();
            return dt;
        }

        public void Delete_User(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            dal.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            dal.ExCommand("Delete_User", param);
            dal.Close();
        }


    }
}
