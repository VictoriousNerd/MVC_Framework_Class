using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;


namespace CURDOppMVC.Models
{
    public class EmpRepository
    {
        public SqlConnection Con;

        public void Conect()
        {
            string strCon= ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            Con = new SqlConnection(strCon);
        }

        public List<Employee> getEmps()
        {
            try { 
                Conect();
                Con.Open();
                List<Employee> lstEmp=SqlMapper.Query<Employee>(Con,"GetEmp").ToList();
                Con.Close();
                return lstEmp;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void addEmp(Employee emp)
        {
            try
            {
                Conect();
                Con.Open();
                Con.Execute("AddEmp", emp, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateEmp(Employee emp)
        {
            try
            {
                Conect();
                Con.Open();
                Con.Execute("UpdateEmp", emp, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void deleteEmp(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                Conect();
                Con.Open();
                Con.Execute("DeleteEmp", param, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}