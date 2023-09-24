using Product_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Helper
    {
        public int GetBatchNumber()
        {
            try
            {
                int batchNumber = 0;
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetBatchNumber", null);
                dal.Close();

                batchNumber = Convert.ToInt32(dt.Rows[0][0].ToString());
                return batchNumber;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int GetInvoiceNumber()
        {
            try
            {
                int invoiceNumber = 0;
                DataAccessLayer dal = new DataAccessLayer();

                dal.Open();
                DataTable dt = new DataTable();
                dt = dal.SelectData("GetInvoiceNumber", null);
                dal.Close();

                invoiceNumber = Convert.ToInt32(dt.Rows[0][0].ToString());
                return invoiceNumber;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
