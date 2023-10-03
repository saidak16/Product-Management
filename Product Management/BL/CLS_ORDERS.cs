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
    class CLS_ORDERS
    {
        public DataTable OrdersID()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Last_Order_Id", null);
            dal.Close();
            return dt;
        }

        public bool DeleteOrderDetails(int id, int purchaseId)
        {
            try
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];
                dal.Open();

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = id;

                param[1] = new SqlParameter("@PurchaseId", SqlDbType.Int);
                param[1].Value = purchaseId;

                dal.ExCommand("DeleteOrderDetails", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Add_Order(int id,DateTime Order_Date,int Cust_ID,string des,string SalesMan, int TotalAmount, int PaidAmount, int RemainingAmount)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            dal.Open();

            param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Date_Order", SqlDbType.Date);
            param[1].Value = Order_Date;

            param[2] = new SqlParameter("@Customer_ID", SqlDbType.Int);
            param[2].Value = Cust_ID;

            param[3] = new SqlParameter("@Des_Order", SqlDbType.NVarChar, 250);
            param[3].Value = des;

            param[4] = new SqlParameter("@SalesMan", SqlDbType.NVarChar, 75);
            param[4].Value = SalesMan;
            
            param[5] = new SqlParameter("@TotalAmount", SqlDbType.BigInt);
            param[5].Value = TotalAmount;
            
            param[6] = new SqlParameter("@PaidAmount", SqlDbType.BigInt);
            param[6].Value = PaidAmount;
            
            param[7] = new SqlParameter("@RemainingAmount", SqlDbType.BigInt);
            param[7].Value = RemainingAmount;

            dal.ExCommand("Add_Order", param);
            dal.Close();
        }


        public void Order_Det(string ID_Product, int ID_Order, int qte, string price, double discount, string amount, string total, int PurchaseId)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            dal.Open();

            param[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar , 30);
            param[0].Value = ID_Product;

            param[1] = new SqlParameter("@ID_Order", SqlDbType.Int);
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
            
            param[7] = new SqlParameter("@PurchaseId", SqlDbType.Int);
            param[7].Value = PurchaseId;

            dal.ExCommand("Order_Det", param);
            dal.Close();
        }


        public DataTable Verify_QTY(string id_pro,int qty)
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


        public DataTable Order_Del(string cir)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cr", SqlDbType.NVarChar, 50);
            param[0].Value = cir;

            DataTable dt = new DataTable();
            dt = dal.SelectData("Det_Order", param);
            return dt;
        }

        public bool UpdateCustomersLiabilities(int id, int AmountPaid)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = id;
                
                param[1] = new SqlParameter("@AmountPaid", SqlDbType.Int);
                param[1].Value = AmountPaid;

                dal.Open();
                dal.ExCommand("UpdateCustomersLiabilities", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public DataTable CustomersLiabilitiesById(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = id;

                DataTable dt = new DataTable();
                dt = dal.SelectData("CustomersLiabilitiesById", param);
                
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetCustomersLiabilities(int ID)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = ID;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetCustomersLiabilities", param);
                
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Order_RPT(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            dal.Open();

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;

            dal.ExCommand("Order_RPT", param);
            dal.Close();
        }

        public DataTable GetAllOrders(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetAllOrders", param);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public DataTable GetOrderDetails(string search, int orderId)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@orderId", SqlDbType.Int);
                param[0].Value = orderId;
                
                param[1] = new SqlParameter("@cr", SqlDbType.NVarChar, 50);
                param[1].Value = search;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetOrderDetails", param);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
