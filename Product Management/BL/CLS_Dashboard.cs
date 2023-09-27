using Product_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Dashboard
    {
        public Models.FinancialPosition FinancialPosition()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                
                dal.Open();
                DataTable dtExpensee = new DataTable();
                dtExpensee = dal.SelectData("TotalExpensess", null);
                dal.Close();

                dal.Open();
                DataTable dtSeals = new DataTable();
                dtSeals = dal.SelectData("TotalSeals", null);
                dal.Close();

                dal.Open();
                DataTable dtPur = new DataTable();
                dtPur = dal.SelectData("TotalPurchases", null);
                dal.Close();

                dal.Open();
                DataTable dtCustomerRemainingAmount = new DataTable();
                dtCustomerRemainingAmount = dal.SelectData("TotalCustomerRemainingAmount", null);
                dal.Close();

                dal.Open();
                DataTable dtSuplierRemainingAmount = new DataTable();
                dtSuplierRemainingAmount = dal.SelectData("TotalSuplaiersRemainingAmount", null);
                dal.Close();

                Models.FinancialPosition financial = new Models.FinancialPosition()
                {
                    TotalExp = Convert.ToDouble(dtExpensee.Rows[0][0].ToString()),
                    TotalPur = Convert.ToDouble(dtPur.Rows[0][0].ToString()),
                    TotalSeals = Convert.ToDouble(dtSeals.Rows[0][0].ToString()),
                    TotalCustomerRemainingAmount = Convert.ToDouble(dtCustomerRemainingAmount.Rows[0][0].ToString()),
                    TotalSuplierRemainingAmount = Convert.ToDouble(dtSuplierRemainingAmount.Rows[0][0].ToString())
                };

                return financial;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
