namespace Services;
public class Class1
{
    static string ApproveTicket(bool IsManager)
    {
        string result;
        if (IsManager == true)
        {
            Console.WriteLine("Ticket approved!");
            result = "Approved";
        } else 
        {
            Console.WriteLine("Please enter Manager password if you are a manager.");
            result = "Denied";
        }
        
        return result;
    }
}
