// Start screen
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    Console.WriteLine("_____________________________________________________");


 // Login/Register Branching




    Console.WriteLine("Do you have an account already? Type \"login\" or \"register\" to continue. Type 0 to exit.");
    string? intro;
    intro = Console.ReadLine();
    try {
        intro = intro.ToLower();
    } catch (System.NullReferenceException e) 
    {
        Console.WriteLine("Username must be at least 6 characters.");
    }

    if (intro == "login")
    {
        Console.WriteLine("Welcome Back! Please enter your username and password");

    
    } else if (intro == "register")
    {
        Console.WriteLine("Let's create a new account! First, choose your username: (must contain 6 characters)");
        string? username = Console.ReadLine();
    }
    

public class Ticket
{


    // User Role Validation



    // Ticket Submission
    private decimal? ticketAmt;
    private string? ticketDesc;

    public string? TicketDesc { get => ticketDesc; set => ticketDesc = value; }
    public decimal? TicketAmt { get => ticketAmt; set => ticketAmt = value; }
}