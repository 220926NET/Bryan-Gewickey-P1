


namespace Models
{
/// <summary>
/// 
/// </summary>
public class Employee
{

    /// <summary>
    /// 
    /// </summary>
    private string? _username;
    private string? _password;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="IsManager"></param>
        public Employee(string username, string password, bool IsManager = false)
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        private bool _isManager = false;

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string? Username { get => _username; set => _username = value; }
        public string? Password { get => _password; set => _password = value; }
        public bool IsManager { get => _isManager; set => _isManager = value; }

}
/// <summary>
/// 
/// </summary>
public class Manager : Employee
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <param name="IsManager"></param>
    /// <returns></returns>
    public Manager(string username,
                   string password,
                   bool IsManager = true) : base(username, password, IsManager)
    {
        IsManager = true;
        username = this.Username;
        password = this.Password;
    }

}
/// <summary>
/// Class for creating Tickets
/// </summary>
public class TicketObj
{
    // Queue for Submitted Tickets
    public Queue<int> AllTickets = new Queue<int>();

 ///Ticket created from Submit Ticket Method

    public TicketObj(string amount, string description, string submitDate, string expenseDate, int status)
    {
    
    }
///
///Submitted Ticket that can be called from ViewTicketStatus or proccessed by ProccessTicket Method
    public TicketObj(int ticketId,
        int ticketstatus,
        string usernameSubmitter,
        string usernameProcessor)
    {
         // Manager ID? Employee ID?

    }
}
}


