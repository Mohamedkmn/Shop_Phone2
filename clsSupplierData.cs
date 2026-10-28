using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsSupplierData
    {
        public static DataTable GetSuppliers()
        {
            DataTable Info = new DataTable();

            //string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringPhoneShop"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("sp_GetSuppliers", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
 

            //        Info.Load(command.ExecuteReader());
            //    }

            //}

            return Info;
        }
        public static DataTable GetSuppliersByName(string SupplierName)
        {
            DataTable Info = new DataTable();

           // string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringPhoneShop"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("sp_GetSuppliersByName", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@SupplierName" , SupplierName);

            //        Info.Load(command.ExecuteReader());
            //    }

            //}

            return Info;
        }

        public static int AddNewSuppliers(string SupplierName)
        {

            // string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringPhoneShop"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("sp_AddNewSuppliers", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@SupplierName", SupplierName);

            //        SqlParameter OutPutParameterDate = new SqlParameter("@NewSupplierID", SqlDbType.Int);
            //        OutPutParameterDate.Direction = ParameterDirection.Output;
            //        command.Parameters.Add(OutPutParameterDate);

            //        command.ExecuteNonQuery();

            //        return (int)OutPutParameterDate.Value;
            //    }

            //}

            return 0;
             
        }
        public static bool UpdateSuppliers( int SupplierID, string SupplierName)
        {

            //string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringPhoneShop"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("sp_UpdateSupplier", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@SupplierName", SupplierName);
            //        command.Parameters.AddWithValue("@SupplierID", SupplierID);



            //      return  command.ExecuteNonQuery() > 0;


            //    }

            //}

            return false;

        }
        public static bool GetSupplierByID(int SupplierID , ref string SupplierName)
        {
             

          //  string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringPhoneShop"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand("sp_GetSupplierByID", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@SupplierID", SupplierID);

            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                SupplierName = (string)reader["Name"];
            //                return true;
            //            }

            //        }
            //    }

            //}

            return false;
        }
        public static bool IsSupplierExist(string SupplierName)
        {
            //string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringPhoneShop"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    connection.Open();

            //    using (SqlCommand command = new SqlCommand("sp_IsSupplierExist", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;

            //        command.Parameters.AddWithValue("@SupplierName", SupplierName);


            //        SqlParameter ReturnParm = new SqlParameter();
            //        ReturnParm.Direction = ParameterDirection.ReturnValue;
            //        command.Parameters.Add(ReturnParm);

            //        command.ExecuteNonQuery();

            //        return (int)ReturnParm.Value != 0;

            //    }
            //}

            return false;
        }

    }
}
