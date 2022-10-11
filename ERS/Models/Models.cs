


namespace Models
{

public class Employee
{
    private string? _username;
    private string? _password;

        public Employee()
        {
            
        }

        private bool _isManager = false;

        public string Username { get => _username!; set => _username = value; }
        public string? Password { get => _password; set => _password = value; }
        public bool IsManager { get => _isManager; set => _isManager = value; }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Username == employee.Username;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Password);
        }
    }

public class Manager
{
    List<Manager> AllManagers = new List<Manager>{};

 
}

public class Ticket
{
    int? TicketID;
    


}
}
