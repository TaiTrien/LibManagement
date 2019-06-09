using System;
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
    public class titlesDAL
    {
        public bool add(titlesDTO titles)
        {
            //add into DauSach table
            string queryAddTitles = string.Empty;
            queryAddTitles += "INSERT INTO DAUSACH (MaDauSach, TenDauSach) ";
            queryAddTitles += "VALUES (@MaDauSach, @TenDauSach)";
            //add author into DauSach_TacGia table
            string queryAddAuth = string.Empty;
            queryAddAuth += "INSERT INTO DAUSACH_TACGIA (MaDauSach, MaTacGia) ";
            queryAddAuth += "VALUES (@MaDauSach, @MaTacGia)";

            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;")) //Init connection to host
            {
                // to add titles and name of titles into table DAUSACH
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = queryAddTitles;
                    cmd.Parameters.AddWithValue("@MaDauSach", titles.MaDauSach);
                    cmd.Parameters.AddWithValue("@TenDauSach", titles.TenDauSach);
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
            using (SqlConnection con = new SqlConnection(@"server=" + Dns.GetHostName() + ";Trusted_Connection=yes;database=LIBMANAGEMENT;"))
            {
                using (SqlCommand cmd2 = new SqlCommand())
                {
                    cmd2.Connection = con;
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.CommandText = queryAddAuth;
                    cmd2.Parameters.AddWithValue("@MaDauSach", titles.MaDauSach);
                    cmd2.Parameters.AddWithValue("@MaTacGia", titles.MaTacGia);
                    try
                    {
                        con.Open();
                        cmd2.ExecuteNonQuery();
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
        public List<titlesDTO> selectedTitle()

        {
            string query = string.Empty;
            query += "SELECT MaDauSach, TenDauSach";
            query += " FROM DAUSACH";

            List<titlesDTO> lsTitles = new List<titlesDTO>();

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
                                titlesDTO titles = new titlesDTO();
                                titles.MaDauSach = reader["MaDauSach"].ToString();
                                titles.TenDauSach = reader["TenDauSach"].ToString();
                                lsTitles.Add(titles);
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
            return lsTitles;
        }
    }
}

