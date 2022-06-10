﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Management.BL
{
    class ClS_Login
    {
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_Login", param);
            dal.Close();
            return dt;
        
        }
    }
}
