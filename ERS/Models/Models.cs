


namespace Models
{

public class Employee
{
    private string? _username;
    private string? _password;

        public Employee(string username, string password, bool IsManager)
        {
            
        }

        private bool _isManager = false;

        public string? Username { get => _username; set => _username = value; }
        public string? Password { get => _password; set => _password = value; }
        public bool IsManager { get => _isManager; set => _isManager = value; }

        public override int GetHashCode()
        {
            return HashCode.Combine(Password);
        }
    }

public class Manager : Employee
{
    public Manager(string username,
                   string password,
                   bool IsManager) : base(username, password, IsManager)
    {
        IsManager = true;
        username = this.Username;
        password = this.Password;
    }

}
}
