using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SampleCloud
{
    public class DataClass
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable SelectCountry()
        {
            cmd = new SqlCommand("sp_SelectCountry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void InsertUserData(PropertyClass PS)
        {
            cmd = new SqlCommand("sp_InsertUserData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", PS.FirstName);
            cmd.Parameters.AddWithValue("@LastName", PS.LastName);
            cmd.Parameters.AddWithValue("@Email", PS.Email);
            cmd.Parameters.AddWithValue("@FK_CountryID", PS.CountryID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable SelectUserData()
        {
            cmd = new SqlCommand("sp_SelectUserData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdataUserData(PropertyClass PS)
        {
            cmd = new SqlCommand("sp_UpdataUserData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", PS.FirstName);
            cmd.Parameters.AddWithValue("@LastName", PS.LastName);
            cmd.Parameters.AddWithValue("@Email", PS.Email);
            cmd.Parameters.AddWithValue("@UserID", PS.UserID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteUserData(PropertyClass PS)
        {
            cmd = new SqlCommand("sp_DeleteUserData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserID", PS.UserID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}