using Product_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.BL
{
    public class CLS_Proforma_Invoice
    {
        public DataTable GetProformaInvoiceId()
        {
            DataAccessLayer dal = new DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetProformaInvoiceId", null);
            dal.Close();
            return dt;
        }

        public DataTable Verify_QTY(string id_pro, int qty)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 30);
            param[0].Value = id_pro;

            param[1] = new SqlParameter("@QTY", SqlDbType.Int);
            param[1].Value = qty;

            DataTable dt = new DataTable();
            dt = dal.SelectData("Verify_QTY", param);
            dal.Close();
            return dt;
        }


        public bool Add_Proforma_Invoice(int id,DateTime Order_Date, int Cust_ID, string des, string SalesMan)
        {
            try
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[5];
                dal.Open();

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = id;

                param[1] = new SqlParameter("@Date_ProformaInvoice", SqlDbType.Date);
                param[1].Value = Order_Date;

                param[2] = new SqlParameter("@Customer_ID", SqlDbType.Int);
                param[2].Value = Cust_ID;

                param[3] = new SqlParameter("@Des_ProformaInvoice", SqlDbType.NVarChar, 250);
                param[3].Value = des;

                param[4] = new SqlParameter("@SalesMan", SqlDbType.NVarChar, 75);
                param[4].Value = SalesMan;

                dal.ExCommand("Add_Proforma_Invoice", param);
                dal.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool Proforma_Invoice_Det(string ID_Product, int ID_Order, int qte, string price, double discount, string amount, string total)
        {
            try
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[7];
                dal.Open();

                param[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 30);
                param[0].Value = ID_Product;

                param[1] = new SqlParameter("@ID_ProformaInvoice", SqlDbType.Int);
                param[1].Value = ID_Order;

                param[2] = new SqlParameter("@qte", SqlDbType.Int);
                param[2].Value = qte;

                param[3] = new SqlParameter("@price", SqlDbType.NVarChar, 50);
                param[3].Value = price;

                param[4] = new SqlParameter("@discount", SqlDbType.Float);
                param[4].Value = discount;

                param[5] = new SqlParameter("@amount", SqlDbType.NVarChar, 50);
                param[5].Value = amount;

                param[6] = new SqlParameter("@total", SqlDbType.NVarChar, 50);
                param[6].Value = total;

                dal.ExCommand("Proforma_Invoice_Det", param);
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
