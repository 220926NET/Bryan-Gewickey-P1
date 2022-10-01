
 // Login/Register Branching

    Console.WriteLine("Do you have an account already? Type Login or Register");
    string? intro;
    intro = Console.ReadLine();
    intro = intro.ToLower();

    if (intro == "login")
    {
        Console.WriteLine("Welcome Back! Please enter your username and password");
        
    
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