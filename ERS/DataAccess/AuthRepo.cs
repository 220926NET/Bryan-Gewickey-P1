using Models;
using Microsoft.Data.SqlClient;

namespace DataAccess;


public class AuthRepo : IUserStorage, ITicketStorage
{

    private SqlConnectionFactory _factory;

    public AuthRepo(SqlConnectionFactory factory) 
    {
        _factory = factory;
    }
    List<Employee> GetAllEmployees()
    {
        List<Employee> employees = new(string username, string password, bool IsManager);
        
         try
        {
            using SqlConnection conn = _factory.GetConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
            
            using SqlDataReader reader = command.ExecuteReader();
            
            if(reader.HasRows)
            {
                while(reader.Read()) 
                {
                    string username = (string) reader["Username"];
                    string password = (string) reader["Password"];
                    bool IsManager = (bool) reader["IsManager"];

                    Employee emp = new Employee {
                        Username = username,
                        Password = password,
                        IsManager = IsManager
                    };
    }

    Employee LoginEmployee(Employee LoginMethod)
    {
        employees.Contains(LoginMethod);

         try
        {
            using SqlConnection conn = _factory.GetConnection();
            conn.Open();

            //very dangerous code, do not do this
            // SqlCommand cmd = new SqlCommand($"INSERT INTO FlashCards (Question, Answer) VALUES ('{cardToCreate.Question}', '{cardToCreate.Answer}')", connection);

            //preventing against sql injection
            using SqlCommand cmd = new SqlCommand("INSERT INTO Tickets (ticketID, subDate, reason, amount, expDate, userID) OUTPUT INSERTED.ticketID VALUES ();", conn);
            cmd.Parameters.AddWithValue("@name", cardToCreate.Question);
            cmd.Parameters.AddWithValue("@pword", cardToCreate.Answer);
            cmd.Parameters.AddWithValue("@emp", addUser.)

            string insertedUsername = (string) cmd.ExecuteScalar();
            employee.Username = insertedUsername;
        }
        catch(SqlException)
        {
            throw;
        }

    }

    Employee RegisterEmployee(Employee RegisterUser)
    {
    
    {
        Employee employee = new();
        try
        {
            using SqlConnection conn = _factory.GetConnection();

            //open the connection
            conn.Open();

            //assemble the sql statement
            using SqlCommand cmd = new SqlCommand("UPDATE Users SET ", conn);

            //add all parameters, we can update either wasCorrect, Question, Answer of a card with this statement
            SqlParameter param = new SqlParameter("@isCorrect", cardToUpdate.CorrectlyAnswered == true ? 1 : 0);
            cmd.Parameters.Add(param);
            cmd.Parameters.AddWithValue("@q", cardToUpdate.Question);
            cmd.Parameters.AddWithValue("@a", cardToUpdate.Answer);
            cmd.Parameters.AddWithValue("@id", cardToUpdate.Id);

            using SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();

                card = new Employee {
                    Username = (string) reader["Username"],
                    Password = (string) reader["Question"],
                    IsManager = (bool) reader["IsManager"]
                };
            }
        }
        catch(SqlException)
        {
            throw;
        }

        return employee;
    }
}
    }

    public void ProcessTicket(bool IsManager, string amount, int status)
    {

    }
}

