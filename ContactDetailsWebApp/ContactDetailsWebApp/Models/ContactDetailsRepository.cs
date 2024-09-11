using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace ContactDetailsWebApp.Models
{
    public class ContactDetailsRepository
    {
        public SqlConnection Con;

        public void Connect()
        {
            string strCon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            Con = new SqlConnection(strCon);
        }

        // CRUD OPERATION
        // Get Contact Details - Dashboard page table
        public List<ContactDetails> getContDet()
        {
            try
            {
                Connect();
                Con.Open();
                List<ContactDetails> lstCont = SqlMapper.Query<ContactDetails>(Con, "DashboardView").ToList();
                Con.Close();
                return lstCont;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Add Contact Details
        public void addContDet(ContactDetails cont)
        {
            try
            {
                Connect();
                Con.Open();
                Con.Execute("AddContact", cont, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Update Contact Details
        public void updateContDet(ContactDetails cont)
        {
            try
            {
                Connect();
                Con.Open();
                Con.Execute("UpdateContact", cont, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Delete Contact Details
        public void deleteProduct(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                Connect();
                Con.Open();
                Con.Execute("DeleteContact", param, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // View Single Contact
        public void viewContactDet(ContactDetails cont)
        {
            try
            {
                Connect();
                Con.Open();
                Con.Execute("ViewContact", cont, commandType: CommandType.StoredProcedure);
                Con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // DASHBOARD WIDGETS
        // Get User Count
        public int GetUserCount()
        {
            try
            {
                Connect();
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ContactDetails", Con);
                int count = (int)cmd.ExecuteScalar();
                Con.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Count Managers
        public int GetManagCount()
        {
            try
            {
                Connect();
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ContactDetails WHERE Role = 'Manager'", Con);
                int count = (int)cmd.ExecuteScalar();
                Con.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Count Employees
        public int GetEmpCount()
        {
            try
            {
                Connect();
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ContactDetails WHERE Role = 'Employee'", Con);
                int count = (int)cmd.ExecuteScalar();
                Con.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}