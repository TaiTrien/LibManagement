﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using QLTVDTO;
namespace QLTVDAL
{
    public class authDAL
    {
        public authDAL()
        {
           
        }
        public bool add(authDTO auth)
        {
            string query = string.Empty;
            query += "INSERT INTO TACGIA (MaTacGia, HoTen, NgaySinh) ";
            query += "VALUES (@MaTacGia, @HoTen, @NgaySinh)";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaTacGia", auth.MaTacGia);
                    cmd.Parameters.AddWithValue("@HoTen", auth.TenTacGia);
                    cmd.Parameters.AddWithValue("@NgaySinh", auth.NgaySinh);
                  
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        //to delete selected author
        public bool del(authDTO auth)
        {
            string query = string.Empty;
            query += "DELETE FROM TACGIA ";
            query += "WHERE MaTacGia = @mtg";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mtg", auth.MaTacGia);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        //to modify selected author
        public bool mod(authDTO auth)
        {
            string query = string.Empty;
            query += "UPDATE TACGIA SET ";
            query += "HoTen = @ht, NgaySinh = @ngs ";
            query += "WHERE MaTacGia=@mtg";
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mtg", auth.MaTacGia);
                    cmd.Parameters.AddWithValue("@ht", auth.TenTacGia);
                    cmd.Parameters.AddWithValue("@ngs", auth.NgaySinh);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        //to select a single author from db
        public authDTO selectSingleAuth(string authCode)
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM TACGIA WHERE MaTacGia =" + authCode;
            authDTO selectedAuth = new authDTO();

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                selectedAuth.MaTacGia = authCode;
                                selectedAuth.TenTacGia = reader["HoTen"].ToString();
                                selectedAuth.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return selectedAuth;
        }
        //to select authores from db
        public List<authDTO> selectedAuth()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += "FROM TACGIA";

            List<authDTO> lsAuth = new List<authDTO>();

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                authDTO auth = new authDTO();
                                auth.MaTacGia=reader["MaTacGia"].ToString();
                                auth.TenTacGia = reader["HoTen"].ToString();
                                auth.NgaySinh= Convert.ToDateTime(reader["NgaySinh"]);
                                lsAuth.Add(auth);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsAuth;
        }
    }
}
