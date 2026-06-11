using Microsoft.Data.SqlClient;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Services
{
    public class ReportService
    {
        DbHelper db = new DbHelper();

        public void BooksTakenReport()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT M.MEMBER_NAME,
                       B.BOOK_TITLE
                FROM LMS_BOOK_ISSUE I
                JOIN LMS_MEMBERS M
                    ON I.MEMBER_ID = M.MEMBER_ID
                JOIN LMS_BOOK_DETAILS B
                    ON I.BOOK_CODE = B.BOOK_CODE";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["MEMBER_NAME"]} --> {reader["BOOK_TITLE"]}");
                }
            }
        }

        public void AvailableBooks()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT *
                FROM LMS_BOOK_DETAILS
                WHERE BOOK_CODE NOT IN
                (
                    SELECT BOOK_CODE
                    FROM LMS_BOOK_ISSUE
                    WHERE BOOK_ISSUE_STATUS = 'N'
                )";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["BOOK_CODE"]} {reader["BOOK_TITLE"]}");
                }
            }
        }
    }
}