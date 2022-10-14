using Models;

namespace Services;

/// <summary>
/// 
/// </summary>
public class LoginRegister
{
    public static string LoginMethod(string usernameLogin, string passwordLogin, List<Employee> employees)
    {
        bool isValid;
        if (usernameLogin.Equals(employees.username))

        if (usernameLogin.Length <= 10 && passwordLogin.Length >= 5 && passwordLogin.Length <= 10)
        {
            isValid = true;
            Employee e = new Employee(usernameLogin, passwordLogin, false);
            return $"Employee login was succesful: {isValid}";
        }
        else if (passwordLogin.Contains("%m") && usernameLogin.Length <= 10 && passwordLogin.Length <= 10)
        {
            isValid = true;
            Manager m = new Manager(usernameLogin, passwordLogin, true);
            return $"Manager login was successful: {isValid}";
        }
        else
        {
            isValid = false;
            return $"Login successful: {isValid}";
        }

    }

    /// <summary>
    /// Creates a new account for a user and validates the username and password length
    /// </summary>
    /// <param name="usernameRegister"></param>
    /// <param name="passwordRegister"></param>
     public string RegisterUser(string usernameRegister, string passwordRegister)
    {

         if (usernameRegister.Length <= 10 && passwordRegister.Length >= 5 && passwordRegister.Length <= 10)
                {
                    return "Username or password invalid. Username must be 1-10 characters and password must be 5-10 characters.";
                }
                else
                {
                    return  "User Registered!";
                }  
    }
}