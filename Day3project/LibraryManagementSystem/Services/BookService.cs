using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.Services
{
    public class BookService
    {
        DbHelper db = new DbHelper();

        public void ViewBooks()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT BOOK_CODE,BOOK_TITLE,AUTHOR FROM LMS_BOOK_DETAILS";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["BOOK_CODE"]} " +
                        $"{reader["BOOK_TITLE"]} " +
                        $"{reader["AUTHOR"]}");
                }
            }
        }
        public void AddBook()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                Console.Write("Book Code: ");
                string bookCode = Console.ReadLine();

                Console.Write("Book Title: ");
                string title = Console.ReadLine();

                Console.Write("Category: ");
                string category = Console.ReadLine();

                Console.Write("Author: ");
                string author = Console.ReadLine();

                Console.Write("Publication: ");
                string publication = Console.ReadLine();

                Console.Write("Publish Date (yyyy-mm-dd): ");
                DateTime publishDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Book Edition: ");
                int edition = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Rack Number: ");
                string rack = Console.ReadLine();

                Console.Write("Arrival Date (yyyy-mm-dd): ");
                DateTime arrivalDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Supplier Id: ");
                string supplierId = Console.ReadLine();

                string query = @"
        INSERT INTO LMS_BOOK_DETAILS
        (
            BOOK_CODE,
            BOOK_TITLE,
            CATEGORY,
            AUTHOR,
            PUBLICATION,
            PUBLISH_DATE,
            BOOK_EDITION,
            PRICE,
            RACK_NUM,
            DATE_ARRIVAL,
            SUPPLIER_ID
        )
        VALUES
        (
            @BookCode,
            @Title,
            @Category,
            @Author,
            @Publication,
            @PublishDate,
            @Edition,
            @Price,
            @Rack,
            @ArrivalDate,
            @SupplierId
        )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@BookCode", bookCode);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Publication", publication);
                cmd.Parameters.AddWithValue("@PublishDate", publishDate);
                cmd.Parameters.AddWithValue("@Edition", edition);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Rack", rack);
                cmd.Parameters.AddWithValue("@ArrivalDate", arrivalDate);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Book Added Successfully");
            }
        }

        public void UpdateBookPrice()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                Console.Write("Enter Book Code: ");
                string code = Console.ReadLine();

                Console.Write("Enter New Price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                string query =
                "UPDATE LMS_BOOK_DETAILS SET PRICE=@Price WHERE BOOK_CODE=@Code";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Code", code);

                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows > 0
                    ? "Book Updated Successfully"
                    : "Book Not Found");
            }
        }

        public void DeleteBook()
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                Console.Write("Enter Book Code: ");
                string code = Console.ReadLine();

                string query =
                "DELETE FROM LMS_BOOK_DETAILS WHERE BOOK_CODE=@Code";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Code", code);

                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows > 0
                    ? "Book Deleted Successfully"
                    : "Book Not Found");
            }
        }
    }
        }
    

