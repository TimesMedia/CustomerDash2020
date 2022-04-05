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
    public class AddressDAL
    {
        string conString = ConfigurationManager.ConnectionStrings["AdoConnectingString"].ToString();
        //Get All Products
        public List<Addresee> GetAllProducts()
        {
            List<Addresee> AddressList = new List<Addresee>();

            AddressList.Add(new Addresee { Address = "Address1" });
            AddressList.Add(new Addresee { Address = "Address2" });
            AddressList.Add(new Addresee { Address = "Address3" });


            //using (SqlConnection connection = new SqlConnection(conString))
            //{
            //    SqlCommand com = connection.CreateCommand();
            //  com.CommandType = CommandType.StoredProcedure;
            //   com.CommandText = "ViewAddress";//Stored Procedure
            //    SqlDataAdapter sqlDs = new SqlDataAdapter(com);
            //    DataTable dtAddress = new DataTable();

            //   connection.Open();
            //   sqlDs.Fill(dtAddress);
            //   connection.Close();

            //    foreach (DataRow dr in dtAddress.Rows)
            //   {
            //       AddressList.Add(new Addresee
            //        {
            //            Address = dr["Address"].ToString(),

            //        });

            //   }

            //}
            return AddressList;
        }

    }
}