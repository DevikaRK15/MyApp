using Microsoft.Data.SqlClient;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Services
{
    public class IssueService
    {
        DbHelper db = new DbHelper();

        public void ViewIssuedBooks()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                @"SELECT BOOK_ISSUE_NO,
                         MEMBER_ID,
                         BOOK_CODE,
                         BOOK_ISSUE_STATUS
                  FROM LMS_BOOK_ISSUE";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["BOOK_ISSUE_NO"]} " +
                        $"{reader["MEMBER_ID"]} " +
                        $"{reader["BOOK_CODE"]} " +
                        $"{reader["BOOK_ISSUE_STATUS"]}");
                }
            }
        }

        public void IssueBook()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                Console.Write("Issue No: ");
                int issueNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Member Id: ");
                string memberId = Console.ReadLine();

                Console.Write("Book Code: ");
                string bookCode = Console.ReadLine();

                string query =
                @"INSERT INTO LMS_BOOK_ISSUE
        (
            BOOK_ISSUE_NO,
            MEMBER_ID,
            BOOK_CODE,
            DATE_ISSUE,
            DATE_RETURN,
            DATE_RETURNED,
            BOOK_ISSUE_STATUS,
            FINE_RANGE
        )
        VALUES
        (
            @IssueNo,
            @MemberId,
            @BookCode,
            GETDATE(),
            DATEADD(DAY,15,GETDATE()),
            NULL,
            'N',
            'R1'
        )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IssueNo", issueNo);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@BookCode", bookCode);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Book Issued Successfully");
            }
        }
        public void ReturnBook()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                Console.Write("Issue Number: ");
                int issueNo = Convert.ToInt32(Console.ReadLine());

                string query =
                @"UPDATE LMS_BOOK_ISSUE
          SET DATE_RETURNED = GETDATE(),
              BOOK_ISSUE_STATUS='Y'
          WHERE BOOK_ISSUE_NO=@IssueNo";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IssueNo", issueNo);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Book Returned Successfully");
            }
        }
    }
}