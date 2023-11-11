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
    public class CLS_Employee
    {
        public DataTable GetAllEmployees(string search)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                dal.Open();

                param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
                param[0].Value = search;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetAllEmployees", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetEmployeeById(int Id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                dal.Open();

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = Id;

                DataTable dt = new DataTable();
                dt = dal.SelectData("GetEmployeeById", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable DeleteEmployees(int Id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];

                dal.Open();

                param[0] = new SqlParameter("@Id", SqlDbType.Int);
                param[0].Value = Id;

                DataTable dt = new DataTable();
                dt = dal.SelectData("DeleteEmployees", param);
                dal.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[8];

                dal.Open();

                param[0] = new SqlParameter("@FullName", SqlDbType.NVarChar);
                param[0].Value = employee.FullName;
                
                param[1] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                param[1].Value = employee.Phone;
                
                param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                param[2].Value = employee.Address;
                
                param[3] = new SqlParameter("@Salary", SqlDbType.Int);
                param[3].Value = employee.Salary;
                
                param[4] = new SqlParameter("@Holidays", SqlDbType.Int);
                param[4].Value = employee.Holidays;
                
                param[5] = new SqlParameter("@Job", SqlDbType.NVarChar, 50);
                param[5].Value = employee.Job;
                
                param[6] = new SqlParameter("@EmpImage", SqlDbType.Image);
                param[6].Value = employee.EmpImage;
                
                param[7] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                param[7].Value = employee.Email;

                DataTable dt = new DataTable();
                dal.ExCommand("AddEmployee", param);
                dal.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[9];

                dal.Open();

                param[0] = new SqlParameter("@FullName", SqlDbType.NVarChar);
                param[0].Value = employee.FullName;

                param[1] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                param[1].Value = employee.Phone;

                param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                param[2].Value = employee.Address;

                param[3] = new SqlParameter("@Salary", SqlDbType.Int);
                param[3].Value = employee.Salary;

                param[4] = new SqlParameter("@Holidays", SqlDbType.Int);
                param[4].Value = employee.Holidays;

                param[5] = new SqlParameter("@Job", SqlDbType.NVarChar, 50);
                param[5].Value = employee.Job;

                param[6] = new SqlParameter("@EmpImage", SqlDbType.Image);
                param[6].Value = employee.EmpImage;
                
                param[7] = new SqlParameter("@Id", SqlDbType.Int);
                param[7].Value = employee.Id;
                
                param[8] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
                param[8].Value = employee.Email;

                DataTable dt = new DataTable();
                dal.ExCommand("UpdateEmployee", param);
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
