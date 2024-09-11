using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;

namespace ProductDatabaseForm.Models
{
    public class ProdRepository
    {
        public SqlConnection Con;

        public void Conect()
        {
            string strCon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            Con = new SqlConnection(strCon);
        }

        public List<Product> getProduct()
        {
            try
            {
                Conect();
                Con.Open();
                List<Product> lstProd = SqlMapper.Query<Product>(Con, "GetProduct").ToList();
                Con.Close();
                return lstProd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddProduct(Product prod)
        {
            try
            {
                Conect();
                Con.Open();
                Con.Execute("AddProduct", prod, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateProduct(Product prod)
        {
            try
            {
                Conect();
                Con.Open();
                Con.Execute("updateProduct", prod, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteProduct(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                Conect();
                Con.Open();
                Con.Execute("DeleteProduct", param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void viewProduct(Product prod)
        {
            try
            {
                Conect();
                Con.Open();
                Con.Execute("viewProduct", prod, commandType: CommandType.StoredProcedure);
                Con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}