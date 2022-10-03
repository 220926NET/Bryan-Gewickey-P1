
 // public void Manager()
 // if (login == Manager.Username.get && pWord == Manager.Password.get)
        

public class Employee
{
    public Employee(string username, string password)
    {
        username = this.username;
        password = this.password;
    }

    Employee tim = new Employee("timtime", "66699969");
    Employee david = new Employee("David", "12344455");
    
    public bool IsManager = false;

    public string username = "David";
    public string password = "12344455";



}

public class Manager
{
    // Manager usernames start with M
    private string? username;
    

    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }

    private string? password;

    public Manager(string username, string password)
    {
        Username = this.username;
        Password = this.password;
    }

    // public Dictionary id = new Dictionary<string, string>;

}
