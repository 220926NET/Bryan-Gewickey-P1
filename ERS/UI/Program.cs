
// Start screen
    
    Console.WriteLine("                                                     ");
    Console.WriteLine("/////////////////////////////////////////////////////");
    System.Console.WriteLine(("                                                  "));
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    System.Console.WriteLine(("                                                  "));
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("                                                     ");

    // Login and Register Options
    
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[L]: Login to your account");
            Console.WriteLine("[R]: Register for a new account");
            Console.WriteLine("[0]: To exit the application");
            string loginOrRegister = Console.ReadLine()!.Trim().ToLower();

            bool invalidInput;

            int wrongInputCounter = 0;
            while (loginOrRegister == null || wrongInputCounter <= 7 )
            {
            switch (loginOrRegister)
            {
            case "l":
                invalidInput = false;

                Console.WriteLine("Welcome Back! Please enter your username: ");
                string usernameLogin = Console.ReadLine()!.Trim().ToLower();
            
                Console.WriteLine($"Nice to see you, {usernameLogin}! Now enter your password");
                string passwordLogin = Console.ReadLine()!.Trim().ToLower();
                Employee x = new Employee(usernameLogin, passwordLogin, false);

                if (!invalidInput)

                invalidInput = false;
                            

                //x.Username.set(usernameLogin);
                //x.LoginMethod(usernameLogin);

            break;
    
    
            case "r":
                invalidInput = false;

                Console.WriteLine("Let's create a new account! First, choose your username: (between 1-8 characters)");
                string usernameRegister = Console.ReadLine()!.Trim().ToLower();

                Console.WriteLine("Great! Please enter a new password: (between 6-10 characters)");
                string passwordRegister = Console.ReadLine()!.Trim().ToLower();
                
                Employee y = new Employee(usernameRegister, passwordRegister, false);
            break;

            case "0":
                invalidInput = false;
                Environment.Exit(0);
            break;

                default:
                            invalidInput = true;
                            wrongInputCounter++;
                            System.Console.WriteLine(wrongInputCounter);
                            System.Console.WriteLine("Not a valid input. Try again!");
                        break;
                    }
            }
        
       
    // Employee Logged In branch options
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[new]: To create a new ticket");
    Console.WriteLine("[status]: To check the status of a submitted ticket");
    System.Console.WriteLine("[manager]: To access manager menu");
    Console.WriteLine("[0]: To exit the application");

    string employeeOption = Console.ReadLine()!.Trim().ToLower();

    switch (employeeOption)
    {
        case "new":
            Console.WriteLine("Enter the amount of the expense: ");
                string amount = Console.ReadLine()!.Trim().ToLower();
            System.Console.WriteLine("Enter a description of the expense: ");
                string description = Console.ReadLine()!.Trim().ToLower();

            //Ticket.SubmitTicket(amount, description);
            break;
        case "status":
            System.Console.WriteLine($"Date of Expense__________Ticket Description__________Ticket Amount____________Status_____________Date Submitted");

            

            break;

              case "0":
            Environment.Exit(0);
            break;
    }



    // Manager input options

    Console.WriteLine("What would you like to do?");
    System.Console.WriteLine("[check]: To check if there are new tickets in the queue");
    System.Console.WriteLine("[process]: To process tickets");
    System.Console.WriteLine("[new]: To create a new ticket");
    System.Console.WriteLine("[0]: To exit the application");

    string input3 = Console.ReadLine()!.Trim().ToLower();

    switch (input3)
    {
        case "process":
        // Call ticket queue (list)
        System.Console.WriteLine("Please enter the ticketID");
        string? ticketNumInput = Console.ReadLine()!.Trim().ToLower();
        // Ticket z = new Ticket()
        // Manager.ProcessTicket();
        // Manager.ApproveTicket(int TicketNum);
        break;

    }



/*
Stretch goals:


case "account":
            System.Console.WriteLine("Would you like to update your account information? \n [y]: yes [n]: no");
            var acct = Console.ReadKey();


*/