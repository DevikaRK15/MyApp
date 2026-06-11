using Microsoft.Data.SqlClient;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Services
{
    public class MemberService
    {
        DbHelper db = new DbHelper();

        public void ViewMembers()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                "SELECT MEMBER_ID,MEMBER_NAME,CITY,MEMBERSHIP_STATUS FROM LMS_MEMBERS";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["MEMBER_ID"]} " +
                        $"{reader["MEMBER_NAME"]} " +
                        $"{reader["CITY"]} " +
                        $"{reader["MEMBERSHIP_STATUS"]}");
                }
            }
        }

        public void AddMember()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                Console.Write("Member Id: ");
                string id = Console.ReadLine();

                Console.Write("Member Name: ");
                string name = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Register Date (yyyy-mm-dd): ");
                DateTime regDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Expiry Date (yyyy-mm-dd): ");
                DateTime expDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Membership Status: ");
                string status = Console.ReadLine();

                string query =
                @"INSERT INTO LMS_MEMBERS
        VALUES(@id,@name,@city,@regDate,@expDate,@status)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@regDate", regDate);
                cmd.Parameters.AddWithValue("@expDate", expDate);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Member Added Successfully");
            }
        }
    }
}