// Start screen
    
    Console.WriteLine("                                                     ");
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("                                                     ");
    

 // Login/Register Branching

    // Manager m1 = new Manager("value", "value");



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
        Console.WriteLine("Welcome Back! Please enter your username.");
        string? login = Console.ReadLine();

        


        Console.WriteLine("Great! Now enter your password");
        string? pWord = Console.ReadLine();

        
        
    
    } else if (intro == "register")
    {
        Console.WriteLine("Let's create a new account! First, choose your username: (must be 1-6 characters)");
        string? value = Console.ReadLine();

        Console.WriteLine("Great! Please enter a new password: (must be 8-12 characters)");
        string? regPassword = Console.ReadLine();
    } else if (intro == "0")
    {
        Environment.Exit(0);
        
    }

    // Employee Logged In branch options
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[new]: To create a new ticket");
    Console.WriteLine("[status]: To check the status of a submitted ticket");
    Console.WriteLine("[account]: To view and update your account info");
    Console.WriteLine("[exit]: To exit the application");

public class Ticket
{


    // User Role Validation



    // Ticket Submission
    private decimal? ticketAmt;
    private string? ticketDesc;

    public string? TicketDesc { get => ticketDesc; set => ticketDesc = value; }
    public decimal? TicketAmt { get => ticketAmt; set => ticketAmt = value; }
}