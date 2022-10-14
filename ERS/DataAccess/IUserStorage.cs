using Models;

namespace DataAccess;

public interface IUserStorage
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    List<Employee> GetAllEmployees();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="LoginMethod"></param>
    /// <returns></returns>
    Employee LoginEmployee(Employee LoginMethod);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="RegisterUser"></param>
    /// <returns></returns>
    Employee RegisterEmployee(Employee RegisterUser);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="IsManager"></param>
    /// <returns></returns>
    public bool CheckManager(bool IsManager);


}