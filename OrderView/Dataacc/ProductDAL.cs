using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using OrderView.Models;

namespace OrderView.Dataacc
{
    public class ProductDAL
    {
        //string conString = ConfigurationManager.ConnectionStrings["AdoConnectingString"].ToString();
        //Get All Products
        public List<Products> GetAllProducts()
        {
            List<Products> ProductList = new List<Products>();

            ProductList.Add(new Products { Address = "Address1", Mobile = "Mobile1", Name = "Name1" });
            ProductList.Add(new Products { Address = "Address2", Mobile = "Mobile2", Name = "Name2" });
            ProductList.Add(new Products { Address = "Address3", Mobile = "Mobile3", Name = "Name3" });

            //using (SqlConnection connection = new SqlConnection(conString))
            //{
            //    SqlCommand com = connection.CreateCommand();
            //   com.CommandType = CommandType.StoredProcedure;
            //   com.CommandText = "ContactViewALL";//Stored Procedure
            //  SqlDataAdapter sqlDA = new SqlDataAdapter(com);
            //   DataTable dtProducts = new DataTable();

            //   connection.Open();
            //   sqlDA.Fill(dtProducts);
            //   connection.Close();

            //   foreach(DataRow dr in dtProducts.Rows)
            //    {
            //        ProductList.Add(new Products
            //        {
            //           Name = dr["Name"].ToString(),
            //            Mobile = dr["Mobile"].ToString(),
            //            Address = dr["Address"].ToString()
            //        }); 

            //    }

            //}
            return ProductList;
        }

    }
}
