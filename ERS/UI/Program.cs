


    var Allusernames = new HashSet<string>();
    var Allpasswords = new HashSet<string>();


// Start screen
    
    Console.WriteLine("                                                     ");
    Console.WriteLine("/////////////////////////////////////////////////////");
    System.Console.WriteLine(("                                                  "));
    Console.WriteLine("Welcome to the Revature Expense Reimbursement System!");
    System.Console.WriteLine(("                                                  "));
    Console.WriteLine("/////////////////////////////////////////////////////");
    Console.WriteLine("                                                     ");


    

    Console.WriteLine("Do you have an account already?");
    System.Console.WriteLine("[L]: Login to your account");
    System.Console.WriteLine("[R]: Register for a new account");
    System.Console.WriteLine("[0]: Exit.");
    string loginOrRegister = Console.ReadLine()!.Trim().ToLower();
    
    bool invalidInput;

            switch (loginOrRegister)
            {
            case "l":
                invalidInput = false;
                Console.WriteLine("Welcome Back! Please enter your username.");
                string usernameLogin = Console.ReadLine()!.Trim().ToLower();

                Employee x = new Employee();
            
                if (usernameLogin.Equals(x))
                {
                Allusernames.Add(usernameLogin);
                Console.WriteLine("Great! Now enter your password");
                string passwordLogin = Console.ReadLine()!.Trim().ToLower();
                HashCode.Combine(passwordLogin);
                Allpasswords.Add(passwordLogin);
                } 
                else
                {
                System.Console.WriteLine("Not a valid username.");
                System.Console.WriteLine();
                }
            break;

            case "r":
                invalidInput = false;
                Console.WriteLine("Let's create a new account! First, choose your username: (between 1-8 characters)");
                string usernameRegister = Console.ReadLine()!.Trim().ToLower();
                if (usernameRegister.Length > 1 && usernameRegister.Length < 8)
                {
                Allusernames.Add(usernameRegister);
                Employee y = new Employee();
  
                }
            else
            {
                System.Console.WriteLine("Username must be between 1-8 characters.");
            }

            Console.WriteLine("Great! Please enter a new password: (between 6-10 characters)");
            string passwordRegister = Console.ReadLine()!.Trim().ToLower();
            if (passwordRegister.Length > 6 || passwordRegister.Length < 10)
            {
                HashCode.Combine(passwordRegister);
                Allpasswords.Add(passwordRegister);
            }
            else
            {
                System.Console.WriteLine("Invalid password, please enter a pwassword between 6-10 characters.");
            }
            break;
        
            case "0":
            invalidInput = false;
            Environment.Exit(0);
            break;

            default:
            invalidInput = true;
            break;
            }
            int wrongInputCounter = 0;
            while (loginOrRegister == null || invalidInput == true && wrongInputCounter <= 10 )
            {

                Console.WriteLine("That was confusing. If you have an account already, type [L] to login, type [R] to register, and to exit, type [0]: ");
                string retry = Console.ReadLine()!.Trim().ToLower();
                    switch (retry)
                    {
                        
                        case "l":
                            invalidInput = false;
                            Console.WriteLine("Welcome Back! Please enter your username.");
                            string usernameLogin = Console.ReadLine()!.Trim().ToLower();
                             
                            Employee x = new Employee();
            
                            if (usernameLogin.Equals(x))
                            {
                            Allusernames.Add(usernameLogin);
                            Console.WriteLine("Great! Now enter your password");
                            string passwordLogin2 = Console.ReadLine()!.Trim().ToLower();

                            } else
                            {
                            System.Console.WriteLine("Not a valid username.");
                            }
                            break;

                            case "r":
                            invalidInput = false;
                            Console.WriteLine("Let's create a new account! First, choose your username: (must be 1-6 characters)");
                            string usernameRegister = Console.ReadLine()!.Trim().ToLower();
                            Console.WriteLine("Great! Please enter a new password: (must be 8-12 characters)");
                            string passwordRegister = Console.ReadLine()!.Trim().ToLower();
                            //if (regPassword == Manager.password)
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
        
    invalidInput = false;
       
    // Employee Logged In branch options
    
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[new]: To create a new ticket");
    Console.WriteLine("[status]: To check the status of a submitted ticket");
    Console.WriteLine("[account]: To view and update your account info");
    Console.WriteLine("[0]: To exit the application");

    string employeeOption = Console.ReadLine()!.Trim().ToLower();

    switch (employeeOption)
    {
        case "new":
            System.Console.WriteLine("Enter the amount of the expense: ");
                string amount = Console.ReadLine()!.Trim().ToLower();
            System.Console.WriteLine("Enter a description of the expense: ");
                string description = Console.ReadLine()!.Trim().ToLower();

            //Ticket.SubmitTicket(amount, description);
            break;
        case "status":
            System.Console.WriteLine("Date of Expense__________Ticket Description__________Ticket Amount____________Status_____________Date Submitted");
            System.Console.WriteLine("__________________________________________________________");


            break;
        case "account":
            System.Console.WriteLine("Would you like to update your account information? \n [y]: yes [n]: no");
            var acct = Console.ReadKey();
            


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



    public class Password
{
    Password p = new Password();
}

public class Username
{
    Username n = new Username();
}

 // Dictionary<TicketID, Employee.username> AllTickets = new Dictionary<TicketID, Username>();