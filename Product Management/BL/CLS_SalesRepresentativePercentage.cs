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
    public class CLS_SalesRepresentativePercentage
    {
        public DataTable GetAll()
        {
            try
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetSalesRepresentativePercentage", null);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Add(SalesRepresentativePercentage percentage)
        {
            try
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@orderId", SqlDbType.Int);
                param[0].Value = percentage.orderId;
                
                param[1] = new SqlParameter("@SalesRepresentativeId", SqlDbType.Int);
                param[1].Value = percentage.SalesRepresentativeId;
                
                param[2] = new SqlParameter("@Amount", SqlDbType.Int);
                param[2].Value = percentage.Amount;
                
                param[3] = new SqlParameter("@DateOfInvoice", SqlDbType.Date);
                param[3].Value = percentage.DateOfInvoice;

                dal.Open();
                dal.ExCommand("AddSalesRepresentativePercentage", param);
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
