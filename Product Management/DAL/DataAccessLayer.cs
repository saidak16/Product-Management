using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Management.DAL
{
    class DataAccessLayer
    {
        SqlConnection cn;

        //Constrecter 
        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.Mode;
            if (mode == "Windows")
            {
                cn = new SqlConnection("Server ="+Properties.Settings.Default.Server +"; DataBase ="+Properties.Settings.Default.Database+"; Integrated Security = true");
            }
            else
            {
                cn = new SqlConnection("Server =" + Properties.Settings.Default.Server + "; DataBase =" + Properties.Settings.Default.Database + "; Integrated Security = false; User ID = "+Properties.Settings.Default.ID+"; Password = "+Properties.Settings.Default.Password+" ");
            }
        }

        //Open The Connection
        public void Open()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }

        //Close The Connection
        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        
        //Function To Receive Data From DataBase
        public DataTable SelectData(string StoredProceder, SqlParameter[] param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoredProceder;
                cmd.Connection = cn;

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        cmd.Parameters.Add(param[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }          
        }

        //Function To Send Data From DataBase
        public void ExCommand(string StP, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StP;
            cmd.Connection = cn;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            cmd.ExecuteNonQuery();
        }
    }
}
