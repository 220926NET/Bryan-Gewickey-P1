
// Start screen
    
    Console.WriteLine("                                                     ");
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("                                                     ");


    

    Console.WriteLine("Do you have an account already? Type \"login\" or \"register\" to continue. Type 0 to exit.");
    string intro = "";
    intro = Console.ReadLine()!.Trim().ToLower();


        try 
        {

        intro = intro.ToLower();

        } 
        catch (System.NullReferenceException e) 
        {
            Console.WriteLine(e.Message);

        Console.WriteLine("Username must be at least 6 characters.");
        
        }

        if (intro == "login")
        {
        Console.WriteLine("Welcome Back! Please enter your username.");
        string login = Console.ReadLine()!.Trim().ToLower();

        
        Console.WriteLine("Great! Now enter your password");
        string pWord = Console.ReadLine()!.Trim().ToLower();
        
        } 
        
        else if (intro == "register")
        
        {
        Console.WriteLine("Let's create a new account! First, choose your username: (must be 1-6 characters)");
        string value = Console.ReadLine()!.Trim().ToLower();

        Console.WriteLine("Great! Please enter a new password: (must be 8-12 characters)");
        string regPassword = Console.ReadLine()!.Trim().ToLower();
        } 
        else if (intro == "0")
        {
        Environment.Exit(0);
        
        }

    // Employee Logged In branch options
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[new]: To create a new ticket");
    Console.WriteLine("[status]: To check the status of a submitted ticket");
    Console.WriteLine("[account]: To view and update your account info");
    Console.WriteLine("[exit]: To exit the application");



    // Manager Logged In branch options

    Console.WriteLine("What would you like to do?");
    System.Console.WriteLine("[check]: To check if there are new tickets in the queue");
    System.Console.WriteLine("[process]: To process tickets");
    System.Console.WriteLine("[new]: To create a new ticket");
    System.Console.WriteLine("[account]: To view and update your account info");
    System.Console.WriteLine("[exit]: To exit the application");

    string input = Console.ReadLine()!.Trim().ToLower();

    if (input == "process")
    {
        // Call ticket queue (list)
        System.Console.WriteLine("Please enter the ticketNum");
        string? ticketNumInput = Console.ReadLine();
        // Manager.ProcessTicket();
        // Manager.ApproveTicket(int TicketNum);
    }



// static string ApproveTicket(bool IsManager)
//     {
//         string result;
//         if (IsManager == true)
//         {
//             Console.WriteLine("Ticket approved!");
//             result = "Approved";
//         } else 
//         {
//             Console.WriteLine("Please enter Manager password if you are a manager.");
//             result = "Denied";
//         }
        
//         return result;
//     }
