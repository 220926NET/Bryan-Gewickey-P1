using AuthService;
using Services;
using DataAccess;
using UI;
using Microsoft.Data.SqlClient;

    //TicketService service = new TicketService(repo);


    public void Start()
{
    while(true)
    {

    Console.WriteLine("                                                     ");
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine(("                                                  "));
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    Console.WriteLine(("                                                  "));
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("                                                     ");
    

    }
}

// Start screen

    // Login and Register Options

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[L]: Login to your account");
            Console.WriteLine("[R]: Register for a new account");
            Console.WriteLine("[0]: To exit the application");
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            string loginOrRegister = Console.ReadLine()!.Trim().ToLower();


            /// <summary>
            /// 
            /// </summary>
            switch (loginOrRegister)
            {
            case "l":
                Console.WriteLine("Welcome Back! Please enter your username: ");
                string uLogin = Console.ReadLine()!.Trim().ToLower();
            
                Console.WriteLine($"Great! Now enter your password");
                string pLogin = Console.ReadLine()!.Trim().ToLower();

                LoginMethod(uLogin, pLogin);

            break;
    
    
            case "r":

                Console.WriteLine("Let's create a new account! First, choose your username: (between 1-8 characters)");
                string usernameRegister = Console.ReadLine()!.Trim().ToLower();

                Console.WriteLine("Great! Please enter a new password: (between 6-10 characters)");
                string passwordRegister = Console.ReadLine()!.Trim().ToLower();
                

                RegisterUser(usernameRegister, passwordRegister);

            break;

            case "0":
                    Environment.Exit(0);
            break;

            default:
                    
                    System.Console.WriteLine("Not a valid input. Try again!");
            break;
                    }
       
    // Employee branch options after login
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[new]: To create a new ticket");
    Console.WriteLine("[status]: To check the status of a submitted ticket");
    Console.WriteLine("[manager]: To access manager menu");
    Console.WriteLine("[0]: To exit the application");

    /// <summary>
    /// Takes input from the user
    /// </summary>
    /// <returns></returns>
    string employeeOption = Console.ReadLine()!.Trim().ToLower();

    switch (employeeOption)
    {
        case "new":
            Console.WriteLine("Enter the amount of the expense: ");
                string amount = Console.ReadLine()!.Trim().ToLower();
            System.Console.WriteLine("Enter a description of the expense: ");
                string description = Console.ReadLine()!.Trim().ToLower();
            System.Console.WriteLine("Enter the date ");

            break;
        case "status":

            // System.Console.WriteLine($"Date of Expense: {expenseDate} \n Ticket Description: {description} \n Ticket Amount: {amount}\n Status: {status} \n Date Submitted: {submitDate}");

            
            break;

              case "0":
            Environment.Exit(0);
            break;
    }


    // Manager input options

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[process]: To process tickets");
    Console.WriteLine("[0]: To exit the application");

    string managerOption = Console.ReadLine()!.Trim().ToLower();

    switch (managerOption)
    {
        case "process":

        System.Console.WriteLine("Please enter the ticketID");
        string? ticketIDInput = Console.ReadLine()!.Trim().ToLower();
        System.Console.WriteLine("Please enter a number for ");

        break;

        case "0":
        Environment.Exit(0);
        break;

    }
