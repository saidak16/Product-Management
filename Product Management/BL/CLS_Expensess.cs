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
    public class CLS_Expensess
    {
        public DataTable GetAllExpensess()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetAllExpensess", null);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SearchExpensess(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("SearchExpensess", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteExpensess(int ID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                dal.Open();
                dal.ExCommand("DeleteExpensess", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddExpensess(Expensess expensess)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@Discription", SqlDbType.NVarChar, 50);
                param[0].Value = expensess.Discription;

                param[1] = new SqlParameter("@DateOfExpense", SqlDbType.DateTime);
                param[1].Value = expensess.DateOfExpense;

                param[2] = new SqlParameter("@Amount", SqlDbType.Float);
                param[2].Value = expensess.Amount;

                dal.Open();
                dal.ExCommand("AddExpensess", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditExpensess(Expensess expensess)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@Discription", SqlDbType.NVarChar, 50);
                param[0].Value = expensess.Discription;

                param[1] = new SqlParameter("@DateOfExpense", SqlDbType.DateTime);
                param[1].Value = expensess.DateOfExpense;

                param[2] = new SqlParameter("@Amount", SqlDbType.Float);
                param[2].Value = expensess.Amount;

                param[3] = new SqlParameter("@ID", SqlDbType.Int);
                param[3].Value = expensess.Id;

                dal.Open();
                dal.ExCommand("EditExpensess", param);
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
