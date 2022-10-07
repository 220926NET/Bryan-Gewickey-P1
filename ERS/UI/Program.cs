using DataAccess;


    // initializing list of tickets
    // List<Tickets> AllTickets = new List<Tickets>();
    
    // initializing dictionary of usernames and passwords
    Dictionary<Username, Password> AllUsernames = new Dictionary<Username, Password>();



    // Deserialization




// Start screen
    
    Console.WriteLine("                                                     ");
    Console.WriteLine("/////////////////////////////////////////////////////");
    System.Console.WriteLine(("                                                  "));
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    System.Console.WriteLine(("                                                  "));
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("                                                     ");


    

    Console.WriteLine("Do you have an account already? Type \"login\" or \"register\" to continue. Type 0 to exit.");
    string intro = Console.ReadLine()!.Trim().ToLower();


        if (intro == null)
        {
            Console.WriteLine("Oops, you didn't write anything. Please try again: ");
            string retry = Console.ReadLine()!.Trim().ToLower();
            if (retry == null)
            {}

        }
        else if (intro != null)
        {
            switch (intro)
        {
            case "login":
        Console.WriteLine("Welcome Back! Please enter your username.");
        string login = Console.ReadLine()!.Trim().ToLower();
        // if (login == AllUsernames.username)
        Console.WriteLine("Great! Now enter your password");
        string pWord = Console.ReadLine()!.Trim().ToLower();
            break;

            case "register":

        Console.WriteLine("Let's create a new account! First, choose your username: (must be 1-6 characters)");
        string value = Console.ReadLine()!.Trim().ToLower();
        Console.WriteLine("Great! Please enter a new password: (must be 8-12 characters)");
        string regPassword = Console.ReadLine()!.Trim().ToLower();
            //if (regPassword == Manager.password)
            break;
        
            case "0":
            Environment.Exit(0);
            break;
        }
        }

    // Employee Logged In branch options
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[new]: To create a new ticket");
    Console.WriteLine("[status]: To check the status of a submitted ticket");
    Console.WriteLine("[account]: To view and update your account info");
    Console.WriteLine("[0]: To exit the application");

    string input2 = Console.ReadLine()!.Trim().ToLower();

    switch (input2)
    {
        case "new":
            System.Console.WriteLine("Enter the amount of the expense: ");
                string amount = Console.ReadLine()!.Trim().ToLower();
            System.Console.WriteLine("Enter a description of the expense: ");
                string description = Console.ReadLine()!.Trim().ToLower();
            //Tickets.SubmitTicket(amount, description);
            break;
        case "status":
            System.Console.WriteLine("Date of Expense__________Ticket Description__________Ticket Amount____________Status_____________Date Submitted");
            System.Console.WriteLine("__________________________________________________________");


            break;
        case "account":

            break;

              case "0":
            Environment.Exit(0);
            break;
    }



    // Manager Logged In branch options

    Console.WriteLine("What would you like to do?");
    System.Console.WriteLine("[check]: To check if there are new tickets in the queue");
    System.Console.WriteLine("[process]: To process tickets");
    System.Console.WriteLine("[new]: To create a new ticket");
    System.Console.WriteLine("[account]: To view and update your account info");
    System.Console.WriteLine("[0]: To exit the application");

    string input3 = Console.ReadLine()!.Trim().ToLower();

    switch (input3)
    {
        case "process":
        // Call ticket queue (list)
        System.Console.WriteLine("Please enter the ticketID");
        string? ticketNumInput = Console.ReadLine();
        // Manager.ProcessTicket();
        // Manager.ApproveTicket(int TicketNum);
        break;

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
