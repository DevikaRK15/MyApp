using LibraryManagementSystem.Services;


BookService bookService = new BookService();
MemberService memberService = new MemberService();
IssueService issueService = new IssueService();
ReportService reportService = new ReportService();

while (true)
{
    Console.WriteLine("\n===== LIBRARY MANAGEMENT SYSTEM =====");
    Console.WriteLine("1. View Books");
    Console.WriteLine("2. Add Book");
    Console.WriteLine("3. Update Book Price");
    Console.WriteLine("4. Delete Book");
    Console.WriteLine("5. View Members");
    Console.WriteLine("6. Add Member");
    Console.WriteLine("7. Issue Book");
    Console.WriteLine("8. Return Book");
    Console.WriteLine("9. View Issued Books");
    Console.WriteLine("10. Books Taken Report");
    Console.WriteLine("11. Available Books Report");
    Console.WriteLine("0. Exit");

    Console.Write("Enter Choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            bookService.ViewBooks();
            break;

        case 2:
            bookService.AddBook();
            break;

        case 3:
            bookService.UpdateBookPrice();
            break;

        case 4:
            bookService.DeleteBook();
            break;

        case 5:
            memberService.ViewMembers();
            break;

        case 6:
            memberService.AddMember();
            break;
        case 7:
            issueService.IssueBook();
            break;

        case 8:
            issueService.ReturnBook();
            break;

        case 9:
            issueService.ViewIssuedBooks();
            break;

        case 10:
            reportService.BooksTakenReport();
            break;

        case 11:
            reportService.AvailableBooks();
            break;

        case 0:
            Console.WriteLine("Thank You!");
            return;

        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}